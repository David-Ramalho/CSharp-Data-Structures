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
            Console.WriteLine("                      [" + list.Count + "]");
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("                      ***Human resource Management***");
                Console.WriteLine("Employees: [" + list.Count + "]\n\n");
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
                        Console.Write("\nName " + j + ": ");
                        string name = Console.ReadLine();

                        Console.WriteLine("\nWage: ");
                        double wage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("\nNick ID: ");
                        int nickId = int.Parse(Console.ReadLine());


                        int x = Employee.NickIDControl(nickId, list);
                        if (x == 0)
                        {
                            list.Add(new Employee(name, wage, nickId));
                            Console.Clear();
                            Console.WriteLine("                      ***Human resource Management***\n\n");
                            Console.WriteLine("Done!");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("                      ***Human resource Management***\n\n");
                            Console.WriteLine("Inválid Nick ID.\nreturn -1 ");
                            Console.ReadKey();
                            break;
                        }
                        

                        

                    }
                    Console.Clear();                   
                    Console.ReadKey();
                }
                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("                      ***Human resource Management***\n\n");
                    Console.WriteLine("Employee's numbers: " + list.Count + "\n");
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
                    int nick = int.Parse(Console.ReadLine());
                    Employee emp = list.Find(x => x.NickID == nick);
                    if (emp != null)
                    {
                        Console.Write("Enter the percentage: ");
                        double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        double oldWage = emp.GetWage();
                        emp.increaseWage(p);
                        double Newwage = emp.GetWage();

                        Console.Clear();
                        Console.WriteLine("Done");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Old wage: " + oldWage + " New wage: " + Newwage + " A raise of " + p + "%");
                        Console.WriteLine("\n\nUpdated list of employee:\n\n");
                        Console.WriteLine(emp);


                    }
                    else
                    {
                        Console.WriteLine("\nNo employees with that Nick ID");
                        Console.ReadKey();
                    }

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