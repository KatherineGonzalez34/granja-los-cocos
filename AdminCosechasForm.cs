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
    public partial class AdminCosechasForm : Form
    {
        public AdminCosechasForm()
        {
            InitializeComponent();
        }

        private void btnProduccionDiaria_Click(object sender, EventArgs e)
        {
            SubmenuProduccionDiariaForm submenu = new SubmenuProduccionDiariaForm();
            submenu.Show();
            this.Hide();
        }
    }
}
