using Clases_2doParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_2doParcial
{
    public class Taller
    {
        private List<Barco> barcos;
        private string nombre;

        public List<Barco> Barcos { get => barcos; set => barcos = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        private Taller()
        {
            barcos = new List<Barco>();
        }

        public Taller(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public bool IngresarBarco(Barco barco)
        {
            bool agrego;
            agrego = false;
            if (!EncontrarBarco(barco))
            {
                this.Barcos.Add(barco);
                agrego = true;
            }
            else
            {
                Console.WriteLine("No se encuentra");
                //throw new EmpleadoNoEncotradoException("El empleado ya se encuentra en la lista", empleado);
            }
            return agrego;
        }

        private bool EncontrarBarco(Barco barco)
        {
            bool existe;
            existe = false;
            foreach (Barco bar in this.Barcos)
            {
                if (bar == barco)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        //  HACER METODO REPARAR


        public bool Reparar(Taller taller, Barco barcoForm)
        {
            bool retorno;
            retorno = false;
            // Validar que el objeto recibido sea de tipo Taller
            if (taller != null || (taller is Taller))
            {


                for (int i = 0; i < Barcos.Count(); i++)
                {
                    if (barcoForm is Pirata)
                    {
                        barcoForm.CalcularCosto();
                        barcoForm.Estado = "Reparado";
                        retorno = true;
                    }
                    else if (barcoForm is Marina)
                    {
                        barcoForm.CalcularCosto();
                        barcoForm.Estado = "Reparado";
                        retorno = true;
                    }
                    
                }
            }
            return retorno;
        }





    }
}
