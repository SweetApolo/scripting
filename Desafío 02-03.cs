using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresa  Datos
            Console.WriteLine("Ingrese Angulo c & Cateto z");
            double cGrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            //Angulo a Radian
            double c = cGrados * (Math.PI / 180.0);

            //Hipotenusa
            double t = (z / Math.Sin(c));

            Console.WriteLine("Hipotenusa t=" + t);



            //Cateto Adyacente 
            double y = Math.Sqrt((t) * (t) - (z) * (z));
            Console.WriteLine("Cateto y=" + y);


            //Angulo a
            double o = (z / t);
            double p = (Math.Acos(o));
            double a = (p * (180 / Math.PI));
            Console.WriteLine("Angulo a=" + a);
        }
    }
}
