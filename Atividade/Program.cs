using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array");

            string[] nomes = new string[5];
            int[] idades = new int[5];

            for (var contador = 0; contador < 5; contador++)
            {
                Console.WriteLine($"Digite o nome do {contador+1} nome");
                nomes[contador] = Console.ReadLine();
                Console.WriteLine("Digite a idade");
                idades[contador] = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("Nomes Cdastrados: ");

            for (var contador = 0; contador < 5; contador++)
            {
                Console.Write("nome: "+nomes[contador]);
                Console.WriteLine(" idade: "+idades[contador]);
            }
        }
    }
}
