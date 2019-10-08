using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace semana10_11.Clases
{
    public class Cliente : Persona
    {
        private Tarjeta card;

        internal Tarjeta Card { get => card; }


        public Cliente() : base()
        {
        }

        public Cliente(string nombre, string id, string tel, string clave, int sdotarj) : base(nombre,id,tel)
        {
            try
            {
                //se genera el código del cliente con un random
                Random aleatorio = new Random();
                Tarjeta tarj = new Tarjeta(aleatorio.Next(), clave, sdotarj);
                card = tarj;
            }
            
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error en el constructor Cliente" + e);
            }
        }


        public bool ComprarBoleta(Funcion funcion, short cantidad, char clase, float descto, int valor)
        {
            bool resultado = false;
            DateTime min15 = DateTime.Parse("00:15:00");
            DateTime tiempototal = funcion.Horario.Add(min15.TimeOfDay);
            double valboleta;

            try
            {
                //valido que hayan sillas disponibles en la clase

                if (clase == 'G')
                {

                    valboleta = valor * (1 - descto);

                    if ((funcion.Sala.Nsgral - funcion.Sala.Contsg) >= cantidad)
                    {
                        if (DateTime.Now <= tiempototal) //se valida que la hora actual sea menor que la hora de la función + 15min
                        {
                            if (Card.Saldo >= (valboleta * cantidad)) //Se valida que se tenga saldo en la tarjeta
                            {
                                Card.ModificarSaldo(Convert.ToInt32(Card.Saldo - (valboleta * cantidad))); //se descuenta el saldo del cliente
                                resultado = true;
                                // la emisión de las boeltas la hacemos en el main
                            }
                            else throw new Exception("No hay saldo suficiente en la tarjeta");
                        }
                        else throw new Exception("No se pueden vender boletas para esta función");
                    }
                    else throw new Exception("No hay sillas disponibles");
                }
                else if (clase == 'V')
                {

                    valboleta = valor * (1 - descto);

                    if ((funcion.Sala.Ns1ra - funcion.Sala.Contsvip) >= cantidad)
                    {
                        if (DateTime.Now <= tiempototal) //se valida que la hora actual sea menor que la hora de la función + 15min
                        {
                            if (Card.Saldo >= (valboleta * cantidad)) //Se valida que se tenga saldo en la tarjeta
                            {
                                Card.ModificarSaldo(Convert.ToInt32(Card.Saldo - (valboleta * cantidad))); //se descuenta el saldo del cliente
                                resultado = true;
                                // la emisión de las boeltas la hacemos en el main
                            }
                            else throw new Exception("No hay suficiente saldo");
                        }
                        else throw new Exception("No se pueden vender boletas para esta función");

                    }
                    else throw new Exception("Sillas agotadas");
                }

                else
                {
                    resultado = false;
                    throw new Exception("No es una clase válida");
                }
                return resultado;

            }
            
            catch (Exception e)
            {
                throw new Exception("Ocurrió Error en Método Comprar Boleta" + e);
            }
        }

        public void incsaldo(int valor)
        {

            try
            {
                if (valor >= 20000 && valor <= 100000) Card.ModificarSaldo(Card.Saldo + valor);
                else throw new Exception("Valor a incrementar no válido");
            }

            catch (Exception e)
            {
                throw new Exception("Ocurrió Error en Método Incrementar Saldo" + e );
            }


        }

    }
}
