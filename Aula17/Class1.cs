using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17
{
    class Class1
    {
        static void Main()
        {
            int[] num = new int[10];

            for (int i=0;i<num.Length;i++)
            {
                num[i] = 0;
                Console.WriteLine("O valor de num na posição {0} é: {1}", i, num[i]) ;
            }
   
        }
    }
}
