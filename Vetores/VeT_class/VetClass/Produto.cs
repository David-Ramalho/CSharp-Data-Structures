using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClass
{
    internal class Produto
    {
        public double Price { get; private set; }
        public string Name { get; private set; }
        public int Cod { get; private set; }


        public Produto(String name, double price)
        {
            Name = name;
            Price = price;
            Random numAleatorio = new Random();
            Cod = numAleatorio.Next();

        }


    }
}
