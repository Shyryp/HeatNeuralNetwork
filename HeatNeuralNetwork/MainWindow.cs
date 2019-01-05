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
            for (int i = 0; i < 10; i++)
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
            Console.WriteLine(neuronsLayerInput[0].delta);
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

        private void resetAllToolStripMenuItem2_Click(object sender, EventArgs e)
        {

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
