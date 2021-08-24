using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8
{
    class Class1
    {
        enum DiasSemana { Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};

        static void Main()
        {
            //DiasSemana ds = DiasSemana.Domingo;

            //              ou

            //DiasSemana ds = (DiasSemana)0;

            //        Também podemos:

            int ds = (int)DiasSemana.Sexta;

            Console.WriteLine(ds);
        }
    }
}
