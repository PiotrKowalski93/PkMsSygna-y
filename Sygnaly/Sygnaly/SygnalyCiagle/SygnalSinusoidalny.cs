﻿using Sygnaly.Sygaly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sygnaly.SygnalyCiagle
{
    class SygnalSinusoidalny : SygnalCiagly
    {
        public SygnalSinusoidalny(double A, double T, double t1, double d)
        {
            this.A = A;
            this.T = T;
            this.t1 = t1;
            this.d = d;
            
            for (int i = 0; i < y.Count; i++)
            {
                y[i] = Licz(x[i], A);
            }
        }

        private double Licz(double x, double y)
        {
            double z = 2 * Math.PI / T * x;
            return y * Math.Sin(z);
        }
    }
}
