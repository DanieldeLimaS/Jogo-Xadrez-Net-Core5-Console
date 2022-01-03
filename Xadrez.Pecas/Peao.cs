using Xadrez.Tabuleiro;

namespace Xadrez.Pecas
{
    public class Peao : Peca
    {
        public Peao(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }
        public override string ToString()
        {
            return "P";
        }
    }
}
