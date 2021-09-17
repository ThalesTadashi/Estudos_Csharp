using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula28
{
    public class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;

        public Jogador()
        {
            energia = 0;
            vivo = true;
            nome = "Player";
        }
        public Jogador(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
        public Jogador(string n, int e)
        {
            energia = e;
            vivo = true;
            nome = n;
        }
        public Jogador(string n, int e, bool v)
        {
            energia = e;
            vivo = v;
            nome = n;
        }
        public void Info()
        {
            Console.WriteLine("Nome jogador:{0}",nome);
            Console.WriteLine("Eneergia jogador:{0}", energia);
            Console.WriteLine("Status do jogador:{0}", vivo);
        }

    }

    class Class1
    {
        public static void Main()
        {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador("Lucas");
            Jogador j3 = new Jogador("Lucas",85);
            Jogador j4 = new Jogador("gustavo", 0, false);



            j1.Info();
            j2.Info();
            j3.Info();
            j4.Info();

        }


    }
}
