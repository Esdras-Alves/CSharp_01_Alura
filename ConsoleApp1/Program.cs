// Screen Sound
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

internal class Program
{
    //static List<string> listaDasBandas = new List<string>();

    static Dictionary<string, Banda> bandasRegistradas = new Dictionary<string, Banda>();
    static Banda ira = new Banda("Ira!");
    static Banda beatles = new Banda("The Beatles");
    static Musica exemploo = new Musica(ira, "musica1");


    private static void Main(string[] args)
    {
        bandasRegistradas.Add(ira.Nome, ira);
        ira.AdicionarNota(10);
        ira.AdicionarNota(8);
        ira.AdicionarNota(10);

        bandasRegistradas.Add(beatles.Nome, beatles);


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

        Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
    }

    static void ExibirOpcoesDoMenu()
    {
        ExibirLogo();
        Console.WriteLine("\nDigite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para resgistrar o álbum de uma banda");
        Console.WriteLine("Digite 3 para mostrar todas as bandas");
        Console.WriteLine("Digite 4 para avaliar uma banda");
        Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
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
                RegistrarAlbum();
                break;
            case 3:
                MostrarBandasRegistradas();
                break;
            case 4:
                AvaliarUmaBanda();
                break;
            case 5:
                ExibirDetalhes();
                break;
            case -1:
                Console.WriteLine("Tchau tchau :)");
                break;
            default:
                Console.WriteLine("Opção inválida");
                Thread.Sleep(1000);
                Console.Clear();
                ExibirOpcoesDoMenu();
                break;
        }
    }

    static void RegistrarAlbum()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine();
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine();
            Banda banda = bandasRegistradas[nomeDaBanda];
            banda.AdicionarAlbum(new Album(tituloAlbum));
            Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }

    static void RegistrarBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine();
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    static void MostrarBandasRegistradas()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        //for (int i = 0; i<listaDasBandas.Count; i++)
        //{
        //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
        //}

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
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
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            int nota = int.Parse(Console.ReadLine());
            banda.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}.");
            Thread.Sleep(2000);
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

    static void ExibirDetalhes()
    {
        Console.Clear();
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
            ExibirOpcoesDoMenu();

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }
}