using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso datos
            Console.WriteLine("Ingrese Ángulo c & Cateto w & Cateto t ");
            double cgrados = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());

            //Grados a Radianes 
            double c = cgrados * (Math.PI / 180.0);

            //Angulo e, Angulo complementarios
            double egrados = 180.0 - cgrados;
            double e = egrados * (Math.PI / 180.0);
            Console.WriteLine("Ángulo e= " + egrados);

            //Angulo d, Ley de senos

            double d = Math.Asin((Math.Sin(e) * t) / w);
            double dgrados = d * (180.0 / Math.PI);
            Console.WriteLine("Angulo d =" + dgrados);

            //Angulo b

            double bgrados = 180.0 - dgrados - egrados;
            double b = bgrados * (Math.PI / 180.0);
            Console.WriteLine("Angulo b =" + bgrados);

            //X
            double x = (Math.Sin(b) * t) / Math.Sin(d);
            Console.WriteLine("x =" + x);

        }
    }
}
