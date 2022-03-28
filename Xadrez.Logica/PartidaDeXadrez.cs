using Xadrez.Pecas;
using Xadrez.TabuleiroXadrez;

namespace Xadrez.Logica
{
    public class PartidaDeXadrez
    {
        public Tabuleiro tabuleiro;
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }//somente para acesso de leitura
        /// <summary>
        /// Construtor da classe definindo ums parametros necessarios para ser carregados
        /// </summary>
        public PartidaDeXadrez()
        {
            tabuleiro = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }
        /// <summary>
        /// Realiza o movimento da peça no tabuleiro indo para da posição original para o seu destino informado
        /// </summary>
        /// <param name="origem"> representa a posição de origem da peça</param>
        /// <param name="destino"> representa a posiçao de destino da peça</param>
        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tabuleiro.retirarPeca(origem);
            p.incrementarQtdMovimentos();
            Peca pecaCapturada = tabuleiro.retirarPeca(destino);
            tabuleiro.colocarPeca(p, destino);
        }

        /// <summary>
        /// Colocando as peças iniciais no tabuleiro
        /// </summary>
        private void colocarPecas()
        {
            #region colocando peças brancas
            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Branca), new PosicaoXadrez('A', 1).toPosicao());
            //tabuleiro.colocarPeca(new Cavalo(tabuleiro, Cor.Branca), new PosicaoXadrez('B', 1).toPosicao());
            //tabuleiro.colocarPeca(new Bispo(tabuleiro, Cor.Branca), new PosicaoXadrez('C', 1).toPosicao());
            //tabuleiro.colocarPeca(new Dama(tabuleiro, Cor.Branca), new PosicaoXadrez('D', 1).toPosicao());
            tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Branca), new PosicaoXadrez('E', 1).toPosicao());
            //tabuleiro.colocarPeca(new Bispo(tabuleiro, Cor.Branca), new PosicaoXadrez('F', 1).toPosicao());
            //tabuleiro.colocarPeca(new Cavalo(tabuleiro, Cor.Branca), new PosicaoXadrez('G', 1).toPosicao());
            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Branca), new PosicaoXadrez('H', 1).toPosicao());


            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('A', 2).toPosicao());
            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('B', 2).toPosicao());
            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('C', 2).toPosicao());
            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('D', 2).toPosicao());
            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('E', 2).toPosicao());
            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('F', 2).toPosicao());
            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('G', 2).toPosicao());
            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Branca), new PosicaoXadrez('H', 2).toPosicao());
            #endregion

            #region colocando peças pretas
            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('A', 8).toPosicao());
            //tabuleiro.colocarPeca(new Cavalo(tabuleiro, Cor.Preta), new PosicaoXadrez('B', 8).toPosicao());
            //tabuleiro.colocarPeca(new Bispo(tabuleiro, Cor.Preta), new PosicaoXadrez('C', 8).toPosicao());
            //tabuleiro.colocarPeca(new Dama(tabuleiro, Cor.Preta), new PosicaoXadrez('D', 8).toPosicao());
            //tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new PosicaoXadrez('E', 8).toPosicao());
            //tabuleiro.colocarPeca(new Bispo(tabuleiro, Cor.Preta), new PosicaoXadrez('F', 8).toPosicao());
            //tabuleiro.colocarPeca(new Cavalo(tabuleiro, Cor.Preta), new PosicaoXadrez('G', 8).toPosicao());
            tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new PosicaoXadrez('H', 8).toPosicao());


            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('A', 7).toPosicao());
            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('B', 7).toPosicao());
            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('C', 7).toPosicao());
            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('D', 7).toPosicao());
            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('E', 7).toPosicao());
            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('F', 7).toPosicao());
            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('G', 7).toPosicao());
            //tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new PosicaoXadrez('H', 7).toPosicao());
            #endregion
        }
    }
}
