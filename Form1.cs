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
            string result = "";
            MySqlDataReader mySqlDataReader = null;
            string consulta = "SELECT * FROM trabajador WHERE usuario='" + txtUsuario.Text + "' && clave='" +txtClave.Text +"'";

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.getConexion();
            mySqlDataReader = mySqlCommand.ExecuteReader();
            if (mySqlDataReader.HasRows)
            {
                while (mySqlDataReader.Read())
                {
                    result = mySqlDataReader.GetString("nombre");
                    MessageBox.Show("Usuario correcto");
                }
            } else
            {
                MessageBox.Show("Las credenciales son incorrectas");
            }

            

            conexion.closeConexion();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


    }
}
