// Screen Sound
using ConsoleApp1;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //ExibirMensagemBoasVindas();
        //ExibirOpocoesDoMenu();
        Jogo.Game();
    }
    static void ExibirMensagemBoasVindas()
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

    static void ExibirOpocoesDoMenu()
    {
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
            case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida); 
                break;
            case 2:
                Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
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
            default: Console.WriteLine("Opção Inválida.");
                break;

        }
    }
}