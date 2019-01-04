using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatNeuralNetwork
{
    public class Neuron
    {
        public List<double> weights = new List<double>();
        public List<double> gradients = new List<double>();
        public double input = 0;
        public double output = 0;
        public double delta = 0;

    }
}
