using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_2doParcial
{
    public static class GenerarRandom
    {
        public static int EnteroAleatorio(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public static double DoubleAleatorio(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }
    }
}
