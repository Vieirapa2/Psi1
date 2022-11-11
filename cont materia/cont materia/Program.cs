using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cont_materia
{
    internal class Program
    {
        static void Main(string[] args)
        { //jogo benfica();
            Jogobenfica("bruge", 2);
            Jogobenfica("liverpool", 3);
            Jogobenfica("Real madrid", 4);
            Console.ReadLine();
        }
        /*static void Jogobenfica()
         * {
         * console.WriteLine("o benfica vai jogar contra o brugger);
         * }*/
        static void Jogobenfica(string equipa, int pontos)
        {
            Console.WriteLine("o benfica vai jogar contra o " + equipa + "e tem " + pontos + " de avanço");

        }
    }
}

    

