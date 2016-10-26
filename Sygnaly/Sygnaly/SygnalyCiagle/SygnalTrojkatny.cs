using Sygnaly.Sygaly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sygnaly.SygnalyCiagle
{
    class SygnalTrojkatny : SygnalCiagly
    {
        private double k = 0.5;

        public SygnalTrojkatny(double A, double T, double t1, double d)
        {
            this.A = A;
            this.T = T;
            this.t1 = t1;
            this.d = d;

            for (int i = 0; i < y.Count; i++)
            {
                y[i] = Licz(x[i]);
            }
        }

        private double Licz(double x)
        {
            double p = x % T;
            double z = k * T;
            if (p <= z)
                return (A * p / z);
            else
                return (A * ((T - p) / (T - z)));
        }
    }
}
