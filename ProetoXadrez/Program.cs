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

                Tabuleiro.AdicionarPeca(new Torre(Tabuleiro, Cor.Preta), new Posicao(0, 0));
                Tabuleiro.AdicionarPeca(new Torre(Tabuleiro, Cor.Preta), new Posicao(00, 0));
                Tabuleiro.AdicionarPeca(new Rei(Tabuleiro, Cor.Preta), new Posicao(2, 4));

                Tela.ImprimirTabuleiro(Tabuleiro);
            }
            catch(TabuleiroError e)
            {
                Console.WriteLine($"TabuleiroError! {e.Message}");
            }
        }   
    }
}
