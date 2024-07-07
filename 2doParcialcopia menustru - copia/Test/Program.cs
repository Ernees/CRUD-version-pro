using Clases;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatoEmpleado acceso = new DatoEmpleado("localhost", "212_organizacion");

            //Empleado nuevoEmpleado = new Empleado();
            //nuevoEmpleado.Id = 6; 
            //nuevoEmpleado.Nombre = "Ernesto";
            //nuevoEmpleado.Apellido = "Huerta";
            //nuevoEmpleado.Sueldo = 56123423;

            acceso.EliminarEmpleado(20);

            //List<Empleado> miLista;

            //miLista = acceso.SeleccionarEmpleados();
            //foreach (Empleado mi in miLista)
            //{
            //    Console.WriteLine(mi.ToString());
            //}

            Console.ReadLine();
        }
    }
}
