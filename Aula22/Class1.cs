using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula22
{
    class Class1
    {

        //Umm metodo é um grupo de instruções que podem ser chamados 
        //a qualquer momento do nosso programa

        //void pq não retorna nenhum tipo de dado
        //parametro de entrada ()
        static void Ola()
        {
            Console.WriteLine("Ola Mundo");
        }
        //para chamar o Metodo é só colocar o nome e ()
        //ex Ola();
        
        static void soma(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("A soma de {0} e {1} é: {2}",n1 ,n2 ,res);
        }
        //para chamar o Metodo com os valores é só colocar o nome e os valores dentro do ()
        //ex soma(10,5);


        //Metodo com retorno
        //int r;
        //r = soma1(10,5);
        static int soma1(int n1, int n2)
        {
            int res = n1 + n2;
            return res;
        }


    }
}
