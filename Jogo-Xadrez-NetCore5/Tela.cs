using System;
using Xadrez.Logica;
using Xadrez.TabuleiroXadrez;

namespace Jogo_Xadrez_NetCore5
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabuleiro)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("SEJA BEM-VINDO AO JOGO DE XADREZ");
            Console.WriteLine();
            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    imprimirPeca(tabuleiro.peca(i, j));
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
            Console.WriteLine("__________________");
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string ler = Console.ReadLine();
            char coluna = ler[0];
            int linha = int.Parse(ler[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca is null)
                Console.Write("- ");
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor corConsole = Console.ForegroundColor;
                    Console.ForegroundColor = (peca.cor == Cor.Branca) ? ConsoleColor.White : ConsoleColor.Black;
                    Console.Write(peca);
                    Console.ForegroundColor = corConsole;
                }
                Console.Write(" ");
            }
        }
    }
}
