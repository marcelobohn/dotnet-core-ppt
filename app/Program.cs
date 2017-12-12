using System;
using lib;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PPT ppt = new PPT("João", "Marcos");
            ppt.jogador1_material = "Papel";
            ppt.jogador2_material = "Pedra";
            System.Console.WriteLine(ppt.vencedor());
        }
    }
}
