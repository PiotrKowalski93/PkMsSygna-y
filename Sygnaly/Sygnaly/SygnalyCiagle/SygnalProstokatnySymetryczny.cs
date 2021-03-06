﻿using Sygnaly.Sygaly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sygnaly.SygnalyCiagle
{
    class SygnalProstokatnySymetryczny : SygnalCiagly
    {
        private double k = 0.5;

        public SygnalProstokatnySymetryczny(double A, double T, double t1, double d)
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
            if (p <= k * T)
            {
                return A;
            }
            else
            {
                return -A;
            }
        }
    }
}
