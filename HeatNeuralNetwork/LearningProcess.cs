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
        static public double A = 0.4;
        static public double E = 0.3;
        static public int era = 0;
        static public int trainingSet = 0;
        static public double errorGeneral = 0;
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
                for (int k = 0; k < 6; k++)
                    buffw.Add(rand.Next(10)-10 + rand.NextDouble());
                neuron.weights.AddRange(buffw);
                neuronsLayerInputLearning.Add(neuron);
            }
            for (int i = 0; i < 7; i++)
            {
                neuron = new Neuron();
                List<double> buffw = new List<double>();
                for (int k = 0; k < 4; k++)
                    buffw.Add(rand.Next(10) - 10 + rand.NextDouble());
                neuron.weights.AddRange(buffw);
                neuronsLayerHiddenLearning1.Add(neuron);
            }
            for (int i = 0; i < 5; i++)
            {
                neuron = new Neuron();
                List<double> buffw = new List<double>();
                for (int k = 0; k < 3; k++)
                    buffw.Add(rand.Next(10) - 10 + rand.NextDouble());
                neuron.weights.AddRange(buffw);
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
            t.Suspend();
            bSaveLearn.Enabled = true;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (t == null)
            {
                t = new Thread(new ThreadStart(Learn));
                t.Start();
                bStart.Text = "Возобновить";
                bStop.Enabled = true;
                bSaveLearn.Enabled = false;
            }
            else if (t != null)
            {
                t.Resume();
                bSaveLearn.Enabled = false;
            }
        }

        public static void Learn()
        {
            InitNN();
            while (true)
            {
                if (trainingSet == 9)
                {
                    trainingSet = 0;
                    era++;
                }
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
                FindErrorAndCorrectWeightHL2();
                FindErrorAndCorrectWeightHL1();
                FindErrorAndCorrectWeightIL();
                trainingSet++;
            }
        }

        public static void InitNN()
        {

        }

        public static void InitTrainingSet()
        {

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
            neuronsLayerInputLearning[9].output = 1;

        }
        public static void ILToHL1()
        {

        }
        public static void HL1ToHL2()
        {

        }
        public static void HL2ToOL()
        {

        }

        public static void FindErrorOutput()
        {

        }

        public static void FindErrorAndCorrectWeightHL2()
        {

        }

        public static void FindErrorAndCorrectWeightHL1()
        {

        }

        public static void FindErrorAndCorrectWeightIL()
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lEra.Text = Convert.ToString(era);
            lTrainingSet.Text = Convert.ToString(trainingSet+1);
            lError.Text = Convert.ToString(errorGeneral);
            lTrueAnswer1.Text = Convert.ToString(sets[trainingSet].daysAnswer);
            lTrueAnswer2.Text = Convert.ToString(sets[trainingSet].pointAnswer);
            lTrueAnswer3.Text = Convert.ToString(sets[trainingSet].priceAnswer);

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
