using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    internal class Album : IAvaliavel
    {
        private List<Musica> musicas = new List<Musica>();
        private List<Avaliacao> notas = new List<Avaliacao>();

        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);
        public List<Musica> Musicas => musicas;

        public double Media
        {
            get
            {
                if (notas.Count == 0) return 0;
                else return notas.Average(a => a.Nota);
            }
        }

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

        public void AdicionarNota(Avaliacao nota)
        {
            notas.Add(nota);
        }

        public static int ContadorDeObjetos = 0;

        public Album()
        {
            ContadorDeObjetos++;
        }
    }
}
