using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class Class1
    {
        //essa pode ser vista por "void teste" mas não pode ser vista pelo 
        //medodo principal pois a variavel nãoe sta como static 
        int num_g = 0;
        static void main()
        {
            int num = 0;
        }




        void teste()
        {
            //essa variavel tem escopo diferente, ela não "Vê" a variavel do void main
            int num = 0;
            Console.WriteLine(num);
        }
    }
}
