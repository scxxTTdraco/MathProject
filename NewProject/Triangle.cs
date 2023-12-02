using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    class Triangle
    {

        public double A = 0.0;
        public double B = 0.0;
        public double C = 0.0;

        public double CalTriagle(double a, double b, double c){

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            }

    }
}
