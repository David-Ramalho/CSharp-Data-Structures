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

        private double Wage;

        // Constructor
        public Employee(string name, double wage)
        {
            Name = name;
            Wage = wage;
            Random numAleatorio = new Random();
            ID = numAleatorio.Next();
        }

        public static void increaseWage(double P, double wage, out double NewWage)
        {
            NewWage = (wage * (P / 100)) + wage;
        }
        public override string ToString()
        {
            return
                "Employee's name: " + Name +
                " " +
                "\nEmployee's Wage: " + Wage + "$" +
                " " +
                "\nEmployee's ID: " + ID +
                "\n\n ";

        }

    }
}
