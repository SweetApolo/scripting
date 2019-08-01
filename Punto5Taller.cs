using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Escriba el tamaño de la matriz de un tamaño minimo de 2 a un maximo de 10-----");
            int n = int.Parse(Console.ReadLine());

            while (n > 10 || n < 2)
            {
                Console.WriteLine("--no es un numero entre 2 y 10--");
                n = int.Parse(Console.ReadLine());
            }
            
            Random RNG = new Random();
            string[,] Tablero = new string[n, n];
            string X = "X";
            string O = "o";
            string Y = "Y";
            
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Tablero[i, k] = O; 
                }
            }

            int yA = RNG.Next(0, n);  
            int yB = RNG.Next(0, n); 
            Tablero[yA, yB] = Y;

            int xA = RNG.Next(0, n);    
            int xB = RNG.Next(0, n);    

            

            Tablero[xA, xB] = X;
            
            for (int i = 0; i < n; i++)   
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write(Tablero[i, k]);
                }
                Console.WriteLine();
            }
                      
            
            int sumaFila1 = xA - yA;
            
            int sumaColumna1 = xB - yB;
           
            if (true)
            {
                sumaFila1 = Math.Abs(sumaFila1);
               
                sumaColumna1 = Math.Abs(sumaColumna1);
               
            }
            int sumaNumFila = n - sumaFila1;
            int sumaNumColumna = n - sumaColumna1;
            sumaNumFila = Math.Abs(sumaNumFila);
            sumaNumColumna = Math.Abs(sumaNumColumna);

            Console.WriteLine(sumaFila1);
            Console.WriteLine(sumaNumFila);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                i++;
            }

            int pasos = 0;
            int pasosA = 0;
            int pasosB = 0;
            if (sumaFila1 < sumaNumFila)
            {
                Console.WriteLine("pasos en moverse en filas: " + sumaFila1);
                pasos += sumaFila1;
                pasosA = sumaFila1;

            }
            else
            {
                Console.WriteLine("pasos en moverse en filas: " + sumaNumFila);
                pasos += sumaNumFila;
                pasosA = sumaNumFila;
            }


            if (sumaColumna1 < sumaNumColumna)
            {
                Console.WriteLine("pasos en moverse en columna: " + sumaColumna1);
                pasos += sumaColumna1;
                pasosB = sumaColumna1;
            }
            else
            {
                Console.WriteLine("pasos en moverse en columna: " + sumaNumColumna);
                pasos += sumaNumColumna;
                pasosB = sumaNumColumna;
            }

            Console.WriteLine();


            Console.WriteLine("Pasos que debe realizar la (X) para llegar a la (Y) eficientemente " + pasos);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                i++;
            }
            

            if (xA - yA == 0)
            {
                Console.WriteLine("No se mueve en la fila");
            }
            else if (sumaFila1 < sumaNumFila)
            {
                Console.WriteLine("Se mueve hacia abajo");  
                for (int i = 0; i == pasosA; i++)
                {             
                    for (int k = 0; k == pasosB; k++)
                    {
                        Tablero[xA + i, xB + k] = "X";                        
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Se mueve hacia a arriba");
                for (int i = 0; i == pasosA; i++)
                {              
                    for (int k = 0; k == pasosB; k++)
                    {
                        Tablero[xA + i, xB + k] = "X";                        
                    }
                }
            }


            if (xB - yB == 0)
            {
                Console.WriteLine("No se mueve en la columna.");
            }
            else if (sumaColumna1 < sumaNumColumna)
            {
                Console.WriteLine("Se mueve hacia la Derecha");
                
            }
            else if (sumaColumna1 > sumaNumColumna)
            {
                Console.WriteLine("Se mueve hacia la Derecha");
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)   
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write(Tablero[i, k]);
                }
                Console.WriteLine();
            }
        }
    }
}