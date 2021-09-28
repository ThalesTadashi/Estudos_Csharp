using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula34
{
    class Veiculo
    {
        public int velAtual;
        private int velMax;
        protected bool ligado;
        public Veiculo(int velMax)
        {
            velAtual = 0;
            this.velMax = velMax;
            ligado = false;
        }
        public bool getLigado()
        {
            return ligado;
        }
        public int getVelmax()
        {
            return velMax;
        }
    }

    class Carro : Veiculo
    {
        public string nome;
        public Carro(string nome, int vm):base(vm)
        {
            this.nome = nome;
            ligado = true;
        }
    }
    class Class1
    {
        static void Main()
        {
            Carro carro = new Carro("BMW",270);


            Console.WriteLine("Nome:{0}", carro.nome);         
            Console.WriteLine("Vel.Atual:{0}", carro.getVelmax());
            Console.WriteLine("Ligado:{0}", carro.getLigado());


        }
    }
}
