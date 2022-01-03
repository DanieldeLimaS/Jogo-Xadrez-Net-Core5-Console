using Xadrez.Tabuleiro;

namespace Xadrez.Pecas
{
    public class Cavalo : Peca
    {
        public Cavalo(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }
        public override string ToString()
        {
            return "C";
        }
    }
}
