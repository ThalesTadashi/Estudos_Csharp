using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula27
{
    public class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;

        public Jogador(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
        ~Jogador()
        {
            Console.WriteLine("Jogador foi morto");
        }
    }

    class Class1
    {
            public static void Main()
            {
                Jogador j1 = new Jogador("Player 1");
                Jogador j2 = new Jogador("Player 2");
                

                j1.energia = 75;
                Console.WriteLine("Nome do Jogador 1 {0}", j1.nome);
                Console.WriteLine("Energia do Jogador 1 {0}", j1.energia);
            }


        }
}

