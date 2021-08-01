using tabuleiro;
using System;
namespace ProetoXadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                System.Console.Write($"{8-i} ");
                for (int c = 0; c < tab.colunas; c++)
                {
                    if (tab.peca(i, c) == null)
                        System.Console.Write("- ");
                    else
                    {
                        ImprimirPeca(tab.peca(i, c));
                        System.Console.Write(" ");
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("  a b c d e f g h");
        }
        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
                Console.Write(peca);
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = ConsoleColor.Gray;

            }
        }
    }
}
