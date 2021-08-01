using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public Peca peca(Posicao posicao)
        {
            return pecas[posicao.Linha, posicao.Coluna];
        }
        public void AdicionarPeca(Peca novaPeca, Posicao pos)
        {
            if (!ExistePeca(pos))
                throw new TabuleiroError("Ja existe uma peça na posição selecionada!");

            pecas[pos.Linha, pos.Coluna] = novaPeca;
            novaPeca.Posicao = pos;
        }
        public Peca RemoverPeca(Posicao pos)
        {
            if (peca(pos) == null)
                return null;
            Peca p = peca(pos);
            pecas[pos.Linha, pos.Coluna] = null;
            p.Posicao = null;
            return p;
        }
        public bool PosicaoExiste(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha > linhas || pos.Coluna < 0 || pos.Coluna > colunas)
                return false;
            return true;
        }
        public void ValidarPosicaoExiste(Posicao pos)
        {
            if (!PosicaoExiste(pos))
                throw new TabuleiroError("Posicao não existe no tabuleiro!");
        }
        public bool ExistePeca (Posicao pos)
        {
            ValidarPosicaoExiste(pos);

            return pecas[pos.Linha, pos.Coluna] == null;
        }
    }
}
