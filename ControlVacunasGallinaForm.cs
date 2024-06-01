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
    public partial class ControlVacunasGallinaForm : Form
    {
        private cConexion conexion;

        public ControlVacunasGallinaForm()
        {
            InitializeComponent();
            conexion = new cConexion();
            LoadGallinaComboBox();
            LoadVacunaComboBox();
            LoadDosisComboBox();
            LoadData();
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void cmbVacuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem selectedVacuna = cmbVacuna.SelectedItem as ComboBoxItem;
        }

        private void LoadDosisComboBox()
        {
            List<ComboBoxItem> dosisItems = new List<ComboBoxItem>
            {
                new ComboBoxItem { Text = "Dosis: 0.1 ml a 0.5 ml por gallina", Value = 1 },
                new ComboBoxItem { Text = "Dosis: 0.2 ml a 0.5 ml por gallina", Value = 2 },
                new ComboBoxItem { Text = "Dosis: 0.01 ml a 0.1 ml por gallina", Value = 3 },
                new ComboBoxItem { Text = "Dosis: 0.1 ml a 0.2 ml por gallina", Value = 4 },
                new ComboBoxItem { Text = "Dosis: 0.5 ml por gallina", Value = 5 }
            };

            cmbDosis.DataSource = dosisItems;
            cmbDosis.DisplayMember = "Text";
            cmbDosis.ValueMember = "Value";
        }

        private void LoadGallinaComboBox()
        {
            try
            {
                conexion.Open();
                string query = "SELECT ID_Gallina, CONCAT('Gallina ', ID_Gallina) as Nombre FROM gallina";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbGallina.Items.Add(new ComboBoxItem { Text = reader["Nombre"].ToString(), Value = Convert.ToInt32(reader["ID_Gallina"]) });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar gallinas: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void LoadVacunaComboBox()
        {
            try
            {
                conexion.Open();
                string query = "SELECT ID_vacuna, Nombre_de_vacuna FROM vacunas";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbVacuna.Items.Add(new ComboBoxItem { Text = reader["Nombre_de_vacuna"].ToString(), Value = Convert.ToInt32(reader["ID_vacuna"]) });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vacunas: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var gallinaItem = cmbGallina.SelectedItem as ComboBoxItem;
            var vacunaItem = cmbVacuna.SelectedItem as ComboBoxItem;
            var dosisItem = cmbDosis.SelectedItem as ComboBoxItem;
            DateTime fecha = dtpFecha.Value;

            if (gallinaItem == null || vacunaItem == null || dosisItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                conexion.Open();
                string query = "INSERT INTO control_vacunas_por_gallina (Gallina_ID_Gallina, Vacunas_id, Fecha, Dosis) VALUES (@Gallina_ID_Gallina, @Vacunas_id, @Fecha, @Dosis)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                cmd.Parameters.AddWithValue("@Gallina_ID_Gallina", gallinaItem.Value);
                cmd.Parameters.AddWithValue("@Vacunas_id", vacunaItem.Value);
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@Dosis", dosisItem.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vacuna registrada exitosamente.");
                LoadData(); // Actualiza la vista de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la vacuna: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para actualizar.");
                return;
            }

            var gallinaItem = cmbGallina.SelectedItem as ComboBoxItem;
            var vacunaItem = cmbVacuna.SelectedItem as ComboBoxItem;
            var dosisItem = cmbDosis.SelectedItem as ComboBoxItem;
            DateTime fecha = dtpFecha.Value;

            if (gallinaItem == null || vacunaItem == null || dosisItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            DataGridViewRow row = dgvDatos.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["ID"].Value);

            try
            {
                conexion.Open();
                string query = "UPDATE control_vacunas_por_gallina SET Gallina_ID_Gallina = @Gallina_ID_Gallina, Vacunas_id = @Vacunas_id, Fecha = @Fecha, Dosis = @Dosis WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Gallina_ID_Gallina", gallinaItem.Value);
                cmd.Parameters.AddWithValue("@Vacunas_id", vacunaItem.Value);
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@Dosis", dosisItem.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vacuna actualizada exitosamente.");
                LoadData(); // Actualiza la vista de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la vacuna: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
                return;
            }

            DataGridViewRow row = dgvDatos.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["ID"].Value);

            try
            {
                conexion.Open();
                string query = "DELETE FROM control_vacunas_por_gallina WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vacuna eliminada exitosamente.");
                LoadData(); // Actualiza la vista de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la vacuna: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void LoadData()
        {
            try
            {
                conexion.Open();
                string query = "SELECT * FROM control_vacunas_por_gallina";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion.getConnection());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "control_vacunas_por_gallina");
                dgvDatos.DataSource = ds.Tables["control_vacunas_por_gallina"];
                dgvDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            // Navegar al formulario ControlInventarioForm
            ControlInventarioForm inventarioForm = new ControlInventarioForm();
            inventarioForm.Show();
            this.Hide(); // Ocultar el formulario actual
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
                        FROM control_vacunas_por_gallina 
                        WHERE Gallina_ID_Gallina LIKE @textoBusqueda 
                        OR Vacunas_id LIKE @textoBusqueda 
                        OR Fecha LIKE @textoBusqueda 
                        OR Dosis LIKE @textoBusqueda";

                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "control_vacunas_por_gallina");
                dgvDatos.DataSource = ds.Tables["control_vacunas_por_gallina"];
                dgvDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar vacunas: " + ex.Message);
            }
            finally
            {
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
