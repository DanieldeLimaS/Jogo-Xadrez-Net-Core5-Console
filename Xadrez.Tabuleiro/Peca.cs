using System;

namespace Xadrez.TabuleiroXadrez
{
    public abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }//pode ser acessa por ela mesma e a subclasse dela
        public int qtdMovimentos { get; protected set; }//pode ser acessa por ela mesma e a subclasse dela
        public Tabuleiro tabuleiro { get; protected set; }//pode ser acessa por ela mesma e a subclasse dela
        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }

        public void incrementarQtdMovimentos()
        {
            qtdMovimentos++;
        }
        public abstract bool[,] movimentosPossiveis();
       
    }
}
