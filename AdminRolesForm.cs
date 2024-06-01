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
    public partial class AdminRolesForm : Form
    {

        private cConexion conexion;
        public AdminRolesForm()
        {
            InitializeComponent();
            conexion = new cConexion();
            cargarDatos();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SubmenuUsuariosForm submenu = new SubmenuUsuariosForm();
            submenu.Show();
            this.Hide();
        }

        private void btnProduccionDiaria_Click(object sender, EventArgs e)
        {
            SubmenuProduccionDiariaForm submenu = new SubmenuProduccionDiariaForm();
            submenu.Show();
            this.Hide();
        }

        private void cargarDatos()
        {
            try
            {
                string query = "SELECT * FROM roles";
                DataSet ds = conexion.buscar(query, "roles");
                dgvDatos.DataSource = ds.Tables["roles"];
                dgvDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                string query = $"INSERT INTO roles (nombre, descripcion) VALUES ('{txtNombre.Text}', '{txtDescripcion.Text}')";
                conexion.operacion(query);
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                cargarDatos(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el rol: " + ex.Message);
            }
        }


        private void AdminRolesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un rol para actualizar.");
                return;
            }

            DataGridViewRow row = dgvDatos.SelectedRows[0];
            if (row.Cells["id"] == null)
            {
                MessageBox.Show("No se encontró la columna id.");
                return;
            }

            int id = Convert.ToInt32(row.Cells["id"].Value);

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {

                string query = $"UPDATE roles SET nombre='{txtNombre.Text}' WHERE id={id}";
                conexion.operacion(query);
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la rol: " + ex.Message);
            }
            cargarDatos();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un rol para eliminar.");
                return;
            }

            DataGridViewRow row = dgvDatos.SelectedRows[0];
            if (row.Cells["id"] == null)
            {
                MessageBox.Show("No se encontró la columna id.");
                return;
            }

            int id = Convert.ToInt32(row.Cells["id"].Value);

            try
            {
                string query = $"DELETE FROM roles WHERE id={id}";
                conexion.operacion(query);
                cargarDatos(); // Actualiza la vista de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el rol: " + ex.Message);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                MessageBox.Show("Por favor, ingrese un término de búsqueda.");
                return;
            }

            try
            {
                string query = @"
                        SELECT * 
                        FROM roles 
                        WHERE nombre LIKE @textoBusqueda";

                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "roles");
                dgvDatos.DataSource = ds.Tables["roles"];
                dgvDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar roles: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
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
