using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.Condi
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
            }
            else if ((2 <= Smmlv && Smmlv < 4))
            {
                Console.WriteLine("Tarifa B");
            }
            if (Smmlv >= 4)

            {
                Console.WriteLine("Tarifa C");
            }

        }
    }
}
