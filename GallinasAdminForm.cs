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
    public partial class GallinasAdminForm : Form
    {
        private cConexion conexion;

        public GallinasAdminForm()
        {
            InitializeComponent();
            conexion = new cConexion();
            CargarDatos(); // Carga inicial de datos
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ControlInventarioForm controlInventarioForm = new ControlInventarioForm();
            controlInventarioForm.Show();
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string fechaNacimiento = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd");
            string raza = cmbRaza.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(fechaNacimiento) || string.IsNullOrEmpty(raza))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                int razaId = conexion.ObtenerIdRaza(raza);
                if (razaId == -1)
                {
                    MessageBox.Show("La raza seleccionada no es válida.");
                    return;
                }

                string query = $"INSERT INTO GALLINA (FechaNacimiento, raza_gallina_id, Raza) VALUES ('{fechaNacimiento}', {razaId}, '{raza}')";
                conexion.operacion(query);
                MessageBox.Show("Gallina creada exitosamente.");
                CargarDatos(); // Actualiza la vista de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la gallina: " + ex.Message);
            }
        }

        private void CargarDatos()
        {
            try
            {
                string query = "SELECT ID_Gallina, FechaNacimiento, Raza, raza_gallina_id FROM GALLINA";
                DataSet ds = conexion.buscar(query, "GALLINA");
                dgvDatos.DataSource = ds.Tables["GALLINA"];
                dgvDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void btnGallinas_Click(object sender, EventArgs e)
        {
            // Navegar al formulario GallinasForm
            GallinasForm gallinasForm = new GallinasForm();
            gallinasForm.Show();
            this.Hide(); // Ocultar el formulario actual
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una gallina para actualizar.");
                return;
            }

            DataGridViewRow row = dgvDatos.SelectedRows[0];
            if (row.Cells["ID_Gallina"] == null)
            {
                MessageBox.Show("No se encontró la columna ID_Gallina.");
                return;
            }

            int id = Convert.ToInt32(row.Cells["ID_Gallina"].Value);
            string fechaNacimiento = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd");
            string raza = cmbRaza.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(fechaNacimiento) || string.IsNullOrEmpty(raza))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                int razaId = conexion.ObtenerIdRaza(raza);
                if (razaId == -1)
                {
                    MessageBox.Show("La raza seleccionada no es válida.");
                    return;
                }

                string query = $"UPDATE GALLINA SET FechaNacimiento='{fechaNacimiento}', raza_gallina_id={razaId}, Raza='{raza}' WHERE ID_Gallina={id}";
                conexion.operacion(query);
                MessageBox.Show("Gallina actualizada exitosamente.");
                CargarDatos(); // Actualiza la vista de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la gallina: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una gallina para eliminar.");
                return;
            }

            DataGridViewRow row = dgvDatos.SelectedRows[0];
            if (row.Cells["ID_Gallina"] == null)
            {
                MessageBox.Show("No se encontró la columna ID_Gallina.");
                return;
            }

            int id = Convert.ToInt32(row.Cells["ID_Gallina"].Value);

            try
            {
                conexion.Open();

                // Eliminar las filas relacionadas en la tabla control_vacunas_por_gallina
                string deleteRelatedQuery = "DELETE FROM control_vacunas_por_gallina WHERE Gallina_ID_Gallina = @Gallina_ID_Gallina";
                MySqlCommand cmd = new MySqlCommand(deleteRelatedQuery, conexion.getConnection());
                cmd.Parameters.AddWithValue("@Gallina_ID_Gallina", id);
                cmd.ExecuteNonQuery();

                // Luego eliminar la gallina
                string deleteQuery = "DELETE FROM gallina WHERE ID_Gallina = @ID_Gallina";
                cmd.CommandText = deleteQuery;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Gallina", id);
                cmd.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Gallina eliminada exitosamente.");
                CargarDatos(); // Actualiza la vista de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la gallina: " + ex.Message);
                conexion.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                MessageBox.Show("Por favor, ingrese un término de búsqueda.");
                return;
            }

            try
            {
                string query;
                DateTime fechaBusqueda;

                // Verificar si el texto de búsqueda puede ser una fecha
                if (DateTime.TryParse(textoBusqueda, out fechaBusqueda))
                {
                    // Formatear la fecha para coincidir con el formato de MySQL
                    string fechaFormateada = fechaBusqueda.ToString("yyyy-MM-dd");
                    query = @"
                SELECT * 
                FROM gallina 
                WHERE FechaNacimiento = @fechaFormateada";
                }
                else
                {
                    // Buscar por Raza
                    query = @"
                SELECT * 
                FROM gallina 
                WHERE Raza LIKE @textoBusqueda";
                }

                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                if (DateTime.TryParse(textoBusqueda, out fechaBusqueda))
                {
                    cmd.Parameters.AddWithValue("@fechaFormateada", fechaBusqueda.ToString("yyyy-MM-dd"));
                }
                else
                {
                    cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "gallina");
                dgvDatos.DataSource = ds.Tables["gallina"];
                dgvDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar gallinas: " + ex.Message);
                conexion.Close();
            }
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SubmenuUsuariosForm submenu = new SubmenuUsuariosForm();
            submenu.Show();
            this.Hide();
        }
    }
}
