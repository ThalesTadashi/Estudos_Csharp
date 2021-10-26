using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula45
{
    class Calc
    {
        public int soma(int n1, int n2)
        {
            return n1 + n2;
        }

        public int soma(params int[]n)
        {
            int s = 0;
            for (int i = 0; i < n.Length; i++)
            {
                s+=n[i];
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
        public double soma(double n1, double n2 )
        {
            return n1 + n2 ;
        }
        public int soma(int n1, int n2 , int n3 , int n4)
        {
            return n1 + n2 + n3 + n4;
        }
    }
    class Class1
    {
        static void Main()
        {
            

            Calc calc = new Calc();

            var res = calc.soma(10.5, 5);

            Console.WriteLine("Res: {0}", res);
        }

    }
}
