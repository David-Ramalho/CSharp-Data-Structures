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
            int op = -1;
            Console.Clear();
            Console.WriteLine("                      ***Human resource Management***\n\n");
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("                      ***Human resource Management***\n\n");
                Console.WriteLine("Select the desired option:\n");
                
                Console.Write("1-Register employee\n2-Employee report\n3-Modify wage\n0-Sair\n\nType here: ");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("                      ***Human resource Management***\n\n");
                    Console.WriteLine("Registering");
                    Console.ReadKey();
                }
                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("                      ***Human resource Management***\n\n");
                    Console.WriteLine("Reporting");
                    Console.ReadKey();
                }
                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("                      ***Human resource Management***\n\n");
                    Console.WriteLine("Modifying");
                    Console.ReadKey();
                }
                else if (op == 0)
                {
                    Console.Clear();
                    Console.WriteLine("                      ***human resource Management***\n\n");
                    Console.WriteLine("exiting");                    
                    Console.ReadKey();

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("                      ***human resource Management***\n\n");
                    Console.WriteLine("Invalid option!Try again.");
                    Console.ReadKey();
                    // Thread.Sleep(3000);
                }

            }
            Console.ReadKey();
        }
    }
}