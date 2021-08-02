using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;
namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }
        public override string ToString()
        {
            return "T";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = Tabuleiro.peca(pos);

            return p == null || p.Cor != Cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] aux = new bool[Tabuleiro.linhas, Tabuleiro.colunas];
            Posicao pos = new Posicao(0, 0);
            /* for(int i = 0; i < Posicao.Linha; i++)
            {
                for (int c = 0; c < Posicao.Coluna; c++)
                {
                    //vertical
                    if (Tabuleiro.PosicaoExiste(Posicao) && podeMover(Posicao) && Posicao.Coluna == c)
                        aux[i, c] = true;

                    //horizontal
                    if (Tabuleiro.PosicaoExiste(Posicao) && podeMover(Posicao) && Posicao.Linha == i)
                        aux[i, c] = true;

                }
            }*/
            //acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoExiste(pos) && podeMover(pos))
            {
                aux[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor)
                    break;
                pos.Linha--;
            }

            //abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoExiste(pos) && podeMover(pos))
            {
                aux[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor)
                    break;
                pos.Linha++;
            }

            //direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoExiste(pos) && podeMover(pos))
            {
                aux[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor)
                    break;
                pos.Coluna++;
            }

            //esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoExiste(pos) && podeMover(pos))
            {
                aux[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.peca(pos) != null && Tabuleiro.peca(pos).Cor != Cor)
                    break;
                pos.Coluna--;
            }
            return aux;
        }
    }
}
