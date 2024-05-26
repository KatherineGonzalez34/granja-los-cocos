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

        public DataSet buscar(string strSQL, string tabla)
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

        public void operacion(string strsql)
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

        public double escalar_double(string strsql)
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

        public string escalar_cadena(string strsql)
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

        public Int64 escalar_entero(string strsql)
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

        public bool iniciarSesion(string usuario, string clave)
        {
            try
            {
                Open();
                string query = "SELECT * FROM trabajador WHERE usuario= @usuario && clave=@clave";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);
                object result = cmd.ExecuteScalar();
                return result != null;
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
