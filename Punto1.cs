using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMplejidad_mEDIA
{
    class Program
    {
        

        public static string Signoss(string signo)
        {

            string arreglo = "6???4xxbl5???eee5";
            int contadorInterroga = 0;
            int numeroanterio = 0;
            bool sumadre = false;
            string result = "false";


            for (int i = -1; i++ < signo.Length - 1;)
                if (signo[i] >= '1' && signo[i] <= '9') contadorInterroga++;

            int[] g = new int[contadorInterroga];
            int[] h = new int[contadorInterroga];
            contadorInterroga = 0;

            for (int i = -1; i++ < signo.Length - 1;)
                if (signo[i] >= '1' && signo[i] <= '9')
                {
                    g[contadorInterroga] = int.Parse(signo[i].ToString());
                    h[contadorInterroga] = i;
                    contadorInterroga++;
                }
            for (int f = -1; f++ < contadorInterroga - 2;)
            {
                for (int i = f; i++ < contadorInterroga - 1;)
                {
                    if ((g[f] + g[i]) == 10)
                    {
                        numeroanterio = 0;
                        for (int b = h[f]; b++ < h[i] - 1;)
                        {
                            if (signo[b] == '?')
                                numeroanterio++;
                        }
                        if (numeroanterio == 3)
                            sumadre = true;

                        else
                        {
                            sumadre = false;
                            return result;
                        }
                        break;
                    }
                    break;
                }
                
            }
            if (sumadre)
                return "true";
            else
                return "false";
        }


        public static void Main()
        {
            Console.WriteLine(Signoss(Console.ReadLine()));


        }
    }
}
