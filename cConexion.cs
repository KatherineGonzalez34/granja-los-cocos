using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace GranjaLosCocos
{
    public class cConexion
    {
        private string connectionString = "server=localhost;user id=root;password=;persistsecurityinfo=True;database=granja_cocos";
        private MySqlConnection connection;

        public cConexion()
        {
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void Open()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void Close()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataSet buscar(String strSQL, String tabla)
        {
            DataSet ds = new DataSet();
            try
            {
                Open();
                MySqlDataAdapter daSQL = new MySqlDataAdapter(strSQL, connection);
                daSQL.Fill(ds, tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Close();
            }
            return ds;
        }

        public void operacion(String strsql)
        {
            try
            {
                Open();
                MySqlCommand cmSQL = new MySqlCommand(strsql, connection);
                cmSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Close();
            }
        }

        public double escalar_double(String strsql)
        {
            try
            {
                Open();
                MySqlCommand cmsSQL = new MySqlCommand(strsql, connection);
                return Convert.ToDouble(cmsSQL.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Close();
            }
        }

        public String escalar_cadena(String strsql)
        {
            try
            {
                Open();
                MySqlCommand cmsSQL = new MySqlCommand(strsql, connection);
                return Convert.ToString(cmsSQL.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Close();
            }
        }

        public Int64 escalar_entero(String strsql)
        {
            try
            {
                Open();
                MySqlCommand cmsSQL = new MySqlCommand(strsql, connection);
                return Convert.ToInt64(cmsSQL.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Close();
            }
        }

        public int ObtenerIdRaza(string nombreRaza)
        {
            try
            {
                Open();
                string query = "SELECT id FROM raza_gallina WHERE Nombre = @Nombre";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", nombreRaza);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Close();
            }
        }


    }
}
