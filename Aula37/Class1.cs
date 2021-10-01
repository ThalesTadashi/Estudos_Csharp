using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula37
{

    abstract class Veiculo 
    {
        protected int velMaxima;
        protected int velAtual;
        protected bool ligado;
       
        public Veiculo()
        {
            ligado = false;
            velAtual = 0;

        }

        public void setLigado(bool ligado)
        {
            this.ligado = ligado;
        }
        public int getVelAtual()
        {
            return velAtual;
        }

        abstract public void aceleracao(int mult);
     
    }

    class Carro : Veiculo
    {
        public Carro()
        {
            velMaxima = 120;
        }

        override public void aceleracao(int mult)
        {
            velAtual+=10*mult;
        }
    }
    class Class1
    {
        public void Main()
        {

            Carro c = new Carro();

            c.aceleracao(1);

            Console.WriteLine(c.getVelAtual());
        }
    }
}
