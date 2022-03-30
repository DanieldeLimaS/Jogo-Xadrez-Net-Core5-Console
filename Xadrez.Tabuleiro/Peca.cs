using System;

namespace Xadrez.TabuleiroXadrez
{
    public abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }//pode ser acessa por ela mesma e a subclasse dela
        public int qtdMovimentos { get; protected set; }//pode ser acessa por ela mesma e a subclasse dela
        public Tabuleiro tab { get; protected set; }//pode ser acessa por ela mesma e a subclasse dela
        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null;
            this.tab = tabuleiro;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }

        public void incrementarQtdMovimentos()
        {
            qtdMovimentos++;
        }
        public abstract bool[,] movimentosPossiveis();
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j]) return true;
                }

            }
            return false;
        }
       
    }
}
