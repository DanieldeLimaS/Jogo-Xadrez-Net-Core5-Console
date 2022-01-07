using Xadrez.TabuleiroXadrez;

namespace Xadrez.Pecas
{
    public class Dama : Peca
    {
        public Dama(TabuleiroXadrez.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override bool[,] movimentosPossiveis()
        {
            return null;
        }

        public override string ToString()
        {
            return "D";
        }
    }
}
