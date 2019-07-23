using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                //PUNTO 1

                Console.Write("PUNTO 1. Ingrese un n: ");
                int u, sumama = 0;
                u = Int32.Parse(Console.ReadLine());

                for (int I = 1; I <= u; I++)
                    sumama = sumama + I;
                Console.WriteLine("La suma: " + sumama);

                //PUNTO 2
                
                     Console.Write("PUNTO 2. Ingrese un n: ");
                
                    int q, t = 0;
                    q = Int32.Parse(Console.ReadLine());
                    for (int i = 1; i <= q; i++)
                    {
                        if (i % 3 == 0)
                        { 
                            t += i;
                        }
                    }
                    Console.WriteLine("El resultado es {0} ", t);

                


                //PUNTO 3
                Console.WriteLine("PUNTO 3. Digite un numero: ");
                int w = int.Parse(Console.ReadLine());
                int multiplicacion = 0;

                for (int i = 1; i <= 12; i++)
                {
                    multiplicacion = w * i
                        ;
                    Console.WriteLine(multiplicacion);
                }


                //PUNTO 4
                Console.WriteLine("PUNTO 4. Los años bisiestos son:");

                DateTime hoy = (DateTime.Today);
                int bisiesto = hoy.Year;

                int suma = 0;
                while (!(bisiesto % 4 == 0)) {
                    bisiesto += 1;
                }
                for (int i = 0; i <= 20; i++)
                {
                    suma = bisiesto + i * 4;
                    if(!(suma % 100 == 0))
                    { Console.WriteLine(suma); }
                }





                //PUNTO 5
                


                //PUNTO 6
                Console.WriteLine("PUNTO 6. Mayor y Menor numeros: ");
                int may = -100, men = 100;
                String cad = "";
                Random ale = new Random();
                int[] Num = new int[100];
                for (int i = 0; i < 100; i++)
                {
                    Num[i] = ale.Next(101);
                    if (Num[i] > may)
                    {
                        may = Num[i];
                    }
                    if (Num[i] < men)
                    {
                        men = Num[i];
                    }
                    cad = cad + " " + Num[i];
                }
                Console.WriteLine(cad);
                Console.WriteLine("El mayor es:" + may);
                Console.WriteLine("El menor es:" + men);
                Console.ReadLine();

                //PUNTO 7
                Console.WriteLine("PUNTO 7. Digite un numero:  ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("sumar presione 1 o producto presione 2");
                int sp = int.Parse(Console.ReadLine());
                int sumar = 0;
                int productor = 1;

                if(sp == 1)
                {
                    for (int i = 0; i <= num; i++) { sumar += i; }
                    Console.WriteLine( sumar);
                }

                else if (sp == 2)
                {
                    for (int i = 1; i <= num; i++) { productor = i * productor; }
                    Console.WriteLine( productor);
                }
                else { Console.WriteLine("Solo presione 1 o 2!!"); }



                //PUNTO 9
                Console.WriteLine("PUNTO 9. Digite un numero: ");
                double non = double.Parse(Console.ReadLine());
                double sumamar = 0;

                for (double i = 1; i <= non; i++) { sumamar += Math.Pow(i, i); }
                Console.WriteLine(sumamar);

                Console.WriteLine("FIN");
                double nunu = double.Parse(Console.ReadLine());



            }

            catch (Exception error)
            {
                Console.WriteLine(error);
            }

            
        }
    }
}
