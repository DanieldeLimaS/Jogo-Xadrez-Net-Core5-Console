using System;
using Xadrez.Tabuleiro;

namespace Jogo_Xadrez_NetCore5
{
    public class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                Console.Write(8 - i + "|");
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    if (tabuleiro.peca(i, j) == null)
                        Console.Write("- ");
                    else
                    {
                        imprimirPeca(tabuleiro.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
            Console.WriteLine("__________________");
        }
        public static void imprimirPeca(Peca peca)
        {
            
                ConsoleColor corConsole = Console.ForegroundColor;
                Console.ForegroundColor =(peca.cor == Cor.Preta)? ConsoleColor.Yellow: ConsoleColor.White;
                Console.Write(peca);
                Console.ForegroundColor = corConsole;

        }
    }
}
