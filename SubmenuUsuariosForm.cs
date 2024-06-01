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
    public partial class SubmenuUsuariosForm : Form
    {
        public SubmenuUsuariosForm()
        {
            InitializeComponent();
        }

        private void btnVacunas_Click(object sender, EventArgs e)
        {
            AdminRolesForm roles = new AdminRolesForm();
            roles.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminRolesForm roles = new AdminRolesForm();
            roles.Show();
            this.Hide();
        }

        private void btnGallinasMain_Click(object sender, EventArgs e)
        {
            AdminUsuarios usuarios = new AdminUsuarios();
            usuarios.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdminUsuarios usuarios = new AdminUsuarios();
            usuarios.Show();
            this.Hide();
        }
    }
}
