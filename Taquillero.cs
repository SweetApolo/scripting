using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana10_11.Clases
{
    class Taquillero:Persona
    {
        private string codusr;
        

        public string Codusr { get { return codusr; } }

        public Taquillero() : base()
        {
            codusr = "";
        }

        public Taquillero(string nombre, string id, string tel, string codusr) : base(nombre, id, tel)
        {

            if (string.IsNullOrEmpty(codusr) || string.IsNullOrWhiteSpace(codusr)) throw new Exception("No se puede crear un taquillero sin código de usuario");
            else this.codusr = codusr;

        }

        public bool ComprarBoleta(Funcion funcion, short cantidad, char clase)
        {
            bool resultado = true;
            return resultado;


        }


    }
}
