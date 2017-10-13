using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.tipos
{
    class Program
    {
        static void Main(string[] args)
        {

            //CONVERSÃO EXPLÍCITA
            DateTime dt = Convert.ToDateTime("10/02/2000");

            //CONVERSÃO IMPLÍCITA
            string dataAtual = dt.ToString();
            string dataCurta = dt.ToShortDateString();
            //string dataAno = dt.ToYear.

            /*
            //TIPOS DE VARIÁVEIS
            float f = 10.2f; //suporta até aprox 7 casas
            double d = 20.33; //suporta até aprox 16 casas
            byte by = 0;
            bool bo = true;
            string nome = "Lucas de CPS";

            //BOXING
            int i = 10;
            object o = i;

            //UNBOXING
            int x = (int)o;
            */

            Console.WriteLine(dataCurta);
            Console.ReadKey();
            
        }
    }
}
