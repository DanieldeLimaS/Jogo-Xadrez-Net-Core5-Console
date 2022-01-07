﻿using Xadrez.TabuleiroXadrez;

namespace Xadrez.Pecas
{
    public class Rei : Peca
    {
        public Rei(TabuleiroXadrez.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        public override bool[,] movimentosPossiveis()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
