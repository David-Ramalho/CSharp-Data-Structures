﻿using System;
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
                sum += num[i];
            }

            return sum;
        }

        public static double Sub(params double[] num)
        {
            double sub=0;
            double total = 0;
            double Total = 0;
            

            for (int i=0; i<num.Length;i++)
            {
                if (i == 0)
                {
                    sub = num[i]-sub;
                    
                }
                else if (i == 1)
                {
                    sub = num[i] - sub;
                    sub = sub;

                    
                }
                else if (i == 2)
                {
                    sub = num[i] - sub;
                    
                }
                else if (i == 3)
                {
                    sub = num[i] - sub;

                }


            }
            return sub;

        }

    }
}
