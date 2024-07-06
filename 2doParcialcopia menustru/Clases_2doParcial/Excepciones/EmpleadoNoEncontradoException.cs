using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_2doParcial.Excepciones
{
    internal class EmpleadoNoEncontradoException: Exception
    {
        Empleado empleadoException;

        public EmpleadoNoEncontradoException(string mensaje, Empleado empleadito)
            : base(mensaje)
        {
            empleadoException = empleadito;
        }
        public EmpleadoNoEncontradoException(string mensaje)
            : base(mensaje)
        {

        }

        public void LogException()
        {
            string filePath = "log.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: Se intento guardar: {this.empleadoException.MostrarInformacion("Corto")}");
            }
        }
    }
}
