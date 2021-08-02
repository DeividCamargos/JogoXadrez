using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor )
        {
        } 
        public override string ToString()
        {
            return "R";
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

            //acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoExiste(pos) && podeMover(pos))
                aux[pos.Linha, pos.Coluna] = true;

            //noroeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna -1);
            if (Tabuleiro.PosicaoExiste(pos) && podeMover(pos))
                aux[pos.Linha, pos.Coluna] = true;

            //oeste
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoExiste(pos) && podeMover(pos))
                aux[pos.Linha, pos.Coluna] = true;

            //sudoeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoExiste(pos) && podeMover(pos))
                aux[pos.Linha, pos.Coluna] = true;

            //sul
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoExiste(pos) && podeMover(pos))
                aux[pos.Linha, pos.Coluna] = true;

            //sudeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoExiste(pos) && podeMover(pos))
                aux[pos.Linha, pos.Coluna] = true;
            
            //leste
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoExiste(pos) && podeMover(pos))
                aux[pos.Linha, pos.Coluna] = true;
            
            //nordeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoExiste(pos) && podeMover(pos))
                aux[pos.Linha, pos.Coluna] = true;

            return aux;
        }
    }
}
