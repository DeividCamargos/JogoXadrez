using System;
using tabuleiro;
namespace ProetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro Tabuleiro = new Tabuleiro(8, 8);
            Tela.ImprimirTabuleiro(Tabuleiro);
        }
    }
}
