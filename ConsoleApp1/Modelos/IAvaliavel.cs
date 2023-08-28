using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    internal interface IAvaliavel
    {
        void AdicionarNota(Avaliacao nota);
        double Media { get; }
    }
}
