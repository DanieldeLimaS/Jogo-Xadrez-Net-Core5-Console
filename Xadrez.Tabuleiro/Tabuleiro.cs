﻿namespace Xadrez.Tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; 
        
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = this.linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
    }
}
