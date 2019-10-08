using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana10_11.Clases
{
    class Boleta
    {
        public static int consecbol;
        private int nrobol;
        private short nrosilla;
        private char clsilla;
        private double valor;
        private double descuento;
        private double valorfinal;
        private Funcion funcion;

        public  int Nrobol { get => nrobol; set => nrobol = value; }
        public short Nrosilla { get => nrosilla; set => nrosilla = value; }
        public char Clsilla { get => clsilla; set => clsilla = value; }
        public double Valor { get => valor; set => valor = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public double Valorfinal { get => valorfinal; set => valorfinal = value; }
        public Funcion Funcion { get => funcion; set => funcion = value; }
        

        public Boleta()
        {
            try {
                Nrosilla = 0;
                Clsilla = ' ';
                Valor = 0.0d;
                Descuento = 0.0d;
                Valorfinal = 0.0d;
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error en el constructor de Boleta" + e);
            }
        }

        public Boleta(short nrosilla, char clsilla, double valor, double descuento, double valorfinal, Funcion funcion)
        {
            try
            {

                if (nrosilla == 0) throw new Exception("No se puede crear una boleta con silla en 0");
                else if (clsilla != 'G' && clsilla != 'V') throw new Exception("Clase inválida, No se puede crear la boleta");
                else if (valor == 0) throw new Exception("No se puede crear una boleta con valores en cero");
                else if (valorfinal == 0) throw new Exception("No se puede crear una boelta con valor final el cero");
                else
                {
                    this.Nrosilla = nrosilla;
                    this.Clsilla = clsilla;
                    this.Valor = valor;
                    this.Descuento = descuento;
                    this.Valorfinal = valorfinal;
                }
            }
            catch(Exception e)
            {
                throw new Exception("Ocurrió un error en el constructor de Boleta" + e);
            }
        }

 
    }
}
