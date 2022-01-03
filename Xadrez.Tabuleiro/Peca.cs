namespace Xadrez.Tabuleiro
{
     public class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }//pode ser acessa por ela mesma e a subclasse dela

        public int qtdMovimentos { get; protected set; }//pode ser acessa por ela mesma e a subclasse dela
        public Tabuleiro tabuleiro { get; protected set; }//pode ser acessa por ela mesma e a subclasse dela

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = posicao;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }


    }
}
