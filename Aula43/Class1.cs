using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula43
{
    struct Carro
    {

        public string modelo;
        public string cor;

        public void Info()
        {

            Console.WriteLine("Modelo: {0}", this.modelo);
            Console.WriteLine("Cor: {0}", this.cor); 
            Console.WriteLine("----------------------");

        }
    }
    class Class1
    {
        static void Main()
        {

            int[] numeros = new int[10];

            Carro [] carros = new Carro[5];

            carros[0].modelo = "HRV";
            carros[0].modelo = "Prata";

            carros[1].modelo = "Golf";
            carros[1].modelo = "Branco";

            carros[2].modelo = "Jetta";
            carros[2].modelo = "Preto";

            carros[3].modelo = "Argo";
            carros[3].modelo = "Branco";


            for (int i = 0; i < carros.Length; i++)
            {
                carros[i].Info();
            }

        }
    }
}
