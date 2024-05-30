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
            AdminGalerasForm galera = new AdminGalerasForm();
            galera.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdminGalerasForm galera = new AdminGalerasForm();
            galera.Show();
            this.Hide();
        }

        private void btnProduccionDiaria_Click(object sender, EventArgs e)
        {
            SubmenuProduccionDiariaForm submenu = new SubmenuProduccionDiariaForm();
            submenu.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminCosechasForm cosechas = new AdminCosechasForm();
            cosechas.Show();
            this.Hide();
        }
    }
}
