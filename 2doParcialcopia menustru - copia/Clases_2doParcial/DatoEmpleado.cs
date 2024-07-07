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

        public List<Barco> SeleccionarEmpleados()
        {
            List<Barco> listaEmpleados = new List<Barco>();
            string query;
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                query = "SELECT * FROM barcos";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EOperacion operacionEnum;
                    ETipo tipo;
                    string tipoString = reader.GetString("Tipo");
                    string operacionString = reader.GetString("Operacion");
                    double costo = reader.GetDouble("Costo");

                    Enum.TryParse<EOperacion>(operacionString, out operacionEnum);
                    Enum.TryParse<ETipo>(tipoString, out tipo);
                    Barco barco = null;
                    if (tipo == ETipo.Pirata)
                    {
                        barco = new Pirata(reader.GetString("Nombre"), reader.GetString("Estado Reparado"), operacionEnum, reader.GetInt32("Tripulacion"), tipo);
                        
                    }
                    else if (tipo == ETipo.Marina)
                    {
                        barco = new Marina(reader.GetString("Nombre"), reader.GetString("Estado Reparado"), operacionEnum, reader.GetInt32("Tripulacion"), tipo);
                    }
                    barco.Costo = costo;
                    barco.Id = reader.GetInt32("Id");
                    listaEmpleados.Add(barco);
                }
            }
            return listaEmpleados;
        }

        public void InsertarEmpleado(Barco barco)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "INSERT INTO barcos(Nombre,Operacion,`Estado Reparado`,Tripulacion,Costo,Tipo)" +
                    $"VALUES (@nombre, @operacion, @estado, @tripulacion, @costo, @tipo)";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", barco.Nombre);
                comando.Parameters.AddWithValue("@operacion", barco.Operacion.ToString());
                comando.Parameters.AddWithValue("@estado", barco.Estado);
                comando.Parameters.AddWithValue("@tripulacion", barco.Tripulacion);
                comando.Parameters.AddWithValue("@costo", barco.Costo);
                comando.Parameters.AddWithValue("@tipo", barco.Tipo.ToString());

                comando.ExecuteNonQuery();
            }
        }

        public void ModificarEmpleado(Barco barco)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "UPDATE barcos SET Nombre = @nombre, Operacion = @operacion, `Estado Reparado` = @estado, Tripulacion = @tripulacion, Costo = @costo, Tipo = @tipo " +
                    "WHERE id = @id";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", barco.Id);
                comando.Parameters.AddWithValue("@nombre", barco.Nombre);
                comando.Parameters.AddWithValue("@operacion", barco.Operacion.ToString());
                comando.Parameters.AddWithValue("@estado", barco.Estado);
                comando.Parameters.AddWithValue("@tripulacion", barco.Tripulacion);
                comando.Parameters.AddWithValue("@costo", barco.Costo);
                comando.Parameters.AddWithValue("@tipo", barco.Tipo.ToString());
                comando.ExecuteNonQuery();
            }
        }

        public void EliminarEmpleado(int id)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                string query = "DELETE FROM barcos WHERE id = @id";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();
            }
        }

    }
}
