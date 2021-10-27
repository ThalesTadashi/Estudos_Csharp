using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula47
{
    class Mat {
        public static double pi = 3.14;

        public static int dobro(int n)
        {
            return n * 2;
        }

    }

    class Class1
    {
        static void Main()
        {
            double vpi = Mat.pi;
            int num = 10;
            Console.WriteLine(vpi);
            Console.WriteLine(Mat.dobro(num));
        }
    }
}
