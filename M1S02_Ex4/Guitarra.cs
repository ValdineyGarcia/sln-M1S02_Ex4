using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S02_Ex4
{
    static class Guitarra
    {
        public string Afinacao;
    }
    static Guitarra(string Afinacao)
    {
        Afinacao = "SOL";
    }
    private void TomAfinado()
    {
        Console.WriteLine($"A guitarra está com afinação em {afinacao}");
    }
}