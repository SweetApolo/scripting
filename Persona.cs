using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using semana10_11.Clases;

namespace semana10_11.Clases
{
    public abstract class Persona
    {
        protected string nombre;
        protected string id;
        protected string tel;

        
        public string Nombre { get { return nombre; } }
        public string Id { get { return id; } }
        public string Tel { get { return tel; } }
        

        public Persona()
        {
            try
            {
                nombre = "";
                id = "";
                tel = "";
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error en el constructor de Persona" + e);
            }

        }

        public Persona(string nombre, string id, string tel)
        {

            try
            {


                if (string.IsNullOrEmpty(nombre) || string.IsNullOrWhiteSpace(nombre)) throw new Exception("No se puede crear una persona sin nombre");

                else if (string.IsNullOrEmpty(id) || string.IsNullOrWhiteSpace(id)) throw new Exception("No se puede crear una persona sin id");

                else if (string.IsNullOrEmpty(tel) || string.IsNullOrWhiteSpace(tel)) throw new Exception("No se puede crear una persona sin teléfono de contacto");

                else
                {
                    this.nombre = nombre;
                    this.id = id;
                    this.tel = tel;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error en el constructor Persona" + e);
            }
        }


    }
}
