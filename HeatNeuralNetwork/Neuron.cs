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
        public List<double> deltaW = new List<double>();
        public double input = 0;
        public double output = 0;
        public double delta = 0;

        public void Sigmoid()
        {
            output = 1.0 / (1 + Math.Exp(-input));
            //output = input;
            //output = 1.0 / input;
        }
        public void Sigmoid(int intp)
        {
            output = 1.0 / (1 + Math.Exp(-intp));
            //output = intp;
            //output = 1.0 / intp;
        }
    }
}
