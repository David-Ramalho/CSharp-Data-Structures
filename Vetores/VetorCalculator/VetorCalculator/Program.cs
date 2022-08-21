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
                    // I know the logic looks a little bit confusing, but it's working and I will improve it overtime. Remember, it's good for practice and I learned I lot in doing so!
                    int i = 0;
                    double num = -1;
                    double num2 = 0;
                    double Num = 0;
                    double total = 0;
                    Console.Clear();
                    Console.WriteLine("         ***Welcome to the calculator master!***\n");
                    Console.WriteLine("Type number to sum. if 0 is typed, then it's final");
                    while (num != 0 || num2 != 0)
                    {

                        Console.WriteLine("\nDigite o número " + i);
                        num = double.Parse(Console.ReadLine());
                        //  Num = Num +Calculator.add(num, num2);
                        i++;
                        if (num == 0)
                        {
                            // Num = Num + Calculator.add(num, num2);
                            Console.WriteLine("A soma é: " + total);
                            break;
                        }
                        else
                        {
                            Num = +Calculator.add(num, total);
                            total = Num;

                        }
                        Console.WriteLine("\nDigite o número " + i);
                        num2 = double.Parse(Console.ReadLine());
                        //Num = Num + Calculator.add(num, num2);
                        i++;
                        if (num2 == 0)
                        {
                            //Num = Num + Calculator.add(num, num2);
                            Console.WriteLine("A soma é: " + total);
                            break;
                        }
                        else
                        {
                            Num = Calculator.add(total, num2);
                            total = Num;
                        }




                        //Console.WriteLine(Num);

                    }

                    Console.ReadKey();
                }
                else if (op == 2)
                {
                    // I know the logic looks a little bit confusing, but it's working and I will improve it overtime. Remember, it's good for practice and I learned I lot in doing so!
                    int i = 0;
                    double num = -1;
                    double num2 = 0;
                    double Num = 0;
                    double total = 0;
                    Console.Clear();
                    Console.WriteLine("         ***Welcome to the calculator master!***\n");
                    Console.WriteLine("Type number to sub. if 0 is typed, then it's final");
                    while (num != 0 || num2 != 0)
                    {

                        Console.WriteLine("\nDigite o número " + i);
                        num = double.Parse(Console.ReadLine());
                        if (num == 0)
                        {
                            Console.WriteLine("A sub é: " + total);
                            break;

                        }
                        else
                        {
                            if (i == 0)
                            {
                                Num = Calculator.Sub(num, total);
                                total = Num;
                                i++;
                            }
                            else
                            {
                                Num = Calculator.Sub(total, num);
                                total = Num;

                            }
                        }
                        Console.WriteLine("\nDigite o número " + i);
                        num2 = double.Parse(Console.ReadLine());
                        i++;
                        if (num2 == 0)
                        {
                            Console.WriteLine("A sub é: " + total);
                            break;
                        }
                        else
                        {
                            Num = Calculator.Sub(total, num2);
                            total = Num;


                        }

                    }
                    Console.ReadKey();
                }
                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("         ***Welcome to the calculator master!***\n");
                    Console.WriteLine("Type number to Mult. if 0 is typed, then it's final");
                    Console.WriteLine("Times");
                    double num = 1, num2 = 1;
                    double total = 1;
                    int i = 0;
                    while (num != 0 || num2 != 0)
                    {

                        Console.WriteLine("\nDigite o número " + i);
                        num = double.Parse(Console.ReadLine());
                        if (num == 0)
                        {
                            Console.WriteLine("A mult é: " + total);
                            break;

                        }
                        else
                        {
                            total = Calculator.Times(total, num);
                            i++;
                        }
                        Console.WriteLine("\nDigite o número " + i);
                        num2 = double.Parse(Console.ReadLine());
                        i++;
                        if (num2 == 0)
                        {
                            Console.WriteLine("A mult é: " + total);
                            break;
                        }
                        else
                        {
                            total = Calculator.Times(total, num2);

                        }

                    }


                    Console.ReadKey();
                }
                else if (op == 4)
                {
                    Console.Clear();
                    Console.WriteLine("         ***Welcome to the calculator master!***\n");
                    Console.WriteLine("Type number to Mult. if 0 is typed, then it's final");
                    double num = 1;
                    int i = 0;
                    double[] nums= new double[i];
                    

                    while (num != 0)
                    {
                        Console.WriteLine("Digte o número: ");
                        num = double.Parse(Console.ReadLine());
                        nums[i] = num;
                        i++;

                    }
                    num = Calculator.By(nums);

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

