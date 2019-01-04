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
    public partial class LearningProcess : Form
    {
        TeachNN teach;
        int ambientTemperature = 0;
        public LearningProcess(TeachNN teach, int ambientTemperature)
        {
            InitializeComponent();
            this.teach = teach;
            this.ambientTemperature = ambientTemperature;
        }

        private void bStop_Click(object sender, EventArgs e)
        {

        }

        private void bStart_Click(object sender, EventArgs e)
        {

        }
    }
}
