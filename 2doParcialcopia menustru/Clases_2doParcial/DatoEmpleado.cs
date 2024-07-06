using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_2doParcial;
using MySql.Data.MySqlClient;


namespace Clases
{
    public class DatoEmpleado
    {
        string connectionString;

        public DatoEmpleado(string server, string db)
        {
            connectionString = $"Server={server}; DataBase={db}; User ID=root; Password=; SslMode=none;";
        }

        private MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(connectionString);
        }

        public List<Empleado> SeleccionarEmpleados()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            string query;
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                query = "SELECT * FROM empleados";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var empleado = new Empleado(reader.GetString("Nombre"),
                                                reader.GetString("Apellido"),
                                                reader.GetInt32("Edad"),
                                                reader.GetString("Departamento"));
                    empleado.Id = reader.GetInt32("Id");
                    listaEmpleados.Add(empleado);
                }
            }
            return listaEmpleados;
        }

        public void InsertarEmpleado(Empleado unEmpleado)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "INSERT INTO empleados(nombre,apellido,edad,departamento)" +
                    $"VALUES (@nombre, @apellido, @edad, @departamento)";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", unEmpleado.Nombre);
                comando.Parameters.AddWithValue("@apellido", unEmpleado.Apellido);
                comando.Parameters.AddWithValue("@edad", unEmpleado.Edad);
                comando.Parameters.AddWithValue("@departamento", unEmpleado.Departamento);

                comando.ExecuteNonQuery();
            }
        }


        public void ModificarEmpleado(Empleado unEmpleado)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "UPDATE empleados SET nombre = @nombre, apellido = @apellido, edad = @edad, departamento = @departamento " +
                    "WHERE id = @id";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", unEmpleado.Id);
                comando.Parameters.AddWithValue("@nombre", unEmpleado.Nombre);
                comando.Parameters.AddWithValue("@apellido", unEmpleado.Apellido);
                comando.Parameters.AddWithValue("@edad", unEmpleado.Edad);
                comando.Parameters.AddWithValue("@departamento", unEmpleado.Departamento);
                comando.ExecuteNonQuery();
            }
        }

        public void EliminarEmpleado(int id)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "DELETE FROM empleados WHERE id = @id";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();
            }
        }

    }
}
