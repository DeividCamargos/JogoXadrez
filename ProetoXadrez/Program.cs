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

                    Console.WriteLine("\nPosicao de origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().ToPosicao();

                    Console.WriteLine("Posicao de destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().ToPosicao();

                    partida.ExecutarMovimento(origem, destino);

                    Tela.ImprimirTabuleiro(partida.tab);
                }
            }
            catch (TabuleiroError e)
            {
                Console.WriteLine($"TabuleiroError! {e.Message}");
            }
        }   
    }
}
