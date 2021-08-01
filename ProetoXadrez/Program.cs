using System;
using tabuleiro;
using xadrez;
namespace ProetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro Tabuleiro = new Tabuleiro(8, 8);

                Tabuleiro.AdicionarPeca(new Torre(Tabuleiro, Cor.Preta), new Posicao(0,7));
                Tabuleiro.AdicionarPeca(new Torre(Tabuleiro, Cor.Preta), new Posicao(1, 6));
                Tabuleiro.AdicionarPeca(new Rei(Tabuleiro, Cor.Branca), new Posicao(2, 4));
                Tabuleiro.AdicionarPeca(new Rei(Tabuleiro, Cor.Branca), new Posicao(3, 5));
                Tabuleiro.AdicionarPeca(new Rei(Tabuleiro, Cor.Preta), new Posicao(6, 2));

                Tela.ImprimirTabuleiro(Tabuleiro);
            }
            catch (TabuleiroError e)
            {
                Console.WriteLine($"TabuleiroError! {e.Message}");
            }
        }   
    }
}
