using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Employee
    {
        public int ID { get; private set; }
        // Employee can changes names, however a constructor is better for those cases
        public string Name { get; private set; }

        private double _wage;
        public int NickID;

        // Constructor
        public Employee(string name, double wage, int nickId)
        {
            Name = name;
            _wage = wage;
            Random numAleatorio = new Random();
            ID = numAleatorio.Next();
            NickID = nickId;
        }

        public double GetWage()
        {
            return _wage;
        }

        public double SetWage()
        {
            return _wage;
        }


        public void increaseWage(double P)
        {
            double NewWage;

            NewWage = (_wage * (P / 100)) + _wage;
            _wage = NewWage;

        }

        public static int NickIDControl(int nickID, List<Employee> list)
        {
            string tam = nickID.ToString();

            foreach (Employee obj in list)
            {
                Employee nick = list.Find(x => x.NickID == nickID);
                if (nick != null)
                {
                    Console.Clear();
                    Console.WriteLine("Nick ID already used!");
                    return -1;
                }

            }
            if (tam.Length < 3)
            {
                Console.Clear();
                Console.WriteLine("Nick Id is too small! Minimum is 3 digits!");
                return -1;

            }

            else
            {
                Console.Clear();
                Console.WriteLine("Nick aproved!");
                Console.WriteLine("Registering employee");
                Thread.Sleep(3);
                return 0;
            }

        }
        public override string ToString()
        {
            return
                "Employee's name: " + Name +
                " " +
                "\nEmployee's Wage: " + _wage + "$" +
                " " +
                "\nEmployee's ID: " + ID +
                "\nNick Id: " + NickID +
                "\n\n ";

        }

    }
}
