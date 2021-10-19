using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula42
{
    struct Carro
    {
        public string marca;
        public string modelo;
        public string cor;

        public Carro(string marca, string modelo, string cor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
        }

        public void Info()
        {
            Console.WriteLine("Marca: {0}", this.marca);
            Console.WriteLine("Modelo: {0}", this.modelo);
            Console.WriteLine("Cor: {0}", this.cor);
        }
    }
    class Class1
    {
        static void Main()
        {
            Carro c1;

            c1.marca = "VW";
            c1.modelo = "Golf";
            c1.cor = "Branco";


            Console.WriteLine("Marca: {0}",c1.marca);
            Console.WriteLine("Modelo: {0}", c1.modelo);
            Console.WriteLine("Cor: {0}", c1.cor);

            //Carro c2;     Ira apresentar um erro pois não foi atribuido valor 

            //Console.WriteLine("Marca: {0}", c1.marca);
            //Console.WriteLine("Modelo: {0}", c1.modelo);
            //Console.WriteLine("Cor: {0}", c1.cor);


            //============= Usando o construtor ==================

            Carro c2 = new Carro("Honda", "City", "Prata");

            Console.WriteLine("Marca: {0}", c2.marca);
            Console.WriteLine("Modelo: {0}", c2.modelo);
            Console.WriteLine("Cor: {0}", c2.cor);





            c1.Info();
        }
    }
}
