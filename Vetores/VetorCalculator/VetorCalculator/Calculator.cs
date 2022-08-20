using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorCalculator
{
    internal class Calculator
    {

        public static double add(params double[] num)
        {
           double sum = 0;

            for(int i=0; i < num.Length; i++)
            {
                sum+=num[i];
            }

            return sum;
        }

    }
}
