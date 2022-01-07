using Xadrez.TabuleiroXadrez;

namespace Xadrez.Pecas
{
    public class Peao : Peca
    {
        public Peao(TabuleiroXadrez.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override bool[,] movimentosPossiveis()
        {
            return null;
        }

        public override string ToString()
        {
            return "P";
        }
    }
}
