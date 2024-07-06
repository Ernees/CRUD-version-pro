using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_2doParcial
{
    public class Empleado
    {
        int id;
        string nombre;
        string apellido;
        int edad;
        string departamento;

        public Empleado(string nombre, string apellido, int edad, string departamento)
        {
            //this.id = ;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.departamento = departamento;
        }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Departamento { get => departamento; set => departamento = value; }

        // Método virtual MostrarInformacion: implementar con StringBuilder
        //protected abstract double CalcularSalario();

        public virtual string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id {this.id}");
            sb.AppendLine($"Nombre {this.nombre}");
            sb.AppendLine($"Apellido {this.apellido}");
            sb.AppendLine($"Edad {this.edad}");
            sb.AppendLine($"Departamento {this.Departamento}");
            return sb.ToString();
        }
        //Sobrecarga del metodo MostrarInformacion(string formato). Si formato es "corto" muestra el id y
        //el nombre
        public string MostrarInformacion(string formato)
        {
            string dato;
            dato = $"Id: {this.id} - Nombre: {this.apellido}, {this.nombre}";

            if (formato != "corto")
            {
                dato = MostrarInformacion();
            }
            return dato;
        }

        public static bool operator ==(Empleado a, Empleado b)
        {
            bool esIgual;
            esIgual = false;
            if (a.Id == b.Id && a.Apellido == b.Apellido)
            {
                esIgual = true;
            }
            return esIgual;
        }

        public static bool operator !=(Empleado a, Empleado b)
        {
            return !(a == b);
        }

    }
}
