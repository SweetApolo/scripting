using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresa  Datos
            Console.WriteLine("Ingrese Hipotenusa t & Angulo a");
            double t = double.Parse(Console.ReadLine());
            double aGrados = double.Parse(Console.ReadLine());

            //Angulo a Radian
            double a = aGrados * (Math.PI / 180.0);

            //Cateto Adyacente 
            double l = Math.Cos(a);
            double z = (l * t);
            Console.WriteLine("Cateto z=" + z);

            //Cateto Opuesto 
            double k = Math.Sin(a);
            double y = (k * t);
            Console.WriteLine("Cateto y=" + y);

            //Angulo c
            double g = (y / t);
            double h = (Math.Acos(g));
            double c = (h * (180 / Math.PI));
            Console.WriteLine("Angulo c=" + c);
        }
    }
}
