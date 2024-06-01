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
            SubmenuUsuariosForm submenu = new SubmenuUsuariosForm();
            submenu.Show();
            this.Hide();
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

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ControlInventarioForm inventarioForm = new ControlInventarioForm();
            inventarioForm.Show();
            this.Hide();
        }

        private void btnGallinas_Click(object sender, EventArgs e)
        {
            GallinasForm gallinasForm = new GallinasForm();
            gallinasForm.Show();
            this.Hide();
        }

        private void btnCosechas_Click(object sender, EventArgs e)
        {
            AdminCosechasForm cosechas = new AdminCosechasForm();
            cosechas.Show();
            this.Hide();
        }

        private void btnProduccionDiaria_Click(object sender, EventArgs e)
        {
            SubmenuProduccionDiariaForm submenu = new SubmenuProduccionDiariaForm();
            submenu.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Confirmar cierre de sesión
            var result = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
