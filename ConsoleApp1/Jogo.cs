using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Jogo
    {
        public static void Game()
        {
            var random = new Random();
            int numeroSecreto = random.Next(1, 101);

            do
            {
                Console.WriteLine("Digite um número entre 1 e 100.");
                int chute = int.Parse(Console.ReadLine());

                if (numeroSecreto == chute)
                {
                    Console.WriteLine("\nParabéns, você acertou o número secreto!\n");
                    break;
                }
                else if (chute < numeroSecreto)
                {
                    Console.WriteLine("\nO número é maior.\n");
                }
                else
                {
                    Console.WriteLine("\nO número é menor.\n");
                }
            } while (true);
        }
    }
}
