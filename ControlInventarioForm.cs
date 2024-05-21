using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Para SqlConnection y otros tipos relacionados
using System.Configuration; // Para ConfigurationManager

namespace GranjaLosCocos
{
    public partial class ControlInventarioForm : Form
    {
        public ControlInventarioForm()
        {
            InitializeComponent();
            conexion = new cConexion();
        }
        private cConexion conexion;


        private void ControlInventarioForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Lógica para generar el reporte basado en cmbTipoReporte
            string tipoReporte = cmbTipoReporte.SelectedItem.ToString();
            MessageBox.Show("Generando " + tipoReporte);

            string query = "";

            if (tipoReporte == "Reporte de produccion de huevos")
            {
                query = "SELECT * FROM produccion_de_huevos"; //  consulta según tu base de datos
            }
            else if (tipoReporte == "Reporte del inventario de cosechas")
            {
                query = "SELECT * FROM cultivo_de_frutas"; //   consulta según tu base de datos
            }
            else if (tipoReporte == "Reporte de salud de gallinas")
            {
                query = "SELECT * FROM control_vacunas"; //  consulta según tu base de datos
            }

            try
            {
                DataSet ds = conexion.buscar(query, "Reporte");
                dgvDatos.DataSource = ds.Tables["Reporte"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView
            dgvDatos.DataSource = null;
        }

        private void btnGallinas_Click(object sender, EventArgs e)
        {
            // Navegar al formulario GallinasForm
            GallinasForm gallinasForm = new GallinasForm();
            gallinasForm.Show();
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
    }
}
