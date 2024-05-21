﻿using System;
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
    public partial class GallinasForm : Form
    {
        public GallinasForm()
        {
            InitializeComponent();
        }

        private void GallinasForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGallinas_Click(object sender, EventArgs e)
        {
            // Navegar al formulario GallinasAdminForm
            GallinasAdminForm gallinasForm = new GallinasAdminForm();
            gallinasForm.Show();
            this.Hide(); // Ocultar el formulario actual
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            // Navegar al formulario ControlInventarioForm
            ControlInventarioForm inventarioForm = new ControlInventarioForm();
            inventarioForm.Show();
            this.Hide(); // Ocultar el formulario actual
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Confirmar cierre de sesión
            var result = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cerrar la aplicación
            }
        }

        private void btnVacunas_Click(object sender, EventArgs e)
        {

        }

        private void btnControl_Click(object sender, EventArgs e)
        {

        }
    }
}
