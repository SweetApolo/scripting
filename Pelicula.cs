using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana10_11.Clases
{
    public class Pelicula
    {
        private string titulo;
        private string director;
        private DateTime duracion;
        private string genero;
        private string censura;


        public string Titulo { get => titulo; }
        public string Director { get => director; }
        public DateTime Duracion { get => duracion; }
        public string Genero { get => genero; }
        public string Censura { get => censura; }


        public Pelicula()
        {
            try {
                titulo = "";
                director = "";
                genero = "";
                censura = "";
                duracion = new DateTime(2018, 1, 1, 0, 0, 0);

            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error en el constructor de Pelicula"  + e);
            }

        }

        public Pelicula(string titulo, string director, DateTime duracion, string genero, string censura)
        {
            try
            {
                if (string.IsNullOrEmpty(titulo) || string.IsNullOrWhiteSpace(titulo)) throw new ArgumentException("No se puede crear una película sin titulo");
                else if (string.IsNullOrEmpty(director) || string.IsNullOrWhiteSpace(director)) throw new ArgumentException("No se puede crear una película sin director");
                else if (string.IsNullOrEmpty(genero) || string.IsNullOrWhiteSpace(genero)) throw new ArgumentException("No se puede crear una película sin género");
                else if (string.IsNullOrEmpty(censura) || string.IsNullOrWhiteSpace(censura)) throw new ArgumentException("No se puede crear una película sin censura");
                {
                    this.titulo = titulo;
                    this.director = director;
                    this.genero = genero;
                    this.censura = censura;
                    this.duracion = duracion;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error en el constructor de Película" + e);
            }

        }
    }
}
