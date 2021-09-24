using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula33
{
    class Veiculo
    {
        public int rodas;
        public int velMMax;
        private bool ligado;
        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }
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
            return (ligado ? "Sim":"Não");
        }
        public int getRodas()
        {
            return rodas;
        }
        public void setRodas(int rodas)
        {
            if (rodas < 0)
            {
                this.rodas = 0;
            }
            else if (rodas > 40)
            {
                this.rodas = 40;
            }
            else
            {
                this.rodas = rodas;
            }
        }
    }

    class Carro : Veiculo
    {
        public string nome;
        public string cor;
        public Carro(string nome, string cor):base(4)
        {
            Desligar();            
            velMMax = 150;
            this.nome = nome;
            this.cor = cor;
        }
    }

    class CarroCombate : Carro
    {
        public int munição;
        public CarroCombate():base("Carro dee Cobate","Verde")
        {
            
            munição = 100;
            setRodas(6);
        }
    }
    class Class1
    {
        static void Main()
        {
            Carro c1 = new Carro("BMW", "vermelho");
            CarroCombate cc1 = new CarroCombate();

            c1.Ligar();
            Console.WriteLine("Cor.......:{0}", c1.cor);
            Console.WriteLine("Nome......:{0}", c1.nome);
            Console.WriteLine("Rodas.....:{0}", c1.getRodas());
            Console.WriteLine("Vel. Max..:{0}", c1.velMMax);

            Console.WriteLine("Ligado....:{0}", c1.getLigado());
            Console.WriteLine("------------------");


            Console.WriteLine("Cor.......:{0}", cc1.cor);
            Console.WriteLine("Nome......:{0}", cc1.nome);
            Console.WriteLine("Rodas.....:{0}", cc1.getRodas());
            Console.WriteLine("Vel. Max..:{0}", cc1.velMMax);
            Console.WriteLine("Mmunição..:{0}", cc1.munição);

            Console.WriteLine("Ligado....:{0}", cc1.getLigado());
        }
    }
}

