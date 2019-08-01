using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //string letras = "abcdeiopuvwxyzAEIJKLMNÑOUVWXYZ";
            string[] valores = new string[] { "a", "e", "i", "o", "u", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            int n = 8;

            //string[,] salida = new string[n, m];
            string[,] cuadrovocas = new string[n, n];

            for (int filas = 0; filas < n - 1; filas++)
            {
                for (int colomnass = 0; colomnass < n - 1; colomnass++)
                {
                    int i = random.Next(1, 33);
                    cuadrovocas[filas, colomnass] = valores[i];

                }

            }
            Console.WriteLine("Matriz: ");

            for (int filas = 0; filas < cuadrovocas.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < cuadrovocas.GetLength(1); columnas++)
                {
                    Console.Write("|" + cuadrovocas[filas, columnas]);
                }
                Console.Write("|\n");
            }



            for (int filas = 0; filas < n - 1; filas++)
            {
                for (int colomnass = 0; colomnass < n - 1; colomnass++)
                {
                    if (cuadrovocas[filas, colomnass] == "a" || cuadrovocas[filas, colomnass] == "e" || cuadrovocas[filas, colomnass] == "i" || cuadrovocas[filas, colomnass] == "o" || cuadrovocas[filas, colomnass] == "u" || cuadrovocas[filas, colomnass] == "A" || cuadrovocas[filas, colomnass] == "E" || cuadrovocas[filas, colomnass] == "I" || cuadrovocas[filas, colomnass] == "O" || cuadrovocas[filas, colomnass] == "U")
                    {
                        if (cuadrovocas[filas + 1, colomnass] == "a" || cuadrovocas[filas + 1, colomnass] == "e" || cuadrovocas[filas + 1, colomnass] == "i" || cuadrovocas[filas + 1, colomnass] == "o" || cuadrovocas[filas + 1, colomnass] == "u" || cuadrovocas[filas + 1, colomnass] == "A" || cuadrovocas[filas + 1, colomnass] == "E" || cuadrovocas[filas + 1, colomnass] == "I" || cuadrovocas[filas + 1, colomnass] == "O" || cuadrovocas[filas + 1, colomnass] == "U")
                        {
                            if (cuadrovocas[filas, colomnass + 1] == "a" || cuadrovocas[filas, colomnass + 1] == "e" || cuadrovocas[filas, colomnass + 1] == "i" || cuadrovocas[filas, colomnass + 1] == "o" || cuadrovocas[filas, colomnass + 1] == "u" || cuadrovocas[filas, colomnass + 1] == "A" || cuadrovocas[filas, colomnass + 1] == "E" || cuadrovocas[filas, colomnass + 1] == "I" || cuadrovocas[filas, colomnass + 1] == "O" || cuadrovocas[filas, colomnass + 1] == "U")
                            {
                                if (cuadrovocas[filas + 1, colomnass + 1] == "a" || cuadrovocas[filas + 1, colomnass + 1] == "e" || cuadrovocas[filas + 1, colomnass + 1] == "i" || cuadrovocas[filas + 1, colomnass + 1] == "o" || cuadrovocas[filas + 1, colomnass + 1] == "u" || cuadrovocas[filas + 1, colomnass + 1] == "A" || cuadrovocas[filas + 1, colomnass + 1] == "E" || cuadrovocas[filas + 1, colomnass + 1] == "I" || cuadrovocas[filas + 1, colomnass + 1] == "O" || cuadrovocas[filas + 1, colomnass + 1] == "U")
                                {

                                }
                                else
                                {
                                    Console.WriteLine("No hay");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay");
                        }
                    }
                }

            }

            //Se intento utilizar un booleano y simplificar los condicionales pero no funciono
            /*bool isvowel (string letter)
            {
                string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
                for (int i = 0; i < vowels.Length; i++)
                {
                    if (letter == vowels[i]) return true;
                }

                return false;
            }*/




        }
    }
}
