using Xadrez.TabuleiroXadrez;

namespace Xadrez.Pecas
{
    public class Torre : Peca
    {
        public Torre(TabuleiroXadrez.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }
        public override string ToString()
        {
            return "T";
        }
    }
}
