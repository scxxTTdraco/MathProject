using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace NewProject
{
    class Calculate
    {
        static public double pi = 3.14;

        static public double Circ(double r)
        {
            return 2.0 * pi * r;
        }

        static public double Vol(double r)
        {
            return 4.0 / 3.0 * pi * r * r * r;
        }

        static public double ResSoma(double n1, double n2) {

            return n1 + n1;
        }

        static public double ResDivi(double n1, double n2)
        {
            if (n2 == 0)
            {
                return 0.0;
            }
            else
            {
                return n1 / n2;
            }
        }

        static public double ResSubtr(double n1, double n2)
        {
            return n1 - n2;
        }

        static public double ResMult(double n1, double n2)
        {
            return n1 * n2;
        }

    }
}
