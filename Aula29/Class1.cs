using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula29
{
    static public class Jogador
    {
        static public int energia;
        static public bool vivo;
        static public string nome;

        static public void iniciar(string n )
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
        static public void Info()
        {
            Console.WriteLine("Nome jogador:{0}", nome);
            Console.WriteLine("Eneergia jogador:{0}", energia);
            Console.WriteLine("Status do jogador:{0}", vivo);
        }
    }

    class Inimigo
    {
        static public bool alerta;
        public string nome;

        public Inimigo(string n)
        {
            alerta = false;
            nome = n;
        }
        public void info()
        {
            Console.WriteLine(nome);
            Console.WriteLine(alerta);
            Console.WriteLine("--------");
        }
    }

    class Class1
    {
        public static void Main()
        {
            Jogador.iniciar("Bruno");
            Jogador.Info();

            Inimigo i1 = new Inimigo("Doido");
            Inimigo i2 = new Inimigo("Maluco");
            Inimigo i3 = new Inimigo("Pirado");

            Inimigo.alerta = true;

            i1.info();
            i2.info();
            i3.info();

        }


    }
}
