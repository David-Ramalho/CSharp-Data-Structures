using System;
using VetorCalculator;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = -1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("         ***Welcome to the calculator master!***\n");
                Console.WriteLine("Escolha a operação abaixo:\n\n1-addition\n2-subtraction\n3-multiplication\n4-division\n0-exit ");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("         ***Welcome to the calculator master!***\n");
                    Console.WriteLine("Plus");
                    Calculator.add (10,20);
                    Console.ReadKey();
                }
                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("         ***Welcome to the calculator master!***\n");
                    Console.WriteLine("Sub");
                    Console.ReadKey();
                }
                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("         ***Welcome to the calculator master!***\n");
                    Console.WriteLine("Times");
                    Console.ReadKey();
                }
                else if (op == 4)
                {
                    Console.Clear();
                    Console.WriteLine("         ***Welcome to the calculator master!***\n");
                    Console.WriteLine("By");
                    Console.ReadKey();
                }
                else if (op == 0)
                {
                    Console.Clear();
                    Console.WriteLine("         ***Good day!***\n");
                    Console.WriteLine("Exting");
                    Console.ReadKey();
                }

                else { Console.WriteLine("Opção inválida"); }

            }
        }
    }
}

