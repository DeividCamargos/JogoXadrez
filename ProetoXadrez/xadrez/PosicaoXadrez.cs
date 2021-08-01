using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public int Linha { get; private set; }
        public char Coluna { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Linha = linha;
            Coluna = coluna;
        }
        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, (int)Coluna - (int)'a');
        }
        public override string ToString()
        {
            return $"{Coluna}{Linha}";
        }
    }
}
