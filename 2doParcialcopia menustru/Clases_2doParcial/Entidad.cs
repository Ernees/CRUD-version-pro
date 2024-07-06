using Clases_2doParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_2doParcial
{
    public class Entidad
    {
        #region Atributos
        private List<Empleado> empleados;
        private static DateTime inicioActividades;
        private string nombre;

        #endregion

        #region Propiedades
        public static DateTime InicioActividades { get => inicioActividades; set => inicioActividades = value; }
        public List<Empleado> Empleados { get => empleados; set => empleados = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        #endregion

        #region Constructores
        private Entidad()
        {
            empleados = new List<Empleado>();
        }

        public Entidad(string nombre) : this()
        {
            this.nombre = nombre;
        }

        static Entidad()
        {
            inicioActividades = DateTime.Now;
        }
        #endregion

        #region metodos

        public bool AñadirEmpleado(Empleado empleado)
        {
            bool agrego;
            agrego = false;
            if (!BuscarEmpleado(empleado))
            {
                this.Empleados.Add(empleado);
                agrego = true;
            }
            else
            {
                Console.WriteLine("No se encuentra");
                //throw new EmpleadoNoEncotradoException("El empleado ya se encuentra en la lista", empleado);
            }


            return agrego;
        }

        private bool BuscarEmpleado(Empleado unEmpleado)
        {
            bool existe;
            existe = false;
            foreach (Empleado empleado in this.empleados)
            {
                if (empleado == unEmpleado)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        public string MostrarEmpleados()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var empleado in empleados)
            {
                sb.Append(empleado.MostrarInformacion());
            }
            return sb.ToString();
        }

        //public Empleado BuscarPorId(int id)//cambiar por dni
        //{
        //    Empleado empleado;
        //    empleado = null;

        //    if (this.diccionarioEmpleados.ContainsKey(id))
        //    {
        //        empleado = this.diccionarioEmpleados[id];
        //    }
        //    else
        //    {
        //        Console.WriteLine("No se encuentra");
        //        //throw new EmpleadoNoEncotradoException($"No se encuentra el empleado con id: {id} en la nomina. ");
        //    }
        //    return empleado;
        //}

        //public string MostrarUltimoEmpleado()
        //{
        //    string cadena;
        //    cadena = "No hay empleados en la pila";
        //    if (this.pilaEmpleados.Count > 0)
        //    {
        //        Empleado ultimo = this.pilaEmpleados.Peek();
        //        cadena = ultimo.MostrarInformacion();
        //    }
        //    return cadena;
        //}
        #endregion
    }
}
