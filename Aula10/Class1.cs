using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    class Class1
    {

        static void Main()
        {
            //SE(Espressão Lógica){}

            int nota = 80;
            string resultado = "Reprovado";

            if (nota>=60)
            {
                resultado = "Aprovado";
            }
            Console.WriteLine("Resultado: {0}",resultado);
        }

    }
}
