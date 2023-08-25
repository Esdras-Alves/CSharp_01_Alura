using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    internal class Album
    {
        private List<Musica> musicas = new List<Musica>();

        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);
        public List<Musica> Musicas => musicas;

        public Album(string nome)
        {
            Nome = nome;
        }
        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Música: {musica.Nome} ({musica.Duracao})");
            }
        }

        public static int ContadorDeObjetos = 0;

        public Album()
        {
            ContadorDeObjetos++;
        }
    }
}
