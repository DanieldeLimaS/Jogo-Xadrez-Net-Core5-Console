using Xadrez.Exceptions;

namespace Xadrez.TabuleiroXadrez
{
    public class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        /// <summary>
        /// esse é o construtor da classe principal
        /// </summary>
        /// <param name="linhas">representa o numero de linhas do tabuleiro</param>
        /// <param name="colunas">representa o numero de colunas do tabuleiro</param>
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        /// <summary>
        /// esse método representa a peça do tabuleiro
        /// </summary>
        /// <param name="linha">representa o numero da linha da peça no tabuleiro</param>
        /// <param name="coluna">representa o numero da coluna da peça no tabuleiro</param>
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public Peca peca(Posicao posicao)
        {
            return pecas[posicao.linha, posicao.coluna];
        }
        /// <summary>
        /// Método criado para colocar a peça no tabuleiro
        /// </summary>
        /// <param name="peca">representa a peça do tabuleiro</param>
        /// <param name="posicao">representa a posição da peça no tabuleiro</param>
        public void colocarPeca(Peca peca, Posicao posicao)
        {
            if (existePeca(posicao))
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            pecas[posicao.linha, posicao.coluna] = peca;
            peca.posicao = posicao;
        }
        /// <summary>
        /// Método criado para retirar a peça do tabuleiro na posição informada e retorna a peça
        /// </summary>
        /// <param name="posicao">representa a posição da peça no tabuleiro</param>
        public Peca retirarPeca(Posicao posicao)
        {
            if (peca(posicao) is null)
                return null;
            Peca pecaaux = peca(posicao);
            pecaaux.posicao = null;
            pecas[posicao.linha, posicao.coluna] = null;
            return pecaaux;
        }

        /// <summary>
        /// valida se a peça existe e retorna um boleano
        /// </summary>
        /// <param name="posicao">representa a posição da peça no tabuleiro</param>
        public bool existePeca(Posicao posicao)
        {
            validarPosicao(posicao);
            return peca(posicao) != null;
        }

        /// <summary>
        /// valida se a posição informada existe no tabuleiro e retorna um boleano
        /// </summary>
        /// <param name="posicao">representa a posição da peça no tabuleiro</param>
        public bool posicaoValida(Posicao posicao)
        {
            if (posicao.linha < 0 || posicao.coluna < 0 || posicao.linha >= linhas || posicao.coluna >= colunas)
                return false;
            return true;
        }

        /// <summary>
        /// valida se a posição existe no tabuleiro e retorna uma excessão caso seja inválida
        /// </summary>
        /// <param name="posicao">representa a posição da peça no tabuleiro</param>
        public void validarPosicao(Posicao posicao)
        {
            if (!posicaoValida(posicao))
                throw new TabuleiroException("Posição inválida!");
        }
    }
}
