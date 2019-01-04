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
    public partial class InputInformation : Form
    {
        MainWindow main;
        public InputInformation(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
            lBPlots.SelectedIndex = 0;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            
            main.plots[lBPlots.SelectedIndex].pipelineLength =
            Convert.ToInt32(tBPipelineLength.Text);

            main.plots[lBPlots.SelectedIndex].pipelineDiameter = 
            Convert.ToInt32(tBPipelineDiameter.Text);

            main.plots[lBPlots.SelectedIndex].operatingPressure = 
            Convert.ToInt32(tBOperatingPressure.Text);

            main.plots[lBPlots.SelectedIndex].workingTemperature =
            Convert.ToInt32(tBWorkingTemperature.Text);

            main.plots[lBPlots.SelectedIndex].lifeCycle = 
            Convert.ToInt32(tBLifeCycle.Text);

            main.plots[lBPlots.SelectedIndex].numberDays =
            Convert.ToInt32(tBNumberDays.Text);

            main.plots[lBPlots.SelectedIndex].numberBreakdowns =
            Convert.ToInt32(tBNumberBreakdowns.Text);

            main.plots[lBPlots.SelectedIndex].placesBreakdowns = 
            Convert.ToInt32(tBPlacesBreakdowns.Text);

            main.plots[lBPlots.SelectedIndex].price = 
            Convert.ToInt32(tBPrice.Text);
        }

        private void bInputTestInfo_Click(object sender, EventArgs e)
        {
            Plot buffPlot;
            Random rand = new Random();
            for (int i = 0; i < 9; i++)
            {
                buffPlot = new Plot();
                buffPlot.namePlot = "Участок " + (i+1);
                buffPlot.pipelineLength = rand.Next(1000)+100;
                buffPlot.pipelineDiameter = rand.Next(100) + 1;
                buffPlot.operatingPressure = rand.Next(100) + 1;
                buffPlot.workingTemperature = rand.Next(100) + 1;
                buffPlot.lifeCycle = rand.Next(100) + 2;
                buffPlot.numberDays = rand.Next(buffPlot.lifeCycle-1) + 1;
                buffPlot.numberBreakdowns = rand.Next(10) + 1;
                buffPlot.placesBreakdowns = rand.Next(buffPlot.pipelineLength-1) + 1;
                buffPlot.price = rand.Next(10000) + 1;
                buffPlot.daysAnswer = 0;
                buffPlot.pointAnswer = 0;
                buffPlot.priceAnswer = 0;
                main.plots[i] = buffPlot;
            }
            lPlot.Text = main.plots[lBPlots.SelectedIndex].namePlot;
            tBPipelineLength.Text= Convert.ToString(
            main.plots[lBPlots.SelectedIndex].pipelineLength);
            tBPipelineDiameter.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].pipelineDiameter);
            tBOperatingPressure.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].operatingPressure);
            tBWorkingTemperature.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].workingTemperature);
            tBLifeCycle.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].lifeCycle);
            tBNumberDays.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].numberDays);
            tBNumberBreakdowns.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].numberBreakdowns);
            tBPlacesBreakdowns.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].placesBreakdowns);
            tBPrice.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].price);
        }

        private void lBPlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            lPlot.Text = main.plots[lBPlots.SelectedIndex].namePlot;
            tBPipelineLength.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].pipelineLength);
            tBPipelineDiameter.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].pipelineDiameter);
            tBOperatingPressure.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].operatingPressure);
            tBWorkingTemperature.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].workingTemperature);
            tBLifeCycle.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].lifeCycle);
            tBNumberDays.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].numberDays);
            tBNumberBreakdowns.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].numberBreakdowns);
            tBPlacesBreakdowns.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].placesBreakdowns);
            tBPrice.Text = Convert.ToString(
            main.plots[lBPlots.SelectedIndex].price);
        }
    }
}
