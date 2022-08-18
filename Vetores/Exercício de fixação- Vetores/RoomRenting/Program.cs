using RoomRenting;
using System;
using System.Globalization;



namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -1;
            Room[] quarto = new Room[10];
            Console.Clear();

            while (i != 0)
            {
                Console.Clear();
                Console.WriteLine("  *** Bem vindo a pensão da Dona Joana ***");
                Console.WriteLine(" ");
                Console.WriteLine("\nEscolha alguma opção abaixo:");
                Console.WriteLine("1-Alugar quarto\n2-Relatório da pensão\n0-sair");
                i = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    Console.Clear();
                    Console.WriteLine("  *** Bem vindo a pensão da Dona Joana ***");
                    Console.WriteLine("Alugando");

                    Console.WriteLine("Quantos Quartos seram alugados?");
                    int n = int.Parse(Console.ReadLine());

                    for (int j = 0; j < n; j++)
                    {
                        Console.Clear();
                        Console.WriteLine("Qual quarto desejas alugar? 0-9");
                        int Qn = int.Parse(Console.ReadLine());
                        if (Qn > 10)
                        {
                            Console.WriteLine("´Temos apenas 10 quartos! números de 0 a 9!");
                            j = n; //to make sure to exit loop if the user tries to exceed the array range.
                        }
                        else
                        {
                            if (quarto[Qn] == null)
                            {
                                Console.Clear();
                                Console.WriteLine("  *** Bem vindo a pensão da Dona Joana ***");
                                Console.WriteLine("\nQuarto disponivel!! Preencha as informações\n");

                                Console.WriteLine("Nome: ");
                                string nome = Console.ReadLine();
                                Console.WriteLine("Email ");
                                string email = Console.ReadLine();

                                //quarto[Qn] = new Room {Nome=nome, Email=email, NumQuarto = Qn };
                                quarto[Qn] = new Room(nome, email, Qn);
                                Console.WriteLine("Quarto alugado!");

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("  *** Bem vindo a pensão da Dona Joana ***");
                                Console.WriteLine("Quarto não disponivel! ");
                            }
                        }

                    }

                    Console.ReadKey();
                }
                else if (i == 2)
                {
                    Console.Clear();
                    Console.WriteLine("  *** Bem vindo a pensão da Dona Joana ***");
                    Console.WriteLine("\nRelatório de alugados:\n");
                    for (i = 0; i < 10; i++)
                    {
                        if (quarto[i] != null)
                        {
                            quarto[i].RelatorioGeral();                            
                        }
                        else if(quarto[i] == null)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Quarto "+ i+"° desocupado");
                            
                        }
                    }

                    Console.ReadKey();
                }
                else if (i == 0)
                {
                    Console.Clear();
                    Console.WriteLine("  *** Volte Sempre ***");
                    Console.WriteLine("Exting");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida!");
                    Console.ReadKey();
                }
            }
        }
    }
}
