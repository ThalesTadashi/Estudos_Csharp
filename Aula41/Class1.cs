using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula41
{

    public interface Veiculo
    {
        void ligar();
        void desligar();
        void info();
    }
    public interface Combate
    {
        void disparar();
    }
    class Carro:Veiculo,Combate
    {
        public bool ligado;
        private int munição;
        public Carro()
        {
            setMunicao(100);
        }
        public void setMunicao(int qtde)
        {
            this.munição = qtde;
        }
        public void ligar()
        {
            this.ligado = true;
        }
        public void desligar()
        {
            this.ligado = false;
        }
        public void info()
        {

        }
        public void disparar()
        {
            
        }
    }

    class Class1
    {
        static void Main()
        {
            Carro c1 = new Carro();

            
        }
    }
}
