using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Conjunto1 = { 0, 3, 6, 9, 12, 15, 18 };
            int[] Conjunto2 = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18 };
            int[] union = new int[17];
            int[] inter = new int[31];
            int interr = 0;

            Console.WriteLine("interseccion entre conjuntos");

            for (int b = 0; b < Conjunto2.Length; b += 1)  
            {
                for (int c = 0; c < Conjunto1.Length; c += 1)
                {
                    if (Conjunto2[b] == Conjunto1[c])
                    {
                        inter[interr] = Conjunto2[b];
                        Console.WriteLine(inter[interr]);
                        interr += 1;
                    }
                }

            }
        }
    }
}
