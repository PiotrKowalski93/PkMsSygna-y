using Sygnaly.Sygaly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sygnaly.SygnalyCiagle
{
    class SkokJednostkowy : SygnalCiagly
    {
        public double ts = 5;

        public SkokJednostkowy(double A, double T, double t1, double d)
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
            if (x < ts)
                return 0;
            else
                return A;
        }
    }
}
