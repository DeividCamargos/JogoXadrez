using tabuleiro;
using System;
using xadrez;
namespace ProetoXadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                System.Console.Write($"{8 - i} ");
                for (int c = 0; c < tab.colunas; c++)
                {
                    ImprimirPeca(tab.peca(i, c));

                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("  a b c d e f g h");
        }
        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] movimentosPossiveis)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                System.Console.Write($"{8 - i} ");
                for (int c = 0; c < tab.colunas; c++)
                {
                    if (movimentosPossiveis[i, c])
                        Console.BackgroundColor = ConsoleColor.Blue;
                    ImprimirPeca(tab.peca(i, c));
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("  a b c d e f g h");
        }
        public static void ImprimirPeca(Peca peca)
        {
            if (peca == null)
                System.Console.Write("- ");
            else
            {
                if (peca.Cor == Cor.Preta)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca + " ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1].ToString());
            return new PosicaoXadrez(coluna, linha);
        }

    }
}