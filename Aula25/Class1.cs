using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula25
{
    class Class1
    {
        static void Main()
        {
            soma();
        }

        static void soma(params int[]n)
        {
            int res=0;

            if (n.Length < 1)
            {
                Console.WriteLine("Não temm valores para serem somados");
            }else if (n.Length <2)
            {
                Console.WriteLine("Valores insuficientes para a soma:{0}",n[0]);
            }
            else
            {
                for (int i = 0; i < n.Length; i++)
                {
                    res += n[i];
                }
            }

            Console.WriteLine("A soma dos valores é", res);
        }
    }
}
