using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sapatos("nike1", 103);
            sapatos("adidas", 90);
            sapatos("nikepanda", 120);
        }
        static void sapatos(string tipo, int custo)
        {
            Console.WriteLine("o teus tenis sao " + tipo + " e custam " + custo + " euros");
        }
    }
}
