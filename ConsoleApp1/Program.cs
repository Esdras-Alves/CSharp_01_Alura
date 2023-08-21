// Screen Sound
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

internal class Program
{
    //static List<string> listaDasBandas = new List<string>();

    static Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

    private static void Main(string[] args)
    {
        ExibirOpcoesDoMenu();
        //Jogo.Game();
        //ListaPares.lista();
        //ListaCarros.MediaCarros();
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
        string mensagemDeBoasVindas = "\nBoas vindas ao Screen Sound";
        Console.WriteLine(mensagemDeBoasVindas);
    }

    static void ExibirOpcoesDoMenu()
    {
        ExibirLogo();
        Console.WriteLine("Digite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para mostrar todas as bandas");
        Console.WriteLine("Digite 3 para avaliar uma banda");
        Console.WriteLine("Digite 4 para exibir a média de uma banda");
        Console.WriteLine("Digite -1 para sair ");

        Console.WriteLine("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine();
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                RegistrarBanda();
                break;
            case 2:
                MostrarBandasRegistradas();
                break;
            case 3:
                AvaliarUmaBanda();
                break;
            case 4:
                ExibirMedia();
                break;
            case -1:
                Console.WriteLine("Tchau tchau :)");
                break;
            default:
                Console.WriteLine("Opção Inválida.");
                break;

        }
    }

    static void RegistrarBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro de Bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine();
        bandasRegistradas.Add(nomeDaBanda, new List<int>());

        Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    static void MostrarBandasRegistradas()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

        //for (int i = 0; i<listaDasBandas.Count; i++)
        //{
        //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
        //}

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    static void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    static void AvaliarUmaBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine();
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
           Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            int nota = int.Parse(Console.ReadLine());
            bandasRegistradas[nomeDaBanda].Add(nota);
            Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}.");
            Thread.Sleep(4000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu.");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }

    static void ExibirMedia()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Média da banda");
        Console.Write("Digite o nome da banda que deseja exibir a média: ");
        string nomeDaBanda = Console.ReadLine();
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            double media = bandasRegistradas[nomeDaBanda].Average();
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é: {media}");
            Thread.Sleep(4000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu.");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }

    }
}