using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pesquisa regional: Média de alturas da população.");
            Console.WriteLine("");
            Console.WriteLine("Quantas Pessoas serão Cadastradas para a pesquisa?");
            int n = int.Parse(Console.ReadLine());

            //Declaração de vetor
            double[] VetMedia = new double[n];
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                int j = 1; j= i+j;

                Console.Clear();
                Console.WriteLine("Qual a média da altura da pessoa número: " +j);
                VetMedia[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sum += VetMedia[i];
            }

            Console.Clear();
            Console.WriteLine("A média da altura da população local é: " +
                (sum / n).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
