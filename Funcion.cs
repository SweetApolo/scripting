using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana10_11.Clases
{
    public class Funcion
    {
        private string idfuncion;
        private Pelicula pelicula;
        private Sala sala;
        private DateTime horario;
        private DateTime duracion;

        public string Idfuncion { get => idfuncion; }
        public DateTime Horario { get => horario; }
        public DateTime Duracion { get => duracion; }
        public Pelicula Pelicula { get => pelicula;}
        public Sala Sala { get => sala; }

        public Funcion()
        {
            idfuncion = "";
            horario = new DateTime(2018, 1, 1, 0, 0, 0);
            duracion = new DateTime(2018, 1, 1, 0, 0, 0);
        }


        public Funcion(string idfuncion, Pelicula pelicula, Sala sala, DateTime horario, DateTime duracion)
        {

            try
            {
                if (string.IsNullOrEmpty(idfuncion) || string.IsNullOrWhiteSpace(idfuncion)) throw new ArgumentException("No se puede crear el objeto con una función nula");
                else if (duracion.Hour > 4) throw new Exception("No se puede crear una función superior a 3 horas");
                else
                {
                    this.idfuncion = idfuncion;
                    this.horario = horario;
                    this.duracion = duracion;
                    this.pelicula = pelicula;
                    this.sala = sala;
                }
            }

            catch (Exception e)
            {
                throw new Exception("Ocurrió un error en el constructor de Función" + e);
            }


        }


    }
}
