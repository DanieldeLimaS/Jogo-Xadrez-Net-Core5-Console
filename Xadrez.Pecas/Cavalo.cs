using Xadrez.TabuleiroXadrez;

namespace Xadrez.Pecas
{
    public class Cavalo : Peca
    {
        public Cavalo(TabuleiroXadrez.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }
        public override string ToString()
        {
            return "C";
        }
    }
}
