using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idade
{
    internal class Program
    {
        static void Main(string[] args)
        {//perguntar a idade se o utilizador tiver menos de 18 diz nao permitido em vermeho e verde se tiver mais ou igual a 18






            Console.WriteLine("Digite a sua idade para entrar neste bar (relembrando que tens que ter mais de 18 anos)");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("É premitido o acesso ao bar");
              
            }
            else if (idade < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não é permitido o acesso ao bar sendo que tem menos de 18 anos");
             
            }



            
        }
    }
}
