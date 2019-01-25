using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_02_01
{
    class Desafío_02_01
    {
        static void Main(string[] args)
        {
            //Ingresar Datos 
            Console.WriteLine("Ingrese Cateto y & Cateto z");
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            //Hipotenusa
            double t = Math.Sqrt((y) * (y) + (z) * (z));
            Console.WriteLine("Hipotenusa t=" + t);

            //Angulo a
            double o = (y / t);
            double p = (Math.Asin(o));
            double a = (p * (180 / Math.PI));
            Console.WriteLine("Angulo a=" + a);

            //Angulo c
            double l = (y / t);
            double k = (Math.Acos(l));
            double c = (k * (180 / Math.PI));
            Console.WriteLine("Angulo c=" + c);
        }
    }
}
