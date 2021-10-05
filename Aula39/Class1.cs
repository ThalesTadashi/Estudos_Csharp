using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula39
{

    class Carro
    {
        private int velMax;

        public int vm
        {
            get
            {
                return velMax;
            }
            set
            {
                if(value < 0)
                {
                    velMax = 0;

                }
                else if (value>300)
                {
                    velMax = 300;
                }
                else
                {
                    velMax = value;
                }
            }
        }

        public Carro()
        {
            vm = 120;
        }


    }
    class Class1
    {
        public void Main()
        {
            Carro c1 = new Carro();

            Console.WriteLine("Velocidade: {0}",c1.vm);
        }
    }
}
