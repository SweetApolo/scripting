using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresa  Datos
            Console.WriteLine("Ingrese W & Angulo d & Cateto x ");
            double w = double.Parse(Console.ReadLine());
            double dGrados = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            //Angulo a Radian
            double d = dGrados * (Math.PI / 180.0);

            //Cateto t
            double o = ((x * x) + (w * w) - (2 * x) * (w) * Math.Cos(d));
            double t = Math.Sqrt(o);
            Console.WriteLine("Cateto t=" + t);

            //Angulo b, con ley del coseno
            double b = Math.Asin((x * Math.Sin(d)) / t);
            double bgrados = b * (180.0 / Math.PI);
            Console.WriteLine("Angulo b =" + bgrados);

            //Angulo a
            double a = (180.0 - dGrados - bgrados - 90.0);
            Console.WriteLine("Angulo a =" + a);
            double agrados = b * (180.0 / Math.PI);

            //Y 
            double y = (Math.Sin(agrados) * t);
            Console.WriteLine("Cateto Y =" + y);
        }
    }
}
