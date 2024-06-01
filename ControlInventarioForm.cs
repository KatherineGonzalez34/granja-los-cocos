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
using System.Drawing.Printing;

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
                query = "SELECT * FROM control_vacunas_por_gallina"; //  consulta según tu base de datos
            }

            try
            {
                DataSet ds = conexion.buscar(query, "Reporte");
                dgvDatos.DataSource = ds.Tables["Reporte"];
                dgvDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvDatos.Width, this.dgvDatos.Height);
            dgvDatos.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvDatos.Width, this.dgvDatos.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnProduccionDiaria_Click(object sender, EventArgs e)
        {
            SubmenuProduccionDiariaForm submenu = new SubmenuProduccionDiariaForm();
            submenu.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SubmenuUsuariosForm submenu = new SubmenuUsuariosForm();
            submenu.Show();
            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ControlInventarioForm inventarioForm = new ControlInventarioForm();
            inventarioForm.Show();
            this.Hide();
        }

        private void btnCosechas_Click(object sender, EventArgs e)
        {
            AdminCosechasForm cosechas = new AdminCosechasForm();
            cosechas.Show();
            this.Hide();
        }
    }
}
