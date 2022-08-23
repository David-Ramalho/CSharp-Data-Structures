using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j = 0;
            int k = 0;

            Console.WriteLine("Digite o tamanho da Matriz quadrada: ");
            i = int.Parse(Console.ReadLine());
            int[,] Mat = new int[i, i];


            for (j = 0; j < i; j++)
            {

                string[] values = Console.ReadLine().Split(" ");

                for (k = 0; k < i; k++)
                {
                    Mat[j, k] = int.Parse(values[k]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int h = 0; h < i; h++)
            {
                Console.Write(Mat[h, h] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (j = 0; j < i; j++)
            {
                for (k = 0; k < i; k++)
                {
                    if (Mat[j,k] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers : "+count);
        }
    }
}
