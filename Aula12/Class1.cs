using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
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

            if (nota >= 60){
                if (nota >= 90)
                {
                    if (nota >= 99)
                    {
                        resultado = "Aprovado com super louvor";
                    }
                    else
                    {
                        resultado = "Aprovado com louvor";
                    }
                }
                else
                {
                    resultado = "Aprovado";
                }
            }
            else
            {
                    if (nota >= 40)
                    {
                        resultado = "Recuperação";
                    }
                    else
                    {
                        resultado = "Reprovado";
                    }

                    
            }
            Console.WriteLine("Resultado: {0}", resultado);
        }
    }
}
