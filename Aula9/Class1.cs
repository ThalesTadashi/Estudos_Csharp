using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9
{
    class Class1
    {
        static void Main()
        {
            float n1 = 10.5f;
            int n2 = (int)n1; //type cast = Converter um tipo em outro, são necessarias quando
                              //a conversão não podemm ser implicitas, isso é, quando 
                              //não pode ser convertida no ato da complilação 

            Console.WriteLine(n2);

        }
    }
}
