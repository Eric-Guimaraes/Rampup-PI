using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Atv02.Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate coor = new Coordinate();
            
            Console.WriteLine("Informe a coordenada do eixo X: ");
            coor.EixoX = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe a coordenada do eixo Y: ");
            coor.EixoY = Convert.ToInt16(Console.ReadLine());

            if((coor.EixoX > 0)&&(coor.EixoY > 0))
            {
                coor.StatusOfAngle = 0;
            }
            else if((coor.EixoX < 0)&&(coor.EixoX > 0))
            {
                coor.StatusOfAngle = 1;
            }
            else if((coor.EixoX > 0)&&(coor.EixoY < 0))
            {
                coor.StatusOfAngle = 2;
            }
            else
            {
                coor.StatusOfAngle = 3;                
            }
            Console.Write("O ângulo pertence ao {0}", Enum.GetName(typeof(TypeOfAngle), coor.StatusOfAngle));

            Console.ReadKey();

        }
        enum TypeOfAngle
        {
            Quadrante_1,
            Quadrante_2,
            Quadrante_3,
            Quadrante_4,
        }
    }
    public class Coordinate
    { 
        public int EixoX { get; set; }
        public int EixoY { get; set; }
        public int StatusOfAngle { get; set; }
    }
}
