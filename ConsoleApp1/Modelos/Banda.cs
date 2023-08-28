using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    internal class Banda : IAvaliavel
    {
        private List<Album> albuns = new List<Album>();
        private List<Avaliacao> notas = new List<Avaliacao>();
        public IEnumerable<Album> Albuns => albuns;

        public string Nome { get; }
        public double Media
        {
            get
            {
                if(notas.Count == 0) return 0;
                else return notas.Average(a => a.Nota);
            }
        }
        public string Resumo { get; set; }

        public Banda(string nome)
        {
            Nome = nome;
        }

        public void AdicionarAlbum(Album album)
        {
            albuns.Add(album);
        }

        public void AdicionarNota(Avaliacao nota)
        {
            notas.Add(nota);
        }

        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda {Nome}\n");
            foreach (Album album in albuns)
            {
                Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
            }
        }
    }
}
