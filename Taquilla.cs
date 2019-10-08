using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana10_11.Clases
{
    class Taquilla
    {
        private short nro;
        private Taquillero taquillero;
        private List<Boleta> historico = new List<Boleta>();

        public short Nro  {get => nro; }
        internal Taquillero Taquillero { get => taquillero; set => taquillero = value; }
        internal List<Boleta> Historico { get => historico;  }

        public Taquilla()
        {
            nro = 0;
        }

        public Taquilla(short nro, Taquillero taquillero)
        {
            try { 
                if (nro ==0 ) throw new Exception("No se puede crear una taquilla cero");
                else { 
                    this.nro = nro;
                    Taquillero = taquillero;
                }
            }
            catch(Exception e)
            {
                throw new Exception("OCurrió Error en Constructor Taquilla" + e );
            }
        }


        //Composición se hace el new dentro de la clase
        //public Funcion funcion1 = new Funcion();
        
        
        public Boleta[] EmitirBoleta(char clase, Funcion funcion, short cantidad, double valboleta, float descto)
        {
            short silla;

            //se declara un vector para las boletas
            Boleta[] bol;

            try
            {
                if (cantidad <= 0)
                {
                    throw new Exception("La cantidad no puede ser cero");
                }

                else
                {
                    bol = new Boleta[cantidad];

                    for (int i = 0; i < bol.Length; i++)
                    {
                        if (clase == 'V')
                        {
                            funcion.Sala.Contsvip++;
                            silla = funcion.Sala.Contsvip;
                        }
                        else if (clase == 'G')
                        {
                            funcion.Sala.Contsg++;
                            silla = funcion.Sala.Contsg;
                        }
                        else
                        {
                            descto = 0;
                            silla = 0;
                        }
                        Boleta.consecbol = Boleta.consecbol + 1;
                        bol[i] = new Boleta();
                        bol[i].Nrobol = Boleta.consecbol;
                        bol[i].Nrosilla = silla;
                        bol[i].Clsilla = clase;
                        bol[i].Valor = valboleta;
                        bol[i].Descuento = valboleta * descto;
                        bol[i].Valorfinal = valboleta * (1 - descto);
                        bol[i].Funcion = funcion;
                        //Se adiciona a la lista de boletas
                        historico.Add(bol[i]);
                    }
                }
                return bol;
            }

            catch (Exception e)
            {
                throw new Exception("Ocurrió un error en método Emitir Boleta" + e);
            }
        }

        public int ConsultarSaldo(Cliente cliente)
        {
            try
            {
                return cliente.Card.Saldo;
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió Error en método Consultar Saldo" + e);
            }
        }

        public int CargarTarjeta(Cliente cliente, int valor)
        {

            try { 
                if (valor >= 20000 && valor <= 100000) cliente.incsaldo(valor);
                else throw new Exception("No es una cifra de recarga válida");

                return cliente.Card.Saldo;
            }
            catch(Exception e)
            {
                throw new Exception("Ocurrió Error en método cargar tarjeta" + e);
            }
        }


    }


}
