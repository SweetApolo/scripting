using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("-----Tablero Original----- \n");
                string[,] tablero = new string[7, 7] {{" "," "," "," "," "," "," "},
                                                      {" ","-"," ","?","d","d"," "},
                                                      {" ","b","d","?"," ","b"," "},
                                                      {" "," ","b","d"," ","b"," "},
                                                      {" "," "," "," "," ","b"," "},
                                                      {" "," "," "," "," ","?"," "},
                                                      {" "," "," "," "," "," "," "}};

                for (int fil = 0; fil < tablero.GetLength(0); fil++)
                {

                    for (int col = 0; col < tablero.GetLength(1); col++)
                    {
                        Console.Write("|" + " " + tablero[fil, col] + " ");
                    }
                    Console.Write("|" + "\n");
                }

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("\n");
                    i++;
                }


                for (int fil = 0; fil < tablero.GetLength(0); fil++)
                {

                    for (int col = 0; col < tablero.GetLength(1); col++)
                    {

                        if (tablero[fil, col] == "?")
                        {
                            if (tablero[fil + 1, col] != " ")
                            {
                                tablero[fil, col] = "s";
                                break;
                            }
                            if (tablero[fil - 1, col] != " ")
                            {
                                tablero[fil, col] = "b";
                                break;
                            }
                            if (tablero[fil, col - 1] != " ")
                            {
                                tablero[fil, col] = "i";
                                break;
                            }
                            if (tablero[fil, col + 1] != " ")
                            {
                                tablero[fil, col] = "d";
                                break;
                            }
                        }
                    }
                }

                Console.WriteLine("-----Nuevo Tablero----- \n");
                for (int fil = 0; fil < tablero.GetLength(0); fil++)
                {

                    for (int col = 0; col < tablero.GetLength(1); col++)
                    {
                        Console.Write("|" + " " + tablero[fil, col] + " ");
                    }
                    Console.Write("|" + "\n");
                }

                for (int i = 0; i < 4; i++)
                {
                    Console.Write("\n");
                    i++;
                }

                for (int fil = 0; fil < tablero.GetLength(0); fil++)
                {
                    for (int col = 0; col < tablero.GetLength(1); col++)
                    {
                        if (tablero[fil, col] != " ")
                            Console.Write(tablero[fil, col]);
                        
                    }
                    
                }
                Console.WriteLine();
                Console.WriteLine();

            }
            catch(Exception error)
            {
                Console.WriteLine(error);
                Console.ReadKey();
            }


        }
    }
}
