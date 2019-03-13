using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1hhh
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Conjunto1 = { 0, 3, 6, 9, 12, 15, 18 };
            int[] Conjunto2 = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18 };
            int[] union = new int[Conjunto1.Length + Conjunto2.Length];

            for (int i = 0; i < Conjunto1.Length; i++)
            {

                union[i] = Conjunto1[i];
            }
            for (int i = Conjunto1.Length; i < union.Length; i++)
            {

                union[i] = Conjunto2[i - 7];
            }
            Console.WriteLine("Union:  ");
            for (int i = 0; i < union.Length; i++)
            {

                Console.WriteLine("" + union[i]);

            }
        
        }
    }
}
