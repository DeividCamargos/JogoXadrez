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
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);

                    Console.Write("\nPosicao de origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();

                    Console.Clear();
                    bool[,] aux = partida.tab.peca(origem).movimentosPossiveis();
                    Tela.ImprimirTabuleiro(partida.tab, aux);
                    
                    Console.Write("\nPosicao de destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();

                    partida.ExecutarMovimento(origem, destino);
                }
            }
            catch (TabuleiroError e)
            {
                Console.WriteLine($"TabuleiroError! {e.Message}");
            }
        }
    }
}
