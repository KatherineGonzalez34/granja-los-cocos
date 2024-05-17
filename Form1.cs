using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GranjaLosCocos
{
    public partial class Form1 : Form
    {
        private Conexion conexion;
        public Form1()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string result = "";
            //MySqlDataReader mySqlDataReader = null;
            //string consulta = "SELECT * FROM alumnos";
            if(conexion.getConexion() != null)
            {
                //MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                //mySqlCommand.Connection = conexion.getConexion();
                //mySqlDataReader = mySqlCommand.ExecuteReader();
                //while (mySqlDataReader.Read())
                //{
                    //result = mySqlDataReader.GetString("nombre");
                //

                MessageBox.Show("Conexion establecida correctamente");
            } else
            {
                MessageBox.Show("No hay conexion establecida correctamente");
            }
        }
    }
}
