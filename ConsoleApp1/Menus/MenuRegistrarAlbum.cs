﻿using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Menus
{
    internal class MenuRegistrarAlbum : Menu
    {
        internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
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
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
