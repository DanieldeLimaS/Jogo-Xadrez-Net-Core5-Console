using System;
using Xadrez.Tabuleiro;

namespace Jogo_Xadrez_NetCore5
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao posicao = new Posicao(3, 4);
            Console.WriteLine("Posição:" + posicao);
            Console.ReadLine();
        }
    }
}
