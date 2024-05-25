using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GranjaLosCocos
{
    public partial class VacunasAdminForm : Form
    {
        private cConexion conexion;

        public VacunasAdminForm()
        {
            InitializeComponent();
            conexion = new cConexion();
            CargarDatos();

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ControlInventarioForm inventarioForm = new ControlInventarioForm();
            inventarioForm.Show();
            this.Hide();
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
            var result = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombreVacuna = cmbNombreVacuna.Text;
            string tipoVacuna = cmbTipoVacuna.Text;
            DateTime fechaUso = dtpFechaUso.Value;

            if (string.IsNullOrEmpty(nombreVacuna) || string.IsNullOrEmpty(tipoVacuna))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;persistsecurityinfo=True;database=granja_cocos"))
                {
                    conn.Open();
                    string query = "INSERT INTO vacunas (Nombre_de_vacuna, Tipo_vacuna, FechaUso) VALUES (@Nombre_de_vacuna, @Tipo_vacuna, @FechaUso)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre_de_vacuna", nombreVacuna);
                        cmd.Parameters.AddWithValue("@Tipo_vacuna", tipoVacuna);
                        cmd.Parameters.AddWithValue("@FechaUso", fechaUso);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Vacuna creada exitosamente.");
                CargarDatos(); // Actualiza la vista de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la vacuna: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una vacuna para actualizar.");
                return;
            }

            DataGridViewRow row = dgvDatos.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["ID"].Value);
            string nombreVacuna = cmbNombreVacuna.Text;
            string tipoVacuna = cmbTipoVacuna.Text;
            DateTime fechaUso = dtpFechaUso.Value;

            if (string.IsNullOrEmpty(nombreVacuna) || string.IsNullOrEmpty(tipoVacuna))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                string query = "UPDATE vacunas SET Nombre_de_vacuna=@Nombre_de_vacuna, Tipo_vacuna=@Tipo_vacuna, FechaUso=@FechaUso WHERE ID_vacuna=@ID_vacuna";
                using (MySqlConnection conn = conexion.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_vacuna", id);
                    cmd.Parameters.AddWithValue("@Nombre_de_vacuna", nombreVacuna);
                    cmd.Parameters.AddWithValue("@Tipo_vacuna", tipoVacuna);
                    cmd.Parameters.AddWithValue("@FechaUso", fechaUso);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Vacuna actualizada exitosamente.");
                CargarDatos(); // Actualiza la vista de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la vacuna: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una vacuna para eliminar.");
                return;
            }

            DataGridViewRow row = dgvDatos.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["ID"].Value);

            try
            {
                string query = "DELETE FROM vacunas WHERE ID=@ID";
                using (MySqlConnection conn = conexion.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Vacuna eliminada exitosamente.");
                CargarDatos(); // Actualiza la vista de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la vacuna: " + ex.Message);
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
                string query = @"
            SELECT * 
            FROM vacunas 
            WHERE Nombre_de_vacuna LIKE @textoBusqueda 
            OR Tipo_vacuna LIKE @textoBusqueda 
            OR FechaUso LIKE @textoBusqueda";

                using (MySqlConnection conn = conexion.getConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "vacunas");
                    dgvDatos.DataSource = ds.Tables["vacunas"];
                    dgvDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar vacunas: " + ex.Message);
            }
        }

        private void CargarDatos()
        {
            try
            {
                string query = "SELECT ID_vacuna, Nombre_de_vacuna, Tipo_vacuna, FechaUso FROM vacunas";
                using (MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;persistsecurityinfo=True;database=granja_cocos"))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "vacunas");
                        dgvDatos.DataSource = ds.Tables["vacunas"];
                        dgvDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }


        private void VacunasAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una vacuna para actualizar.");
                return;
            }

            DataGridViewRow row = dgvDatos.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["ID_vacuna"].Value);
            string nombreVacuna = cmbNombreVacuna.Text;
            string tipoVacuna = cmbTipoVacuna.Text;
            DateTime fechaUso = dtpFechaUso.Value;

            if (string.IsNullOrEmpty(nombreVacuna) || string.IsNullOrEmpty(tipoVacuna))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;persistsecurityinfo=True;database=granja_cocos"))
                {
                    conn.Open();
                    string query = "UPDATE vacunas SET Nombre_de_vacuna=@Nombre_de_vacuna, Tipo_vacuna=@Tipo_vacuna, FechaUso=@FechaUso WHERE ID_vacuna=@ID_vacuna";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_vacuna", id);
                        cmd.Parameters.AddWithValue("@Nombre_de_vacuna", nombreVacuna);
                        cmd.Parameters.AddWithValue("@Tipo_vacuna", tipoVacuna);
                        cmd.Parameters.AddWithValue("@FechaUso", fechaUso);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Vacuna actualizada exitosamente.");
                CargarDatos(); // Actualiza la vista de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la vacuna: " + ex.Message);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una vacuna para eliminar.");
                return;
            }

            DataGridViewRow row = dgvDatos.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["ID_vacuna"].Value);

            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;persistsecurityinfo=True;database=granja_cocos"))
                {
                    conn.Open();
                    string query = "DELETE FROM vacunas WHERE ID_vacuna=@ID_vacuna";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID_vacuna", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Vacuna eliminada exitosamente.");
                CargarDatos(); // Actualiza la vista de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la vacuna: " + ex.Message);
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
            FROM vacunas 
            WHERE Nombre_de_vacuna LIKE @textoBusqueda 
            OR Tipo_vacuna LIKE @textoBusqueda 
            OR FechaUso LIKE @textoBusqueda";

                using (MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=;persistsecurityinfo=True;database=granja_cocos"))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "vacunas");
                        dgvDatos.DataSource = ds.Tables["vacunas"];
                        dgvDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar vacunas: " + ex.Message);
            }
        }
    }
}
