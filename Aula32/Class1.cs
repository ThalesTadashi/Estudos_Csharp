using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula32
{
    class Veiculo
    {
        public int rodas;
        public int velMMax;
        private bool ligado;
        public void Ligar()
        {
            ligado = true;
        }
        public void Desligar()
        {
            ligado = false;
        }

        public string getLigado()
        {
            if (ligado)
            {
                return "Sim";
            }
            else
            {
                return "Não";
            }
        }
    }

    class Carro : Veiculo
    {
        public string nome;
        public string cor;
        public Carro(string nome, string cor)
        {
            Desligar();
            rodas = 4;
            velMMax = 150;
            this.nome = nome;
            this.cor = cor;
        }
    }
    class Class1
    {
        static void Main()
        {
            Carro c1 = new Carro("BMW","vermelho");

            Console.WriteLine("Cor.......:{0}",c1.cor);
            Console.WriteLine("Nome......:{0}", c1.nome);
            Console.WriteLine("Rodas.....:{0}", c1.rodas);
            Console.WriteLine("Vel. Max..:{0}", c1.velMMax);

            Console.WriteLine("Ligado....:{0}", c1.getLigado());
        }
    }
}
