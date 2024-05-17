using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranjaLosCocos
{
    class Conexion
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "alumnosC";
        private string user = "root";
        private string password = "";
        private string port = "3307";
        private string cadenaConexion;

        public Conexion() {
            cadenaConexion = "database=" + database +
                ";server=" + server +
                ";port=" +port +
                ";user=" + user +
                ";password=" + password;
        }

        public MySqlConnection getConexion()
        {
            if(conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }

            return conexion;
        }
    }
}
