using Xadrez.TabuleiroXadrez;

namespace Xadrez.Pecas
{
    public class Rei : Peca
    {
        public Rei(TabuleiroXadrez.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }


        public override string ToString()
        {
            return "R";
        }

        /// <summary>
        /// Método que valida se a peça pode ser mover no tabuleiro
        /// </summary>
        /// <param name="posicao">representa a posição da peça</param>
        /// <returns>retorna um boleano informando se pode ou nao mover no tabuleiro</returns>
        private bool podeMover(Posicao posicao)
        {
            Peca peca = tab.peca(posicao);
            return peca == null || peca.cor != this.cor;

        }

        /// <summary>
        /// Médoto com todos os movimentos que essa peça pode fazer no tabuleiro
        /// </summary>
        /// <returns> retorna a matriz com os valores</returns>
        public override bool[,] movimentosPossiveis()
        {
            bool[,] matriz = new bool[tab.linhas, tab.colunas];
            Posicao posicao = new Posicao(0, 0);

            //movimento para cima
            posicao.definirValores(posicao.linha - 1, posicao.coluna);
            if (tab.posicaoValida(posicao) && podeMover(posicao))
                matriz[posicao.linha, posicao.coluna] = true;

            //movimento para nordeste
            posicao.definirValores(posicao.linha - 1, posicao.coluna + 1);
            if (tab.posicaoValida(posicao) && podeMover(posicao))
                matriz[posicao.linha, posicao.coluna] = true;
            //movimento para direita
            posicao.definirValores(posicao.linha, posicao.coluna + 1);
            if (tab.posicaoValida(posicao) && podeMover(posicao))
                matriz[posicao.linha, posicao.coluna] = true;

            //movimento para sudeste
            posicao.definirValores(posicao.linha + 1, posicao.coluna + 1);
            if (tab.posicaoValida(posicao) && podeMover(posicao))
                matriz[posicao.linha, posicao.coluna] = true;

            //movimento para baixo
            posicao.definirValores(posicao.linha + 1, posicao.coluna);
            if (tab.posicaoValida(posicao) && podeMover(posicao))
                matriz[posicao.linha, posicao.coluna] = true;

            //movimento para sudoeste
            posicao.definirValores(posicao.linha + 1, posicao.coluna - 1);
            if (tab.posicaoValida(posicao) && podeMover(posicao))
                matriz[posicao.linha, posicao.coluna] = true;

            //movimento para esquerda
            posicao.definirValores(posicao.linha, posicao.coluna - 1);
            if (tab.posicaoValida(posicao) && podeMover(posicao))
                matriz[posicao.linha, posicao.coluna] = true;

            //movimento para noroeste
            posicao.definirValores(posicao.linha - 1, posicao.coluna - 1);
            if (tab.posicaoValida(posicao) && podeMover(posicao))
                matriz[posicao.linha, posicao.coluna] = true;
            return matriz;
        }
    }
}
