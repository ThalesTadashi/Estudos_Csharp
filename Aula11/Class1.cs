using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Class1
    {
        static void Main()
        {
            //SE(Espressão Lógica){}

            int nota = 80;
            string resultado;


            // >= 60 - Aprovado
            // 59 e 40 - Recuperação
            // <40 - Reprovado

            if (nota < 40)
            {
                resultado = "Reprovado";
            }
            else if (nota <60)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Aprovado";
            }
            Console.WriteLine("Resultado: {0}", resultado);
        }
    }
}
