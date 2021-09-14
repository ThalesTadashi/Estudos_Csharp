using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula23
{
    class Class1
    {
        static void Main()
        {
            int num = 10;
            dobrar(num);
            Console.WriteLine(dobrar(num));
        }



        static int dobrar(int valor)
        {
            valor*=2;
            return valor;
        }

        static void dobrar1(ref int valor)
        {
            valor *= 2;
        }
    }
}
