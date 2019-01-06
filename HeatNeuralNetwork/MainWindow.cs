using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeatNeuralNetwork
{
    public partial class MainWindow : Form
    {
        public List<Plot> plots = new List<Plot>();
        public List<Neuron> neuronsLayerInput = new List<Neuron>();
        public List<Neuron> neuronsLayerHidden1 = new List<Neuron>();
        public List<Neuron> neuronsLayerHidden2 = new List<Neuron>();
        public List<Neuron> neuronsLayerOutput = new List<Neuron>();
        public int countPlot = 0;


        public int ambientTemperature = 0;
        public MainWindow()
        {
            InitializeComponent();
            Plot plot;
            for (int i = 0; i < 9; i++)
            {
                plot = new Plot();
                plots.Add(plot);
            }
            Neuron neuron;
            for (int i = 0; i < 11; i++)
            {
                neuron = new Neuron();
                neuronsLayerInput.Add(neuron);
            }
            for (int i = 0; i < 7; i++)
            {
                neuron = new Neuron();
                neuronsLayerHidden1.Add(neuron);
            }
            for (int i = 0; i < 5; i++)
            {
                neuron = new Neuron();
                neuronsLayerHidden2.Add(neuron);
            }
            for (int i = 0; i < 3; i++)
            {
                neuron = new Neuron();
                neuronsLayerOutput.Add(neuron);
            }

        }

        private void teachNNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachNN teach = new TeachNN(this);

            teach.Show();
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputInformation inputInfo = new InputInformation(this);
            
            inputInfo.Show();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //прогон в нейронной сети участков
            Learn();
            //ниже включаем все кнопки
            bPlot1.Enabled = true;
            bPlot2.Enabled = true;
            bPlot3.Enabled = true;
            bPlot4.Enabled = true;
            bPlot5.Enabled = true;
            bPlot6.Enabled = true;
            bPlot7.Enabled = true;
            bPlot8.Enabled = true;
            bPlot9.Enabled = true;
        }
        public void Learn()
        {
            while (true)
            {
                //Инициализация нейронов (обнуление переменных)
                InitNN();
                //Ввод данных
                InputDataInNN();
                //Пропускаем информацию через нейронную сеть
                ILToHL1();
                HL1ToHL2();
                //След функция вырабатывает ответ
                HL2ToOL();
                plots[countPlot].daysAnswer =(int) (1.0/neuronsLayerOutput[0].output);
                plots[countPlot].pointAnswer = (int)(1.0 / neuronsLayerOutput[1].output);
                plots[countPlot].priceAnswer = (int)(1.0 / neuronsLayerOutput[2].output);
                //Thread.Sleep(40);
                if (countPlot >= 8)
                {
                    countPlot = 0;
                    break;
                }
                countPlot++;
            }
        }
        public void InitNN()
        {
            for (int i = 0; i < 11; i++)
            {
                neuronsLayerInput[i].input = 0;
                neuronsLayerInput[i].output = 0;
                neuronsLayerInput[i].delta = 0;
            }
            for (int i = 0; i < 7; i++)
            {
                neuronsLayerHidden1[i].input = 0;
                neuronsLayerHidden1[i].output = 0;
                neuronsLayerHidden1[i].delta = 0;
            }
            for (int i = 0; i < 5; i++)
            {
                neuronsLayerHidden2[i].input = 0;
                neuronsLayerHidden2[i].output = 0;
                neuronsLayerHidden2[i].delta = 0;
            }
            for (int i = 0; i < 3; i++)
            {
                neuronsLayerOutput[i].input = 0;
                neuronsLayerOutput[i].output = 0;
                neuronsLayerOutput[i].delta = 0;
            }
        }

        public void InputDataInNN()
        {

            neuronsLayerInput[0].Sigmoid(plots[countPlot].pipelineLength);
            neuronsLayerInput[1].Sigmoid(plots[countPlot].pipelineDiameter);
            neuronsLayerInput[2].Sigmoid(plots[countPlot].operatingPressure);
            neuronsLayerInput[3].Sigmoid(plots[countPlot].workingTemperature);
            neuronsLayerInput[4].Sigmoid(plots[countPlot].lifeCycle);
            neuronsLayerInput[5].Sigmoid(plots[countPlot].numberDays);
            neuronsLayerInput[6].Sigmoid(plots[countPlot].numberBreakdowns);
            neuronsLayerInput[7].Sigmoid(plots[countPlot].placesBreakdowns);
            neuronsLayerInput[8].Sigmoid(plots[countPlot].price);
            neuronsLayerInput[9].Sigmoid(ambientTemperature);
            neuronsLayerInput[10].output = 1;

        }
        public void ILToHL1()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 11; j++)
                    neuronsLayerHidden1[i].input =
                        neuronsLayerHidden1[i].input +
                        neuronsLayerInput[j].output *
                        neuronsLayerInput[j].weights[i];

                neuronsLayerHidden1[i].Sigmoid();
            }
            neuronsLayerHidden1[6].output = 1;
        }
        public void HL1ToHL2()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                    neuronsLayerHidden2[i].input =
                        neuronsLayerHidden2[i].input +
                        neuronsLayerHidden1[j].output *
                        neuronsLayerHidden1[j].weights[i];

                neuronsLayerHidden2[i].Sigmoid();
            }
            neuronsLayerHidden2[4].output = 1;
        }
        public void HL2ToOL()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                    neuronsLayerOutput[i].input =
                        neuronsLayerOutput[i].input +
                        neuronsLayerHidden2[j].output *
                        neuronsLayerHidden2[j].weights[i];

                neuronsLayerOutput[i].Sigmoid();
            }
        }

        private void bPlot1_Click(object sender, EventArgs e)
        {
            ResultPlot plotInfo1 = new ResultPlot(plots[0], ambientTemperature);

            plotInfo1.Show();
        }

        private void bPlot2_Click(object sender, EventArgs e)
        {
            ResultPlot plotInfo2 = new ResultPlot(plots[1], ambientTemperature);

            plotInfo2.Show();
        }

        private void bPlot3_Click(object sender, EventArgs e)
        {
            ResultPlot plotInfo3 = new ResultPlot(plots[2], ambientTemperature);

            plotInfo3.Show();
        }

        private void bPlot4_Click(object sender, EventArgs e)
        {
            ResultPlot plotInfo4 = new ResultPlot(plots[3], ambientTemperature);

            plotInfo4.Show();
        }

        private void bPlot5_Click(object sender, EventArgs e)
        {
            ResultPlot plotInfo5 = new ResultPlot(plots[4], ambientTemperature);

            plotInfo5.Show();
        }

        private void bPlot6_Click(object sender, EventArgs e)
        {
            ResultPlot plotInfo6 = new ResultPlot(plots[5], ambientTemperature);

            plotInfo6.Show();
        }

        private void bPlot7_Click(object sender, EventArgs e)
        {
            ResultPlot plotInfo7 = new ResultPlot(plots[6], ambientTemperature);

            plotInfo7.Show();
        }

        private void bPlot8_Click(object sender, EventArgs e)
        {
            ResultPlot plotInfo8 = new ResultPlot(plots[7], ambientTemperature);

            plotInfo8.Show();
        }

        private void bPlot9_Click(object sender, EventArgs e)
        {
            ResultPlot plotInfo9 = new ResultPlot(plots[8], ambientTemperature);

            plotInfo9.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }
    }
}
