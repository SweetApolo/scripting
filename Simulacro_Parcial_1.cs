using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    public static int codigo = 0; // 0 Primer simulacro. 1 Segundo simulacro

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] <= 3)
            {
                salida++;
            }
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        for (int i = 0; i < notas.Length; i++)
        {

            double menor = notas[i];
            string menorN = nombres[i];

            for (int k = i; k < notas.Length; k++)
            {
                if (menor > notas[k])
                {

                    double pasar = menor;
                    menor = notas[k];
                    notas[k] = pasar;

                    string pasarN = menorN;
                    menorN = nombres[k];
                    nombres[k] = pasarN;
                }
            }

            notas[i] = menor;
            nombres[i] = menorN;
            Console.WriteLine("\nLos alumnos ordenados son: " + nombres[i]);
            Console.WriteLine("\nLas notas ordenadas son: " + notas[i]);
        }

        for (int i = 0; i < 5; i++)
        {
            salida[i] = nombres[i];
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        for (int i = 0; i < notas.Length; i++)
        {

            double menor = notas[i];
            string menorN = nombres[i];

            for (int k = i; k < notas.Length; k++)
            {
                if (menor > notas[k])
                {

                    double pasar = menor;
                    menor = notas[k];
                    notas[k] = pasar;

                    string pasarN = menorN;
                    menorN = nombres[k];
                    nombres[k] = pasarN;
                }
            }

            notas[i] = menor;
            nombres[i] = menorN;
            Console.WriteLine("\nLos alumnos ordenados son: " + nombres[i]);
            Console.WriteLine("\nLas notas ordenadas son: " + notas[i]);
        }

        int tamanoSalida = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if(notas[i] < 3)
            {
                tamanoSalida++;
            }
        }
        salida = new string[tamanoSalida];

        int count = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if(notas[i] < 3)
            {
                salida[count] = nombres[i];
                count++;
            }
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------

        int tamanoSalida = 0;
        char letra = 'A';
        for (int i = 0; i < nombres.Length; i++)
        {
            string nombreAnalizar = nombres[i];

            for (int k = 0; k < nombres[i].Length; k++)
            {
                char letraActual = nombreAnalizar[k];
                if (letra == letraActual)
                {
                    tamanoSalida++;
                    break;
                }
            }
        }

        salida = new string [tamanoSalida];

        int count = 0;
        for (int i = 0; i < nombres.Length; i++)
        {
            string nombreAnalizar = nombres[i];

            for (int k = 0; k < nombres[i].Length; k++)
            {
                char letraActual = nombreAnalizar[k];
                if (letra == letraActual)
                {
                    salida[count] = nombres[i];
                    count++;
                    break;
                }
            }
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }
}


