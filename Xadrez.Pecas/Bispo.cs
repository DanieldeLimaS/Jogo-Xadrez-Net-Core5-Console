using Xadrez.TabuleiroXadrez;

namespace Xadrez.Pecas
{
    public class Bispo : Peca
    {
        public Bispo(TabuleiroXadrez.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }
        public override string ToString()
        {
            return "B";
        }
    }
}
