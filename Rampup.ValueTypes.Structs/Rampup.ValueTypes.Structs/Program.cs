using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.ValueTypes.Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            BookStruct bs = new BookStruct();
            BookClass bc = new BookClass();

            bs.ID = 100;
            bc.ID = 200;

            Console.WriteLine("Valor do ID usando STRUCT:{0} ", bs.ID);
            Console.WriteLine("Valor do ID usando CLASS:{0}", bc.ID);

            ChangeStructID(bs);
            ChangeClassID(bc);

            Console.WriteLine("Valores Alterados: Class:{0} Struct:{1} \n", bc.ID, bs.ID);

            int valor = Convert.ToInt32(Console.ReadLine());

            if (valor == 0)
            {
                Console.WriteLine("Status do meu Book: {0}", StatusBook.Request);
            }
            else if(valor == 1)
            {
                Console.WriteLine("Status do meu Book: {0}", StatusBook.Shipped);
            }
            else
            {
                Console.WriteLine("Status do meu Book: {0}", StatusBook.Closed);

            }

            Console.ReadKey();
        }
        static void ChangeStructID(BookStruct bs)
        {
            bs.ID = 0;
        }

        static void ChangeClassID(BookClass bc)
        {
            bc.ID = 1;
        }
    }
    struct BookStruct
    {
        public int ID { get; set; }
    }

    class BookClass
    {
        public int ID { get; set; }
    }

    //TRABALHANDO COM ENUM
    enum StatusBook
    {
        Request,
        Shipped,
        Closed,
    }
}
