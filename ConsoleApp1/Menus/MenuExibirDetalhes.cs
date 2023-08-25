using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menus
{
    internal class MenuExibirDetalhes : Menu
    {
        internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Exibir detalhes da banda");
            Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
            string nomeDaBanda = Console.ReadLine();
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                string nome;
                if (banda.Albuns.Count == 1) nome = "album";
                else nome = "albuns";
                Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.\n");
                Console.WriteLine($"A banda {nomeDaBanda} possui {banda.Albuns.Count} {nome}.\n");
                banda.ExibirDiscografia();
                Console.WriteLine("\nDigite uma tecla para votar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
