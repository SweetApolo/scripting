using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1df
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Votos partido A y B");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Votos en Blanco y Anulados");
            int Blanco = int.Parse(Console.ReadLine());
            int Anulados = int.Parse(Console.ReadLine());

            Console.WriteLine("Total de poblacion");
            int n = int.Parse(Console.ReadLine());


            int VotantesTot = A + B + Blanco + Anulados;

            bool a = VotantesTot > n;
            bool b = Math.Abs(A - B) < 0.1 * VotantesTot;
            bool c = VotantesTot < 0.3 * n;

            if ((a || b) && c)
            {
                Console.WriteLine("las elecciones deben ser ejecutadas nuevamente ");
            }

            else
            {
                if (A > B)
                {
                    Console.WriteLine("Gana el partido A");
                }
                else
                {
                    Console.WriteLine("Gana el partido B");
                }

            }

        }
    }
    
}
