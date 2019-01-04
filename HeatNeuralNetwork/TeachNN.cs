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
    public partial class TeachNN : Form
    {
        public List<Plot> sets = new List<Plot>();
        MainWindow main;
        public TeachNN(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
            Plot plot = new Plot();
            for (int i = 0; i < 9; i++)
            {
                plot = new Plot();
                plot.namePlot = "Тренировочный сет " + (i + 1);
                sets.Add(plot);
            }
            lBTeachPlots.SelectedIndex = 0;
        }

        private void bTeach_Click(object sender, EventArgs e)
        {
            LearningProcess learningProcess = new LearningProcess(this, main.ambientTemperature);
            learningProcess.Show();
        }

        private void bInputTestTeachInfo_Click(object sender, EventArgs e)
        {
            Plot buffPlot;
            Random rand = new Random();
            main.ambientTemperature = Convert.ToInt32(tBAmbientTemp.Text);

            for (int i = 0; i < 9; i++)
            {
                buffPlot = new Plot();
                buffPlot.namePlot = "Тренировочный сет " + (i + 1);
                buffPlot.pipelineLength = rand.Next(1000) + 100;
                buffPlot.pipelineDiameter = rand.Next(100) + 1;
                buffPlot.operatingPressure = rand.Next(100) + 1;
                buffPlot.workingTemperature = rand.Next(100) + 1;
                buffPlot.lifeCycle = rand.Next(100) + 2;
                buffPlot.numberDays = rand.Next(buffPlot.lifeCycle - 1) + 1;
                buffPlot.numberBreakdowns = rand.Next(10) + 1;
                buffPlot.placesBreakdowns = rand.Next(buffPlot.pipelineLength - 1) + 1;
                buffPlot.price = rand.Next(10000) + 1;
                //Верные Ответы сгенерированные через формулы
                buffPlot.daysAnswer =(int)( (buffPlot.lifeCycle*1.5- buffPlot.numberBreakdowns
                    + ((double)buffPlot.pipelineLength/ (double)buffPlot.pipelineDiameter))
                    -  buffPlot.numberDays - (1.0/ (double)(main.ambientTemperature+101))*25);

                buffPlot.pointAnswer = (int)(((double)(buffPlot.placesBreakdowns*buffPlot.numberBreakdowns)
                    + (double)buffPlot.pipelineLength/(((double)buffPlot.operatingPressure/2.0)+
                    ((double)buffPlot.workingTemperature/2.0)))/((double)buffPlot.numberBreakdowns+1.0));

                buffPlot.priceAnswer = (int)(((buffPlot.price * buffPlot.numberBreakdowns) +
                    buffPlot.price + (double)buffPlot.price / ((1.0 / (double) buffPlot.numberBreakdowns) * 10.0)) / 
                    (double)buffPlot.numberBreakdowns);

                sets[i] = buffPlot;
            }
            lSet.Text = sets[lBTeachPlots.SelectedIndex].namePlot;

            tBTeachPipelineLength.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].pipelineLength);

            tBTeachPipelineDiameter.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].pipelineDiameter);

            tBTeachOperatingPressure.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].operatingPressure);

            tBTeachWorkingTemperature.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].workingTemperature);

            tBTeachLifeCycle.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].lifeCycle);

            tBTeachNumberDays.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].numberDays);

            tBTeachNumberBreakdowns.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].numberBreakdowns);

            tBTeachPlacesBreakdowns.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].placesBreakdowns);

            tBTeachPrice.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].price);

            tBDaysTrue.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].daysAnswer);

            tBPointTrue.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].pointAnswer);

            tBPriceTrue.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].priceAnswer);
        }

        private void lBTeachPlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            lSet.Text = sets[lBTeachPlots.SelectedIndex].namePlot;

            tBTeachPipelineLength.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].pipelineLength);

            tBTeachPipelineDiameter.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].pipelineDiameter);

            tBTeachOperatingPressure.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].operatingPressure);

            tBTeachWorkingTemperature.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].workingTemperature);

            tBTeachLifeCycle.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].lifeCycle);

            tBTeachNumberDays.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].numberDays);

            tBTeachNumberBreakdowns.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].numberBreakdowns);

            tBTeachPlacesBreakdowns.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].placesBreakdowns);

            tBTeachPrice.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].price);

            tBDaysTrue.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].daysAnswer);

            tBPointTrue.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].pointAnswer);

            tBPriceTrue.Text = Convert.ToString(
            sets[lBTeachPlots.SelectedIndex].priceAnswer);
        }
    }
}
