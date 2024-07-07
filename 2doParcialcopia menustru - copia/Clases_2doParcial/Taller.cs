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
            foreach (Barco empleado in this.Barcos)
            {
                if (empleado == barco)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        //  HACER METODO REPARAR
        //public string MostrarEmpleados()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (var empleado in empleados)
        //    {
        //        sb.Append(empleado.MostrarInformacion());
        //    }
        //    return sb.ToString();
        //}
    }
}
