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
            Console.WriteLine("Ingrese Angulo d & Angulo b & Cateto y ");
            double dGrados = double.Parse(Console.ReadLine());
            double bGrados = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //Angulo a Radian
            double d = dGrados * (Math.PI / 180.0);
            double b = bGrados * (Math.PI / 180.0);


            //Angulo a
            double aGrados = (180.0 - dGrados - bGrados - 90.0);
            double a = aGrados * (Math.PI / 180.0);
            Console.WriteLine("Angulo a=" + aGrados);

            //Cateto Z con Tan(a) despejando
            double z = (y / Math.Tan(a));
            Console.WriteLine("Cateto z = " + z);
        }
    }
}
