using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19
{
    class Class1
    {
        static void Main()
        {
            int num = 5;
            string senha="123";
            string senhaUser;
            int tentativas=0;


            do
            {
                Console.Clear();
                Console.WriteLine("Digite a senha");
                senhaUser = Console.ReadLine();
                tentativas++;
            } while (senha != senhaUser);

            Console.Clear();
            Console.WriteLine("Senha Correta, Você teve {0} tentativas de Acerto",tentativas);
        }
    }
}
