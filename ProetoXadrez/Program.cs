using System;
using tabuleiro;
using xadrez;
namespace ProetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro Tabuleiro = new Tabuleiro(8, 8);


            Tabuleiro.AdicionarPeca(new Torre(Tabuleiro, Cor.Preta), new Posicao(0, 0));
            Tabuleiro.AdicionarPeca(new Torre(Tabuleiro, Cor.Preta), new Posicao(1, 3));
            Tabuleiro.AdicionarPeca(new Rei(Tabuleiro, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(Tabuleiro);
        }   
    }
}
