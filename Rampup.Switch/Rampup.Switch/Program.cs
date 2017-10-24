using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes;

            Console.WriteLine("Informe o nome do mês desejado(Digite Sair para fechar): ");

            while (true)
            {
                mes = Console.ReadLine();
                if (mes == "Sair" || mes == "sair")
                {
                    break;
                }

                switch (mes)
                {
                    case "Fevereiro":
                        Console.WriteLine("Este mês contém 28 ou 29 dias.");
                        break;
                    case "Abril":
                    case "Junho":
                    case "Setembro":
                    case "Novembro":

                        Console.WriteLine("Este mês contém 30 dias.");
                        break;

                    case "Janeiro":
                    case "Marco":
                    case "Maio":
                    case "Julho":
                    case "Agosto":
                    case "Outubro":
                    case "Dezembro":

                        Console.WriteLine("Este mês contém 31 dias.");
                        break;

                    default:

                        Console.WriteLine("Opção inválida. Informe novamente: ");
                        break;
                }
            }
        }
    }
}
