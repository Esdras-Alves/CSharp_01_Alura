// Screen Sound
using ScreenSound.Modelos;
using ScreenSound.Menus;
using System;
using System.Collections.Generic;
using System.Threading;

internal class Program
{
    static Dictionary<string, Banda> bandasRegistradas = new Dictionary<string, Banda>();
    static Dictionary<int, Menu> opcoes = new Dictionary<int, Menu>();

    private static void Main(string[] args)
    {
        opcoes.Add(1, new MenuRegistrarBanda());
        opcoes.Add(2, new MenuRegistrarAlbum());
        opcoes.Add(3, new MenuMostrarBandas());
        opcoes.Add(4, new MenuAvaliarBanda());
        opcoes.Add(5, new MenuAvaliarAlbum());
        opcoes.Add(6, new MenuExibirDetalhes());
        opcoes.Add(-1, new MenuSair());

        ExibirOpcoesDoMenu();
    }
    static void ExibirLogo()
    {
        Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

        Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
    }
    static void ExibirOpcoesDoMenu()
    {
        ExibirLogo();
        Console.WriteLine("\nDigite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para resgistrar o álbum de uma banda");
        Console.WriteLine("Digite 3 para mostrar todas as bandas");
        Console.WriteLine("Digite 4 para avaliar uma banda");
        Console.WriteLine("Digite 5 para avaliar um álbum");
        Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
        Console.WriteLine("Digite -1 para sair ");

        Console.WriteLine("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine();
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
        if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
        {
            Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
            menuASerExibido.Executar(bandasRegistradas);
            if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine("Opção inválida");
            Thread.Sleep(1000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }
}
