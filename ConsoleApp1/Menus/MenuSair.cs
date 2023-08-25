using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Menus
{
    internal class MenuSair : Menu
    {
        internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.WriteLine("Tchau tchau :)");
        }
    }
}
