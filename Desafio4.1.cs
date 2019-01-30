using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de Datos
            Console.WriteLine("Ingrese Angulo b & Cateto z & Cateto y ");
            double bGrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //Grado a radianes
            double b = bGrados * (Math.PI / 180.0);


            //Hipotenus t
            double t = Math.Sqrt((y) * (y) + (z) * (z));
            Console.WriteLine("Hipotenusa t=" + t);

            //Angulo c, Cos (c)
            double c = (Math.Acos(y / t) * (180.0 / Math.PI));
            Console.WriteLine("Angulo c=" + c);

            //Angulo e
            double e = (180 - c);
            Console.WriteLine("Angulo e=" + e);

            //Angulo d
            double dgrados = (180 - bGrados - e);
            double d = (dgrados * (Math.PI / 180.0));
            Console.WriteLine("Angulo d=" + dgrados);

            //X
            double x = ((t * Math.Sin(b)) / Math.Sin(d));
            Console.WriteLine("x = " + x);
        }
    }
}
