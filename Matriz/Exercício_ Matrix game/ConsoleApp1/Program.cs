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
            int j = 0;
            Console.WriteLine("                   ***Welcome to the Matrix game! Let's change reality!***\n\n");
            Console.WriteLine("Type the M for lines:");
            int m=int.Parse(Console.ReadLine());
            Console.WriteLine("Type the N for columns:");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Creating matrix...");
            Thread.Sleep(2000);

            int[,] mat=new int[m,n];
            Console.Clear();
            Console.WriteLine("\nNow you will add the values for each line and columns! Just type " + m + " for lines and" + n + "for columns");
            
            for(int i= 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(" ");
                for( j=0;j<n; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }
            Console.Clear();
            Console.WriteLine("Done! Loading matrix:");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("                   ***Welcome to the Matrix game! Let's change reality!***\n\n");
            Console.WriteLine("Matrix:\n");
            for (int i= 0; i < m; i++)
            {                
                for (j=0; j<n; j++)
                {
                    Console.Write(" "+ mat[i, j]);
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("\nNow choose a matrix number: ");
            int num=int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (num == mat[i, j])
                    {
                        Console.WriteLine("\nPosition:\nLine "+ i+"\nColumn: "+j);
                        Console.WriteLine("\nLeft: "+ mat[i, j-1]);
                        Console.WriteLine("\nRight: " + mat[i, j +1]);
                        Console.WriteLine("\nTop: " + mat[i-1, j ]);
                        Console.WriteLine("\nBottom: " + mat[i + 1, j]);

                    }
                }
            }
            Console.ReadKey();



        }
    }
}
