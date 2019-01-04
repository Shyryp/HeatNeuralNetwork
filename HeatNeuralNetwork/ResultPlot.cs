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
    public partial class ResultPlot : Form
    {
        public ResultPlot(Plot plot, int aTemp)
        {
            InitializeComponent();
            lPlot.Text = plot.namePlot;
            lResultAT.Text = Convert.ToString(aTemp);
            lResultLength.Text = Convert.ToString(plot.pipelineLength);
            lResultDiameter.Text = Convert.ToString(plot.pipelineDiameter);
            lResultPressure.Text = Convert.ToString(plot.operatingPressure);
            lResultTemp.Text = Convert.ToString(plot.workingTemperature);
            lResultRTime.Text = Convert.ToString(plot.lifeCycle);
            lResultDays.Text = Convert.ToString(plot.numberDays);
            lResultCountNotWork.Text = Convert.ToString(plot.numberBreakdowns);
            lResultPointNotWork.Text = Convert.ToString(plot.placesBreakdowns);
            lResultPrice.Text = Convert.ToString(plot.price);
            lResultWorkFinish.Text = Convert.ToString(plot.daysAnswer);
            lResultPointNotWorkFinish.Text = Convert.ToString(plot.pointAnswer);
            lResultPriceFinish.Text = Convert.ToString(plot.priceAnswer);
            
        }
    }
}
