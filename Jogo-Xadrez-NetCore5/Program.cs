using System;
using Xadrez.Exceptions;
using Xadrez.Logica;
using Xadrez.Pecas;
using Xadrez.Tabuleiro;

namespace Jogo_Xadrez_NetCore5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region codigo comentado
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 7));
                tabuleiro.colocarPeca(new Cavalo(tabuleiro, Cor.Preta), new Posicao(0, 1));
                tabuleiro.colocarPeca(new Cavalo(tabuleiro, Cor.Preta), new Posicao(0, 6));
                tabuleiro.colocarPeca(new Bispo(tabuleiro, Cor.Preta), new Posicao(0, 2));
                tabuleiro.colocarPeca(new Bispo(tabuleiro, Cor.Preta), new Posicao(0, 5));
                tabuleiro.colocarPeca(new Dama(tabuleiro, Cor.Preta), new Posicao(0, 3));
                tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 4));
                tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Branca), new Posicao(7, 4));
                for (int i = 0; i < 8; i++)
                {
                    tabuleiro.colocarPeca(new Peao(tabuleiro, Cor.Preta), new Posicao(1, i));
                }
                Tela.imprimirTabuleiro(tabuleiro);
                #endregion
                PosicaoXadrez posicao = new PosicaoXadrez('A', 7);
                Console.WriteLine(posicao);
                Console.WriteLine(posicao.toPosicao());
                Console.ReadLine();
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
