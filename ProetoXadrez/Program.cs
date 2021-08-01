using System;
using tabuleiro;
using xadrez;
namespace ProetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.ImprimirTabuleiro(tab);
        }   
    }
}
