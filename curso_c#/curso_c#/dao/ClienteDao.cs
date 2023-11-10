using curso_c_.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_c_.dao
{
    internal class ClienteDao
    {
        public MySqlConnection Conectar()
        {
            string server = "bz3xb72yfv4yuaycbcac-mysql.services.clever-cloud.com";
            string usuario = "u18wsrvm2rmras9w";
            string password = "bZ1AYJlPpWcO2Btmi16r";
            string baseDeDatos = "bz3xb72yfv4yuaycbcac";
            string cadenaConexion = "Database=" + baseDeDatos + "; Data Source=" + server + "; User Id=" + usuario + "; Password=" + password + "";
            MySqlConnection conexionDb = new MySqlConnection(cadenaConexion);
            conexionDb.Open();
            return conexionDb;
            
        }

        public List<Cliente> ObtenerListadoDeClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            string consulta = "SELECT * FROM `clientes`";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();
            

            while (lectura.Read())
            {
                Cliente cliente = new Cliente();
                cliente.id = lectura.GetString(0);
                cliente.Nombre = lectura.GetString(1);
                cliente.Apellido = lectura.GetString(2);
                cliente.Telefono = lectura.GetString(3);
                cliente.TarjetaDeCredito = lectura.GetString(4);
                lista.Add(cliente);
            }
            comando.Connection.Close();

            

            return lista;
        }

        public void Guardar(Cliente cliente)
        {
            if (cliente.id == null)
            {
                insertar(cliente);
            }
            else
            {
                actualizar(cliente);
            }
        }

        private void insertar(Cliente cliente)
        {
            List<Cliente> lista = new List<Cliente>();
            string consulta = "INSERT INTO `clientes` (`id`, `nombre`, `apellido`, `telefono`, `tarjeta_de_credito`) VALUES (NULL, '" + cliente.Nombre + "', '" + cliente.Apellido + "', '" + cliente.Telefono + "', '" + cliente.TarjetaDeCredito + "');";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        private void actualizar(Cliente cliente)
        {
            List<Cliente> lista = new List<Cliente>();
            string consulta = "UPDATE `clientes` SET `nombre` = '"+ cliente.Nombre +"', `apellido` = '"+ cliente.Apellido +"', `telefono` = '"+ cliente.Telefono +"', `tarjeta_de_credito` = '"+ cliente.TarjetaDeCredito +"' WHERE `clientes`.`id` = "+ cliente.id +";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Eliminar(Cliente cliente)
        {
            List<Cliente> lista = new List<Cliente>();
            string consulta = "DELETE FROM clientes WHERE `clientes`.`id` = "+ cliente.id +";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
    }
}
