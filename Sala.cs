using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana10_11.Clases
{
    public class Sala
    {
        private short nsvip;
        private short nsgral;
        private short contsvip;
        private short contsg;

        public short Ns1ra { get => nsvip; }
        public short Nsgral { get => nsgral; }
        public short Contsvip { get => contsvip; set => contsvip = value; }
        public short Contsg { get => contsg; set => contsg = value; }

        public Sala()
        {
            try
            {
                nsvip = 0;
                nsgral = 0;
                contsvip = 0;
                contsg = 0;
            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error en el constructor de Sala" + e);
            }


        }

        public Sala(short nsvip,short nsgral)
        {
            try
            {
                //validar que la cantidad de sillas que llegan si sean de las que tengo sala

                if (nsvip == 0 || nsgral == 0) throw new Exception("No se puede crear sala con sillas en cero");
                else
                {
                    this.nsvip = nsvip;
                    this.nsgral = nsgral;
                    contsvip = 0;
                    contsg = 0;
                }

            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error en el constructor de Sala" + e);
            }

        }


    }
}
