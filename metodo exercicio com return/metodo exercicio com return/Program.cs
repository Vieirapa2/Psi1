using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_exercicio_com_return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dinheiro = notas(20);
            Console.WriteLine(dinheiro);
            Console.ReadLine();
        }
        static int notas(int quanto)
        {
            int result = quanto + quanto ;
            return result;
        }
    }
}
