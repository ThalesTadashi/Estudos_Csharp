using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula46
{
    class Calc
    {
        public int soma(int n1, int n2)
        {
            return n1 + n2;
        }

        public int soma(params int[] n)
        {
            int s = 0;
            for (int i = 0; i < n.Length; i++)
            {
                s += n[i];
            }
            return s;
        }
        public double soma(params double[] n)
        {
            double s = 0;
            for (int i = 0; i < n.Length; i++)
            {
                s += n[i];
            }
            return s;
        }
        public double soma(double n1, double n2)
        {
            return n1 + n2;
        }
        public int soma(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }
        public int fat(int n)
        {
            int res;
            if (n<=1)
            {
                res = 1;
            }
            else
            {
                res=n*fat(n - 1);
            }
            return res;
        }

    }
    class Class1
    {
        static void Main()
        {


            Calc calc = new Calc();

            var res = calc.fat(5);

            Console.WriteLine("Res: {0}", res);
        }

    }
}
