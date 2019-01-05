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
        TeachNN teach;
        MainWindow main;
        Thread t;
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
            this.teach = teach;
            this.main = main;
            Neuron neuron;
            for (int i = 0; i < 10; i++)
            {
                neuron = new Neuron();
                neuronsLayerInputLearning.Add(neuron);
            }
            for (int i = 0; i < 7; i++)
            {
                neuron = new Neuron();
                neuronsLayerHiddenLearning1.Add(neuron);
            }
            for (int i = 0; i < 5; i++)
            {
                neuron = new Neuron();
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
            //test();
            int i = 0;
            while (true)
            {
                i++;
                Console.WriteLine("Potok "+i);
                Thread.Sleep(1000);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lEra.Text = Convert.ToString(era);
            lTrainingSet.Text = Convert.ToString(trainingSet+1);
            lError.Text = Convert.ToString(errorGeneral);
            lTrueAnswer1.Text = Convert.ToString(teach.sets[trainingSet].daysAnswer);
            lTrueAnswer2.Text = Convert.ToString(teach.sets[trainingSet].daysAnswer);
            lTrueAnswer3.Text = Convert.ToString(teach.sets[trainingSet].daysAnswer);

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
