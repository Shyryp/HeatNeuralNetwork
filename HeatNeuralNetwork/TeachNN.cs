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
            main.ambientTemperature = Convert.ToInt32(tBAmbientTemp.Text) + 100;

            sets[lBTeachPlots.SelectedIndex].pipelineLength =
            Convert.ToInt32(tBTeachPipelineLength.Text);

            sets[lBTeachPlots.SelectedIndex].pipelineDiameter =
            Convert.ToInt32(tBTeachPipelineDiameter.Text);

            sets[lBTeachPlots.SelectedIndex].operatingPressure =
            Convert.ToInt32(tBTeachOperatingPressure.Text);

            sets[lBTeachPlots.SelectedIndex].workingTemperature =
            Convert.ToInt32(tBTeachWorkingTemperature.Text);

            sets[lBTeachPlots.SelectedIndex].lifeCycle =
            Convert.ToInt32(tBTeachLifeCycle.Text);

            sets[lBTeachPlots.SelectedIndex].numberDays =
            Convert.ToInt32(tBTeachNumberDays.Text);

            sets[lBTeachPlots.SelectedIndex].numberBreakdowns =
            Convert.ToInt32(tBTeachNumberBreakdowns.Text);

            sets[lBTeachPlots.SelectedIndex].placesBreakdowns =
            Convert.ToInt32(tBTeachPlacesBreakdowns.Text);

            sets[lBTeachPlots.SelectedIndex].daysAnswer =
            Convert.ToInt32(tBDaysTrue.Text);

            sets[lBTeachPlots.SelectedIndex].pointAnswer =
            Convert.ToInt32(tBPointTrue.Text);

            sets[lBTeachPlots.SelectedIndex].priceAnswer =
            Convert.ToInt32(tBPriceTrue.Text);
            LearningProcess learningProcess = new LearningProcess(this, main);
            learningProcess.Show();
        }

        private void bInputTestTeachInfo_Click(object sender, EventArgs e)
        {
            Plot buffPlot;
            Random rand = new Random(Environment.TickCount);
            main.ambientTemperature = Convert.ToInt32(tBAmbientTemp.Text)+100;

            for (int i = 0; i < 9; i++)
            {
                buffPlot = new Plot();
                buffPlot.namePlot = "Тренировочный сет " + (i + 1);
                buffPlot.pipelineLength = rand.Next(1000) + 100;
                buffPlot.pipelineDiameter = rand.Next(100) + 1;
                buffPlot.operatingPressure = rand.Next(100) + 1;
                buffPlot.workingTemperature = rand.Next(100) + 1;
                buffPlot.numberDays = rand.Next(80) + 1;
                buffPlot.lifeCycle = rand.Next(buffPlot.numberDays,200) + 20;
                buffPlot.numberBreakdowns = rand.Next(10) + 1;
                buffPlot.placesBreakdowns = rand.Next(buffPlot.pipelineLength - 1) + 1;
                buffPlot.price = rand.Next(500) + 1;
                //Верные Ответы сгенерированные через формулы
                buffPlot.daysAnswer = (int)(rand.Next((buffPlot.lifeCycle-buffPlot.numberDays) - ((buffPlot.lifeCycle - buffPlot.numberDays) / 10),
                    (buffPlot.lifeCycle - buffPlot.numberDays) + ((buffPlot.lifeCycle - buffPlot.numberDays) / 10)) - (1.0/main.ambientTemperature)*10);
                if (buffPlot.daysAnswer <= 0)
                {
                    buffPlot.daysAnswer = 1;
                }

                buffPlot.pointAnswer = (int)(rand.Next(buffPlot.placesBreakdowns - (buffPlot.placesBreakdowns / 10),
                    buffPlot.placesBreakdowns + (buffPlot.placesBreakdowns / 10)) + (1.0 / buffPlot.operatingPressure) * 100
                    + (1.0 / buffPlot.workingTemperature) * 100);
                if (buffPlot.pointAnswer >= buffPlot.placesBreakdowns)
                {
                    buffPlot.pointAnswer = buffPlot.pointAnswer - ((buffPlot.pointAnswer - buffPlot.placesBreakdowns)+1);
                }
                if (buffPlot.pointAnswer <= 0)
                {
                    buffPlot.pointAnswer = 1;
                }

                buffPlot.priceAnswer = (int)(rand.Next(buffPlot.price-(buffPlot.price/10), 
                    buffPlot.price + (buffPlot.price / 10)) + buffPlot.numberBreakdowns*5);

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

        private void bSave_Click(object sender, EventArgs e)
        {
            main.ambientTemperature = Convert.ToInt32(tBAmbientTemp.Text) + 100;

            sets[lBTeachPlots.SelectedIndex].pipelineLength =
            Convert.ToInt32(tBTeachPipelineLength.Text);

            sets[lBTeachPlots.SelectedIndex].pipelineDiameter =
            Convert.ToInt32(tBTeachPipelineDiameter.Text);

            sets[lBTeachPlots.SelectedIndex].operatingPressure =
            Convert.ToInt32(tBTeachOperatingPressure.Text);

            sets[lBTeachPlots.SelectedIndex].workingTemperature =
            Convert.ToInt32(tBTeachWorkingTemperature.Text);

            sets[lBTeachPlots.SelectedIndex].lifeCycle =
            Convert.ToInt32(tBTeachLifeCycle.Text);

            sets[lBTeachPlots.SelectedIndex].numberDays =
            Convert.ToInt32(tBTeachNumberDays.Text);

            sets[lBTeachPlots.SelectedIndex].numberBreakdowns =
            Convert.ToInt32(tBTeachNumberBreakdowns.Text);

            sets[lBTeachPlots.SelectedIndex].placesBreakdowns =
            Convert.ToInt32(tBTeachPlacesBreakdowns.Text);

            sets[lBTeachPlots.SelectedIndex].daysAnswer =
            Convert.ToInt32(tBDaysTrue.Text);

            sets[lBTeachPlots.SelectedIndex].pointAnswer =
            Convert.ToInt32(tBPointTrue.Text);

            sets[lBTeachPlots.SelectedIndex].priceAnswer =
            Convert.ToInt32(tBPriceTrue.Text);
        }
    }
}
