using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula24
{
    class Class1
    {
        static void Main()
        {
            int divid, divis, quoc,rest;
            divid = 10;
            divis = 5;
            quoc=divide(divid,divis,out rest);

            Console.WriteLine("{0}/{1}:quociente={2} else resto= {3}", divid, divis, quoc, rest);
        }

        static int divide(int dividendo, int divisor, out int resto) 
        {
            int quociente;
            quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;

        }
    }
}
