using System;
using System.Text;
using System.Collections.Generic;

namespace UnitTesting
{
    class Mean
    {
        public static double arithmeticMean(params int[] list)
        {
            double sum = 0;
            for (int i = 0; i < list.Length; i++)
                sum += list[i];
            return sum / list.Length;
        }

        public static double geometricMean(params int[] list)
        {
            double mult = 1;
            for(int i = 0; i < list.Length; i++)
                mult *= list[i];
            double pow = 1.0 / list.Length;
            return Math.Pow(mult, pow);
        }

        public static double harmonicMean(params int[] list)
        {
            double sum = 0;
            for(int i = 0; i < list.Length; i++)
            {
                sum += (1.0 / list[i]);
            }
            return list.Length / sum;
        }
    }
}
