using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sygnaly.Sygaly
{
    class Sygnal
    {
        // Wartosci Opisujace sygnal
        public double A = 1;       // <-- Amplituda
        public double T = 2;       // <-- Okres
        public double t1 = 0;      // <-- Czas Poczatkowy
        public double d = 10;      // <-- Czas Trwania
        public double kw;          // <-- Współczynnik wypełnienia (tylko dla prost. i trój.)
        public int n;              // <-- Ilość próbek sygnału.

        public List<double> y;
        public List<double> x;

        // Wartości obliczeniowe sygnału.
        public double srednia;
        public double sredniaBezwzgledna;
        public double sredniaMoc;
        public double wariancja;
        public double wartoscSkuteczna;

        public Sygnal()
        {
            n = 1000;
            x = new List<double>();
            y = new List<double>();

            double j = 0;

            for (int i = 0; i < x.Count; i++)
            {
                x.Add(j);
                j = j + (d / 1000);
            }
        }
    }
}
