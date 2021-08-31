using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14
{
    class Class1
    {
        static void Main()
        {
            int tempo = 0;
            char escolha;

            inicio:

            Console.Clear();
            Console.WriteLine("Belo Horizonte/MG a Vìtoria/ES");
            Console.WriteLine("Escolha o Transporte: [a]=Avião | [c]=Carro | [o]=Ônibus ");

            escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 'a':
                case 'A':
                    tempo = 50;
                    break;

                case 'c':
                case 'C':
                    tempo = 480;
                    break;

                case 'o':
                case 'O':
                    tempo = 660;
                    break;

                default:
                    tempo = -1;
                    break;

            }
            if (tempo < 0)
            {
                Console.WriteLine("Trasnporte Inisponível");
            }
            else
            {
                Console.WriteLine("Para o Trasporte escolhido o temmpo é: {0} Minutos", tempo);
            }

            Console.WriteLine("Calcular outro transporte? [s/n]");
            escolha = char.Parse(Console.ReadLine());
            
            if(escolha == 's' || escolha == 'S')
            {
                goto inicio;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Fim do programa");
            }
        }
    }
}
