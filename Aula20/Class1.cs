using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20
{
    class Class1
    {
        static void Main()
        {
            int[] num = new int[3] {11,22,33};

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }



            foreach (int n in num)
            {
                Console.WriteLine(n);
            }
        }
    }
}
