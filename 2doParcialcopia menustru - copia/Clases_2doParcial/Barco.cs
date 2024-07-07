using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_2doParcial
{
    public abstract class Barco
    {
        int id;
        string nombre;
        string estado;
        double costo;
        EOperacion operacion;
        ETipo tipo;


        public Barco(string nombre, string estado, EOperacion operacion, int tripulacion, ETipo tipo)
        {
            this.Nombre = nombre;
            this.Estado = estado;
            this.Tripulacion = tripulacion;
            this.Operacion = operacion;
            this.Tipo = tipo;
        }

        public Barco()
        {
            
        }

        public int Id { get => id; set => id = value; }
        public abstract int Tripulacion { get; set; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Estado { get => estado; set => estado = value; }
        public EOperacion Operacion { get => operacion; set => operacion = value; }
        public ETipo Tipo { get => tipo; set => tipo = value; }
        public double Costo { get => costo; set => costo = value; }



        // Método virtual MostrarInformacion: implementar con StringBuilder
        //protected abstract double CalcularSalario();

        public abstract void CalcularCosto();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id {this.Id}");
            sb.AppendLine($"Nombre {this.Nombre}");
            sb.AppendLine($"Estado {this.Estado}");
            sb.AppendLine($"Operacion {this.Operacion}");
            sb.AppendLine($"Tripulacion {this.Tripulacion}"); 
            sb.AppendLine($"Costo {this.Costo}");
            sb.AppendLine($"Tipo {this.Tipo}");
            return sb.ToString();
        }
        //Sobrecarga del metodo MostrarInformacion(string formato). Si formato es "corto" muestra el id y
        //el nombre
        public bool CompararBarcos(Barco a, Barco b)
        {
            bool retorno;
            retorno = false;
            if(a==b)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Barco a, Barco b)
        {
            bool esIgual;
            esIgual = false;
            if (a.Nombre== b.Nombre)
            {
                esIgual = true;
            }
            return esIgual;
        }

        public static bool operator !=(Barco a, Barco b)
        {
            return !(a == b);
        }

    }
}
