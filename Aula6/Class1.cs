using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6
{
    class Class1
    {
        static void Main()
        {
            int v1, v2, soma;
            string nome;

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Nome digitado: {0}", nome);

            Console.WriteLine("Digite o primeiro valor:");
            v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            v2 = Convert.ToInt32(Console.ReadLine());

            soma = v1 + v2;
            Console.WriteLine("A soma de {0} + {1} é {2}", v1 ,v2 ,soma );

        }
    }
}
