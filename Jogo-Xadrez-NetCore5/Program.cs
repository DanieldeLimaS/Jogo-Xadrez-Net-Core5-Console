using System;
using Xadrez.Tabuleiro;

namespace Jogo_Xadrez_NetCore5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                Tela.imprimirTabuleiro(tabuleiro);

                Console.ReadLine();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
