using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeatNeuralNetwork
{
    public partial class LearningProcess : Form
    {
        MainWindow main;
        Thread t;
        static public int ambientTemperature = 0;
        static public List<Plot> sets = new List<Plot>();
        static public List<Neuron> neuronsLayerInputLearning = new List<Neuron>();
        static public List<Neuron> neuronsLayerHiddenLearning1 = new List<Neuron>();
        static public List<Neuron> neuronsLayerHiddenLearning2 = new List<Neuron>();
        static public List<Neuron> neuronsLayerOutputLearning = new List<Neuron>();
        static public double A = 0.5;
        static public double E = 50;
        static public int era = 0;
        static public int trainingSet = 0;
        static public double errorGeneral = 0;
        static public bool outputNN = true;
        static Mutex mutexObj = new Mutex();

        public LearningProcess(TeachNN teach, MainWindow main)
        {
            InitializeComponent();
            sets = teach.sets;
            this.main = main;
            ambientTemperature = main.ambientTemperature;
            Random rand = new Random();
            Neuron neuron;
            for (int i = 0; i < 11; i++)
            {
                neuron = new Neuron();
                List<double> buffw = new List<double>();
                List<double> buffg = new List<double>();
                List<double> buffd = new List<double>();
                for (int k = 0; k < 7; k++)
                {
                    buffw.Add(rand.Next(10) - 5 + rand.NextDouble());
                    buffg.Add(0);
                    buffd.Add(0);
                    Thread.Sleep(10);
                }
                neuron.weights.AddRange(buffw);
                neuron.gradients.AddRange(buffg);
                neuron.deltaW.AddRange(buffd);
                neuronsLayerInputLearning.Add(neuron);
            }
            for (int i = 0; i < 7; i++)
            {
                neuron = new Neuron();
                List<double> buffw = new List<double>();
                List<double> buffg = new List<double>();
                List<double> buffd = new List<double>();
                for (int k = 0; k < 5; k++)
                {
                    buffw.Add(rand.Next(10) - 5 + rand.NextDouble());
                    buffg.Add(0);
                    buffd.Add(0);
                    Thread.Sleep(10);
                }
                neuron.weights.AddRange(buffw);
                neuron.gradients.AddRange(buffg);
                neuron.deltaW.AddRange(buffd);
                neuronsLayerHiddenLearning1.Add(neuron);
            }
            for (int i = 0; i < 5; i++)
            {
                neuron = new Neuron();
                List<double> buffw = new List<double>();
                List<double> buffg = new List<double>();
                List<double> buffd = new List<double>();
                for (int k = 0; k < 3; k++)
                { 
                    buffw.Add(rand.Next(10) - 5 + rand.NextDouble());
                    buffg.Add(0);
                    buffd.Add(0);
                    Thread.Sleep(10);
                }
                neuron.weights.AddRange(buffw);
                neuron.gradients.AddRange(buffg);
                neuron.deltaW.AddRange(buffd);
                neuronsLayerHiddenLearning2.Add(neuron);
            }
            for (int i = 0; i < 3; i++)
            {
                neuron = new Neuron();
                neuronsLayerOutputLearning.Add(neuron);
            }
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            mutexObj.WaitOne();
            // t.Suspend();
            
            //mutexObj.ReleaseMutex();
            
            bSaveLearn.Enabled = true;
            bStop.Enabled = false;
            bStart.Enabled = true;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (t == null)
            {
                t = new Thread(new ThreadStart(Learn));
                t.Start();
                bStart.Text = "Возобновить";
                bStart.Enabled = false;
                bStop.Enabled = true;
                bSaveLearn.Enabled = false;
            }
            else if (t != null)
            {
                // t.Resume();
                bSaveLearn.Enabled = false;
                bStart.Enabled = false;
                bStop.Enabled = true;
                mutexObj.ReleaseMutex();
            }
        }

        public static void Learn()
        {
            //InitNN();
            while (true)
            {
                outputNN = false;
                mutexObj.WaitOne();
                //Инициализация сета (обнуление переменных)
                InitTrainingSet();
                //Ввод данных нового сета
                InputDataInNN();
                //Пропускаем информацию через нейронную сеть
                ILToHL1();
                HL1ToHL2();
                //След функция вырабатывает ответ
                HL2ToOL();
                //Поиск ошибки, дельты ошибки и изменение весов
                FindErrorOutput();
                mutexObj.ReleaseMutex();
                outputNN = true;
                FindErrorAndCorrectWeightHL2();
                FindErrorAndCorrectWeightHL1();
                FindErrorAndCorrectWeightIL();

                //Thread.Sleep(40);
                if (trainingSet >= 8)
                {
                    trainingSet = 0;
                    era++;
                }
                trainingSet++;
            }
        }

        public static void InitNN()
        {       }

        public static void InitTrainingSet()
        {
            for (int i = 0; i < 11; i++)
            {
                neuronsLayerInputLearning[i].input = 0;
                neuronsLayerInputLearning[i].output = 0;
                neuronsLayerInputLearning[i].delta = 0;
            }
            for (int i = 0; i < 7; i++)
            {
                neuronsLayerHiddenLearning1[i].input = 0;
                neuronsLayerHiddenLearning1[i].output = 0;
                neuronsLayerHiddenLearning1[i].delta = 0;
            }
            for (int i = 0; i < 5; i++)
            {
                neuronsLayerHiddenLearning2[i].input = 0;
                neuronsLayerHiddenLearning2[i].output = 0;
                neuronsLayerHiddenLearning2[i].delta = 0;
            }
            for (int i = 0; i < 3; i++)
            {
                neuronsLayerOutputLearning[i].input = 0;
                neuronsLayerOutputLearning[i].output = 0;
                neuronsLayerOutputLearning[i].delta = 0;
            }
        }

        public static void InputDataInNN()
        {

            neuronsLayerInputLearning[0].Sigmoid(sets[trainingSet].pipelineLength);
            neuronsLayerInputLearning[1].Sigmoid(sets[trainingSet].pipelineDiameter);
            neuronsLayerInputLearning[2].Sigmoid(sets[trainingSet].operatingPressure);
            neuronsLayerInputLearning[3].Sigmoid(sets[trainingSet].workingTemperature);
            neuronsLayerInputLearning[4].Sigmoid(sets[trainingSet].lifeCycle);
            neuronsLayerInputLearning[5].Sigmoid(sets[trainingSet].numberDays);
            neuronsLayerInputLearning[6].Sigmoid(sets[trainingSet].numberBreakdowns);
            neuronsLayerInputLearning[7].Sigmoid(sets[trainingSet].placesBreakdowns);
            neuronsLayerInputLearning[8].Sigmoid(sets[trainingSet].price);
            neuronsLayerInputLearning[9].Sigmoid(ambientTemperature);
            neuronsLayerInputLearning[10].output = 1;

        }
        public static void ILToHL1()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 11; j++)
                    neuronsLayerHiddenLearning1[i].input =
                        neuronsLayerHiddenLearning1[i].input +
                        neuronsLayerInputLearning[j].output * 
                        neuronsLayerInputLearning[j].weights[i];

                neuronsLayerHiddenLearning1[i].Sigmoid();
            }
            neuronsLayerHiddenLearning1[6].output = 1;
        }
        public static void HL1ToHL2()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                    neuronsLayerHiddenLearning2[i].input =
                        neuronsLayerHiddenLearning2[i].input +
                        neuronsLayerHiddenLearning1[j].output *
                        neuronsLayerHiddenLearning1[j].weights[i];

                neuronsLayerHiddenLearning2[i].Sigmoid();
            }
            neuronsLayerHiddenLearning2[4].output = 1;
        }
        public static void HL2ToOL()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                    neuronsLayerOutputLearning[i].input =
                        neuronsLayerOutputLearning[i].input +
                        neuronsLayerHiddenLearning2[j].output *
                        neuronsLayerHiddenLearning2[j].weights[i];

                neuronsLayerOutputLearning[i].Sigmoid();
            }
        }

        public static void FindErrorOutput()
        {
            double O1 = neuronsLayerOutputLearning[0].output;
            double O2 = neuronsLayerOutputLearning[1].output;
            double O3 = neuronsLayerOutputLearning[2].output;
            double TO1 = 1.0 / sets[trainingSet].daysAnswer;
            double TO2 = 1.0 / sets[trainingSet].pointAnswer;
            double TO3 = 1.0 / sets[trainingSet].priceAnswer;
            double error1 = TO1 - O1;
            double error2 = TO2 - O2;
            double error3 = TO3 - O3;
            errorGeneral = ((error1 * error1) + 
                (error2 * error2) + 
                (error3 * error3)) / 3;
            neuronsLayerOutputLearning[0].delta = error1 * ((1-O1) * O1);
            neuronsLayerOutputLearning[1].delta = error2 * ((1 - O2) * O2);
            neuronsLayerOutputLearning[2].delta = error3 * ((1 - O3) * O3);
        }

        public static void FindErrorAndCorrectWeightHL2()
        {
            for (int i = 0; i < 5; i++)
            {
                double OH1 = neuronsLayerHiddenLearning2[i].output;
                double summ = 0;
                for (int k = 0; k < 3; k++)
                {
                    summ += neuronsLayerHiddenLearning2[i].weights[k] * neuronsLayerOutputLearning[k].delta;
                }
                neuronsLayerHiddenLearning2[i].delta = ((1 - OH1) * OH1) * summ;
                for (int k = 0; k < 3; k++)
                {
                    neuronsLayerHiddenLearning2[i].gradients[k] = neuronsLayerOutputLearning[k].delta * OH1;

                    neuronsLayerHiddenLearning2[i].deltaW[k] = E * neuronsLayerHiddenLearning2[i].gradients[k] +
                        A * neuronsLayerHiddenLearning2[i].deltaW[k];

                    neuronsLayerHiddenLearning2[i].weights[k] = neuronsLayerHiddenLearning2[i].weights[k] +
                        neuronsLayerHiddenLearning2[i].deltaW[k];
                }
                
            }
        }

        public static void FindErrorAndCorrectWeightHL1()
        {
            for (int i = 0; i < 7; i++)
            {
                double OH1 = neuronsLayerHiddenLearning1[i].output;
                double summ = 0;
                for (int k = 0; k < 5; k++)
                {
                    summ += neuronsLayerHiddenLearning1[i].weights[k] * neuronsLayerHiddenLearning2[k].delta;
                }
                for (int k = 0; k < 5; k++)
                {
                        neuronsLayerHiddenLearning1[i].gradients[k] = neuronsLayerHiddenLearning2[k].delta * OH1;

                    neuronsLayerHiddenLearning1[i].deltaW[k] = E * neuronsLayerHiddenLearning1[i].gradients[k] +
                        A * neuronsLayerHiddenLearning1[i].deltaW[k];

                    neuronsLayerHiddenLearning1[i].weights[k] = neuronsLayerHiddenLearning1[i].weights[k] +
                        neuronsLayerHiddenLearning1[i].deltaW[k];
                }
                neuronsLayerHiddenLearning1[i].delta = ((1 - OH1) * OH1) * summ;
            }
        }

        public static void FindErrorAndCorrectWeightIL()
        {
            for (int i = 0; i < 11; i++)
            {
                for (int k = 0; k < 7; k++)
                {
                    neuronsLayerInputLearning[i].gradients[k] = neuronsLayerHiddenLearning1[k].delta *
                        neuronsLayerInputLearning[i].output;

                    neuronsLayerInputLearning[i].deltaW[k] = E * neuronsLayerInputLearning[i].gradients[k] +
                        A * neuronsLayerInputLearning[i].deltaW[k];

                    neuronsLayerInputLearning[i].weights[k] = neuronsLayerInputLearning[i].weights[k] +
                        neuronsLayerInputLearning[i].deltaW[k];
                }
            }
        }
        static int kkk = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            lEra.Text = Convert.ToString(era);
            mutexObj.WaitOne();
                lTrainingSet.Text = Convert.ToString(trainingSet + 1);
                lError.Text = Convert.ToString(errorGeneral);
                lTrueAnswer1.Text = Convert.ToString(sets[trainingSet].daysAnswer);
                lTrueAnswer2.Text = Convert.ToString(sets[trainingSet].pointAnswer);
                lTrueAnswer3.Text = Convert.ToString(sets[trainingSet].priceAnswer);
                    lAnswer1.Text = Convert.ToString((int)(1.0 /
                        neuronsLayerOutputLearning[0].output));
                    lAnswer2.Text = Convert.ToString((int)(1.0 /
                        neuronsLayerOutputLearning[1].output));
                    lAnswer3.Text = Convert.ToString((int)(1.0 /
                        neuronsLayerOutputLearning[2].output));
            mutexObj.ReleaseMutex();
        }

        private void bSaveLearn_Click(object sender, EventArgs e)
        {
            main.neuronsLayerInput = neuronsLayerInputLearning;
            main.neuronsLayerHidden1 = neuronsLayerHiddenLearning1;
            main.neuronsLayerHidden2 = neuronsLayerHiddenLearning2;
            main.neuronsLayerOutput = neuronsLayerOutputLearning;
        }

        private void LearningProcess_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t == null)
            {}
            else if (t.ThreadState != ThreadState.Suspended)
            {
                t.Abort();
                t.Join();
            }
            else if (t.ThreadState == ThreadState.Suspended)
            {
                t.Resume();
                t.Abort();
                t.Join();
            }
        }
    }
}
