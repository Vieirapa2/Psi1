using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if2
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            bool isalmada = true;
            bool istudent = true;
            bool isalmada2 = false;
            bool istudent2 = false;
            //&& = and  || = or

            if (isalmada && istudent2) 
            {
                Console.WriteLine("Es um estudante de alamda");
            }else
            { Console.WriteLine("nao es estudante ou nao es de alamda");
            }Console.ReadLine(); 
            */
            bool isalmada = true;
            bool istudent = true;
            bool isalmada2 = false;
            bool istudent2 = false;
            //&& = and  || = or

            if (isalmada || istudent2)
            {
                Console.WriteLine("es estudante ou es de alamda ou ambos");
            }
            else
            {
                Console.WriteLine("nao es um estudante de alamda");
            }
            Console.ReadLine();
        }
    }
}
