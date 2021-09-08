using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula18
{
    class Class1
    {
        static void Main()
        {
            int[] num = new int[10];
            int i = 0;

            while (i < num.Length)
            {
                num[i]= 0;
                Console.WriteLine(num[i]);
                i++;
            }

            /*while (i<10)
            {
                Console.WriteLine("Contagem: {0}",i);
                i++;
            }
            */
            Console.WriteLine("Fim do loop");
        }
    }
}
