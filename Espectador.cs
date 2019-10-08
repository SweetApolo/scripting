using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana10_11.Clases
{
    class Espectador:Persona
    {

        public Espectador() : base()
        {
            
        }

        public Espectador(string nombre, string id, string tel) : base(nombre, id, tel)
        {

            
        }

        public bool ComprarBoleta(Funcion funcion, short cantidad, char clase, int valor)
        {
            try
            {
                bool resultado = false;
                DateTime min15 = DateTime.Parse("00:15:00");
                DateTime tiempototal = funcion.Horario.Add(min15.TimeOfDay);
                double valboleta;


                //valido que hayan sillas disponibles en la clase

                if (clase == 'G')
                {

                    valboleta = valor;

                    if ((funcion.Sala.Nsgral - funcion.Sala.Contsg) >= cantidad)
                    {
                        if (DateTime.Now <= tiempototal) //se valida que la hora actual sea menor que la hora de la función + 15min
                        {
                            resultado = true;
                            // la emisión de las boeltas la hacemos en el main
                        }
                    }

                }
                else if (clase == 'V')
                {

                    valboleta = valor;

                    if ((funcion.Sala.Ns1ra - funcion.Sala.Contsvip) >= cantidad)
                    {
                        if (DateTime.Now <= tiempototal) //se valida que la hora actual sea menor que la hora de la función + 15min
                        {
                            resultado = true;
                            // la emisión de las boeltas la hacemos en el main
                        }

                    }

                }

                else resultado = false;

                return resultado;
            }

            catch(Exception e)
            {
                throw new Exception("Ocurrió Error en el Método Comprar Boleta" + e);
            }
        }

    }
}
