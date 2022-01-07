using Xadrez.TabuleiroXadrez;

namespace Xadrez.Pecas
{
    public class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }

        /// <summary>
        /// Método que valida se a peça pode ser mover no tabuleiro
        /// </summary>
        /// <param name="posicao">representa a posição da peça</param>
        /// <returns>retorna um boleano informando se pode ou nao mover no tabuleiro</returns>
        private bool podeMover(Posicao posicao)
        {
            Peca peca = tabuleiro.peca(posicao);
            return peca == null || peca.cor != this.cor;

        }

        /// <summary>
        /// Médoto com todos os movimentos que essa peça pode fazer no tabuleiro
        /// </summary>
        /// <returns> retorna a matriz com os valores</returns>
        public override bool[,] movimentosPossiveis()
        {
            bool[,] matriz = new bool[tabuleiro.linhas, tabuleiro.colunas];
            Posicao posicao = new Posicao(0, 0);

            //movimento para cima
            posicao.definirValores(posicao.linha - 1, posicao.coluna);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                    break;
                posicao.linha = posicao.linha - 1;
            }
            //movimento para baixo
            posicao.definirValores(posicao.linha + 1, posicao.coluna);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                    break;
                posicao.linha = posicao.linha + 1;
            }

            //movimento para direita
            posicao.definirValores(posicao.linha , posicao.coluna+1);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                    break;
                posicao.linha = posicao.linha + 1;
            }


            //movimento para esquerda
            posicao.definirValores(posicao.linha, posicao.coluna - 1);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                matriz[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                    break;
                posicao.linha = posicao.linha - 1;
            }
            return matriz;
        }
    }
}
