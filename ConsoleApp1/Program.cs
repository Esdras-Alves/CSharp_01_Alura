// Screen Sound
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Threading;

internal class Program
{
    static List<string> listaDasBandas = new List<string>();

    private static void Main(string[] args)
    {
        ExibirOpcoesDoMenu();
        //Jogo.Game();
        //ListaPares();
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
        Console.WriteLine("Digite 3 para exibir a média de uma banda");
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
                Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
                break;
            case 4:
                Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
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
        Console.WriteLine("********************");
        Console.WriteLine("Registro de bandas");
        Console.WriteLine("********************");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine();
        listaDasBandas.Add(nomeDaBanda);

        Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    static void MostrarBandasRegistradas()
    {
        Console.Clear();
        Console.WriteLine("**************************************");
        Console.WriteLine("Exibindo todas as bandas registradas");
        Console.WriteLine("**************************************\n");

        //for (int i = 0; i<listaDasBandas.Count; i++)
        //{
        //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
        //}

        foreach (string banda in  listaDasBandas)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    static void ListaPares()
    {
        List<int> numbers = new List<int> {1, 2, 3, 4, 5, 6,7, 8, 9, 10};

        for(int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        foreach (int number in numbers)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}