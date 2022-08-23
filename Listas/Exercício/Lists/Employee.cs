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


        public  void increaseWage(double P)
        {
            double NewWage;

            NewWage = (_wage * (P / 100)) + _wage;
            _wage = NewWage;
            
        }
        public override string ToString()
        {
            return
                "Employee's name: " + Name +
                " " +
                "\nEmployee's Wage: " + _wage + "$" +
                " " +
                "\nEmployee's ID: " + ID +
                "\nNick Id: "+ NickID +
                "\n\n ";

        }

    }
}
