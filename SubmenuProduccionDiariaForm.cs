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
    public partial class SubmenuProduccionDiariaForm : Form
    {
        public SubmenuProduccionDiariaForm()
        {
            InitializeComponent();
        }

        private void btnVacunas_Click(object sender, EventArgs e)
        {
            AdminCosechasForm cosechas = new AdminCosechasForm();
            cosechas.Show();
            this.Hide();
        }

        private void btnGallinasMain_Click(object sender, EventArgs e)
        {
            AdminProduccionDiariaForm produccion = new AdminProduccionDiariaForm();
            produccion.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdminProduccionDiariaForm produccion = new AdminProduccionDiariaForm();
            produccion.Show();
            this.Hide();
        }

        private void btnProduccionDiaria_Click(object sender, EventArgs e)
        {
            AdminGalerasForm galera = new AdminGalerasForm();
            galera.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminGalerasForm galera = new AdminGalerasForm();
            galera.Show();
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SubmenuUsuariosForm submenu = new SubmenuUsuariosForm();
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
