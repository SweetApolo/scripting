using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana10_11.Clases
{
    class Tarjeta
    {
        private long codigo;
        private string clave;
        private int saldo;

        public long Codigo { get => codigo; }
        public string Clave { get => clave; }
        public int Saldo { get => saldo; }

        public Tarjeta()
        {

        }

        public Tarjeta(long codigo, string clave, int saldo)
        {
            try
            {
                if (codigo <= 0) throw new Exception("No se puede crear una tarjeta en cero, ni negativa");
                else if (string.IsNullOrEmpty(clave) || clave.Length != 4)
                    throw new Exception("No se puede crear una clave en blanco o nula, o con longitud diferente de 4");
                else
                {
                    this.codigo = codigo;
                    this.clave = clave;
                    saldo = 0;
                }

            }
            catch (Exception e)
            {
                throw new Exception("Ocurió error" + e);
            }
        }

        public void ModificarSaldo(int valor)
        {
            try
            {
                if (valor >= 20000 && valor <= 100000 ) saldo += valor;
                else throw new Exception("Error en el valor del saldo");

            }
            catch (Exception e)
            {
                throw new Exception("Ocurió error" + e);
            }
        }




    }
}
