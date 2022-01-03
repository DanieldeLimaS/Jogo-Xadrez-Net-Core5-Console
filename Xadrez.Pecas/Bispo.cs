using Xadrez.Tabuleiro;

namespace Xadrez.Pecas
{
    public class Bispo : Peca
    {
        public Bispo(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }
        public override string ToString()
        {
            return "B";
        }
    }
}
