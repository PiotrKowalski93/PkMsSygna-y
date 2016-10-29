using Sygnaly.Sygaly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sygnaly.SygnalyDyskretne
{
    class ImpulsJednostkowy : SygnalDyskretny
    {
        private double p = 0.5000000000000002;

        public ImpulsJednostkowy(double A, double t1, double d)
        {
            this.A = A;
            this.t1 = t1;
            this.d = d;

            for (int i = 0; i < y.Count; i++)
            {
                y[i] = Calculate(x[i]);
            }
        }

        private double Calculate(double x)
        {
            if (x == p)
            {
                return A;
            }
            return 0;
        }
    }
}
