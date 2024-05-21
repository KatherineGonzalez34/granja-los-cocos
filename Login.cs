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
    public partial class Login : Form
    {
        private cConexion conexion;
        public Login()
        {
            InitializeComponent();
            conexion = new cConexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (conexion.iniciarSesion(txtUsuario.Text, txtClave.Text))
            {
                ControlInventarioForm inventarioForm = new ControlInventarioForm();
                inventarioForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Las credenciales son incorrectas");
            }
        }
    }
}
