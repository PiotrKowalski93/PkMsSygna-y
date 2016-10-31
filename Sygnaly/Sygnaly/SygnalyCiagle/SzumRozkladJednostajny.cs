using Sygnaly.Sygaly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sygnaly.SygnalyCiagle
{
    class SzumRozkladJednostajny : SygnalCiagly
    {
        private Random random = new Random();

        SzumRozkladJednostajny(double A, double t1, double d)
        {
            this.A = A;
            this.t1 = t1;
            this.d = d;
            
            for(int i = 0; i <= y.Count; i++)
            {
                y[i] = random.NextDouble() * A;
            }
        }

    }
}
