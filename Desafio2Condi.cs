using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Condi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresar el Smmlv
            Console.WriteLine("Ingresar el Smmlv");
            int Smmlv = int.Parse(Console.ReadLine());




            if (Smmlv < 2)
            {
                Console.WriteLine("Tarifa A");
                Console.WriteLine("Valor Cuota Moderadora 3,200");
            }
            else if ((2 <= Smmlv && Smmlv < 5))
            {
                Console.WriteLine("Tarifa B");
                Console.WriteLine("Valor Cuota Moderadora 12,700");

            }
            if (Smmlv >= 5)

            {
                Console.WriteLine("Tarifa C");
                Console.WriteLine("Valor Cuota Moderadora 35,500");
            }

        }
    }
}
