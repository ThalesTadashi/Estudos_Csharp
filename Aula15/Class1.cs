using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15
{
    class Class1
    {
        static void Main()
        {
            //Semm array int n1, n2, n3, n4, n5;
            int[] n = new int[5];  // Primeira posição do array é 0
            int[] num = new int [3]{ 55, 78, 99 }; //Atribuindo valores 
            int[] nuM = { 55, 78, 99 }; // Outra forma  *O tamanho do array é dito pela qtd de elementos
            n[0] = 111;
            n[1] = 222;
            n[2] = 333;
            n[3] = 444;
            n[4] = 555;

            Console.WriteLine(n[0]);
        }
    }
}
