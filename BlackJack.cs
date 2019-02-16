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
            Console.WriteLine("21 Blackjack");

            Random aleatorio = new Random();
            int ValorCarta = 0;
            int ValorCartaDos = 0;
            int ValorCartaExtra = 0;
            int total = 0;
            string continuar = "s";
            
                

            
            ValorCarta = aleatorio.Next(1, 11);
            Console.WriteLine("1 Carta =" + ValorCarta);
            ValorCartaDos = aleatorio.Next(1, 11);
            Console.WriteLine("2 Carta =" + ValorCartaDos);
            total = ValorCarta + ValorCartaDos;
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Continuar (s/n)");
            continuar = Console.ReadLine();



            while (continuar == "s" && total <= 21)
            { 
               
                ValorCartaExtra = aleatorio.Next(1, 11);
                Console.WriteLine("Valor Carta Extra =" + ValorCartaExtra);
                total += ValorCartaExtra;
                Console.WriteLine("Total: " + total);


                if (total > 21)
                {

                    Console.WriteLine("Te pasaste de 21, Intenta de nuevo");
                }
                else
                {

                    Console.WriteLine("Quiere otra carta (s/n): ");
                    continuar = Console.ReadLine();
                    if (continuar == "n")
                    {
                        Console.WriteLine("Total :" + total);
                        Console.WriteLine("Gracias por jugar F");
                    }
                       



                }
                if (total == 21)
                {

                    Console.WriteLine("Felicitaciones :)");
                }


            }




        }
    }
}
