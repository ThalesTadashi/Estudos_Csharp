using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula35
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Construtor da classe Base");
        }
    }
    class Derivada1:Base
    {
        public Derivada1()
        {
            Console.WriteLine("Construtor da classe Derivada1");
        }
    }
    class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Construtor da classe Derivada2");
        }
    }
    class Class1
    {
        public void Main()
        {
            Derivada2 derivada2 = new Derivada2();
        
        
        
        }


    }
}
