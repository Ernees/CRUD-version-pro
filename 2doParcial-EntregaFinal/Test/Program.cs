using Clases;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccesoDatos acceso = new AccesoDatos("localhost", "212_organizacion");

            //Empleado nuevoEmpleado = new Empleado();
            //nuevoEmpleado.Id = 6; 
            //nuevoEmpleado.Nombre = "Ernesto";
            //nuevoEmpleado.Apellido = "Huerta";
            //nuevoEmpleado.Sueldo = 56123423;

            acceso.EliminarBarco(20);

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
