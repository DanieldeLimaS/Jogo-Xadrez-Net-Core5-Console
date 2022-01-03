using Xadrez.Tabuleiro;

namespace Xadrez.Pecas
{
    public class Dama : Peca
    {
        public Dama(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }
        public override string ToString()
        {
            return "D";
        }
    }
}
