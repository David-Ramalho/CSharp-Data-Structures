using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using VetClass;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de produtos da Loja Ramalho & CIA");
            Console.WriteLine("");
            Console.WriteLine("Quantos Produtos serão cadastrados?");
            int n = int.Parse(Console.ReadLine());

            //Instanciação do vetor/classe
            Produto[] produto = new Produto[n];
            double sum = 0.0;


            for (int i = 0; i < n; i++)
            {
               int j = 1; j += i;
               
                Console.Clear();
                Console.WriteLine("Qual o nome do produto " +j +"?");
                string name = Console.ReadLine();
                Console.WriteLine("Qual o preço do produto: " + name);
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Instanciação dos objetos do vetor/classe
                produto[i] = new Produto(name, price);
                sum += produto[i].Price;
            }
            Console.Clear();                       
            Console.WriteLine("AVERAGE PRICE = " + (sum/n).ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}