using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;
using Lists;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = -1;
            List<Employee> list = new List<Employee>();

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
                    Console.WriteLine("How many Employees will be registered?");
                    int num = int.Parse(Console.ReadLine());

                    for (int i = 0; i < num; i++)
                    {
                        int j = i + 1;
                        Console.Write("\nName "+ j+": ");
                        string name = Console.ReadLine();

                        Console.WriteLine("\nWage: ");                        
                        double wage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("\nNick ID: ");
                        int nickId = int.Parse(Console.ReadLine());

                        list.Add(new Employee(name, wage, nickId));

                    }
                    Console.Clear();
                    Console.WriteLine("                      ***Human resource Management***\n\n");
                    Console.WriteLine("Done!");
                    Console.ReadKey();
                }
                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("                      ***Human resource Management***\n\n");
                    Console.WriteLine("Employee's numbers: " + list.Count+ "\n");
                    foreach (Employee obj in list)
                    {
                        Console.WriteLine(obj);
                    }
                    
                    Console.ReadKey();
                }
                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("                      ***Human resource Management***\n\n");
                    Console.Write("Type the employee's NickID: ");
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