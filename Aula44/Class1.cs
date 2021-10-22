using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula44
{

    class Galinha
    {
        private string nomeGalinha;
        private int numOvo;
        public Galinha(string nomeGalinha)
        {
            this.nomeGalinha = nomeGalinha;
            numOvo = 0;
        }
        public Ovo botar()
        {
            numOvo++;
            return new Ovo(numOvo,nomeGalinha);
        }

    }
    class Ovo
    {
        private int numOvo;
        private string minhaGalinha;
        public Ovo(int numOvo, string minhaGalinha)
        {
            this.numOvo = numOvo;
            this.minhaGalinha = minhaGalinha;
            Console.WriteLine("Ovo Criado:{0} - {1}",this.numOvo,this.minhaGalinha);
        }
    }
    class Class1
    {

        static void Main()
        {
            Galinha g1 = new Galinha("Piu");
            Galinha g2 = new Galinha("Popo");
            Galinha g3 = new Galinha("Kókó");

            g1.botar();
            g1.botar();
            g2.botar();

            g2.botar();

            g3.botar();
            g3.botar();
            g3.botar();
            g3.botar();
        }
    }
}
