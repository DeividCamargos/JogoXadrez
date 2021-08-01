using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;
namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }
        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            colocarPecas();
            terminada = false;
        }
        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.RemoverPeca(origem);
            p.IncrementarQuantidadeDeMovimentos();
            Peca pecaCapturada = tab.RemoverPeca(destino);
            tab.AdicionarPeca(p, destino);
        }
        private void colocarPecas()
        {
            tab.AdicionarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 8).ToPosicao());
            tab.AdicionarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('h', 8).ToPosicao());
            tab.AdicionarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('a', 8).ToPosicao());
            tab.AdicionarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('b', 3).ToPosicao());
            tab.AdicionarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('e', 5).ToPosicao());
        }
    }
}
