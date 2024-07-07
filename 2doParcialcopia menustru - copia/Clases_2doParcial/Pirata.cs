using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_2doParcial
{
    public class Pirata : Barco
    {
        int tripulacion;

        public override int Tripulacion
        {
            get => tripulacion; 
            set
            {
                if (value == 0)
                {
                    tripulacion = GenerarRandom.EnteroAleatorio(10, 30);
                }
                else
                {
                    tripulacion = value;
                }
            }
        }

        public override void CalcularCosto()
        {
            this.Costo = GenerarRandom.DoubleAleatorio(2000, 12001);
        }

        public Pirata(string nombre, string estado, EOperacion operacion, int tripulacion, ETipo tipo)
            : base(nombre, estado, operacion, tripulacion, tipo)
        {
            this.CalcularCosto();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("BARCO PIRATA");
            sb.Append(base.ToString());
            return sb.ToString();
        }
    }
}
