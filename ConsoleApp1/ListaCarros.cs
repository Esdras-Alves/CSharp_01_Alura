using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ListaCarros
    {
        static Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>>
        {
            { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
            { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
            { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
            { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
            { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
        };

        public static void MediaCarros()
        {
            Console.WriteLine("Digite o nome do carro: ");
            string carro = Console.ReadLine();

            if (vendasCarros.ContainsKey(carro))
            {
                double media = vendasCarros[carro].Average();
                Console.WriteLine($"\nMédia de vendas do {carro}: {media}\n");
            } else
            {
                Console.WriteLine("Carro não encontrado");
            }

        }
    }
}
