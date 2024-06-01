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
    public partial class AdminCosechasForm : Form
    {
        private cConexion conexion;
        public AdminCosechasForm()
        {
            InitializeComponent();
            conexion = new cConexion();
            loadTiposFruta();
            loadFertilizantes();
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var tipoFrutaItem = cmbTipoFruta.SelectedItem as ComboBoxItem;
            var fertilizanteItem = cmbFertilizante.SelectedItem as ComboBoxItem;
            DateTime fechaCosecha = dtpFechaCosecha.Value;
            DateTime fechaSiembra = dtpFechaSiembra.Value;

            if (tipoFrutaItem == null || fertilizanteItem == null 
                || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                conexion.Open();
                string query = "INSERT INTO cultivo_de_frutas (Tipo_fruta_id, CantidadCosechada, FechaSiembra, FechaCosecha, Fertilizante_id) VALUES (@tipoFrutaId, @cantidadCosechada, @fechaSiembra, @fechaCosecha, @fertilizanteId)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                cmd.Parameters.AddWithValue("@tipoFrutaId", tipoFrutaItem.Value);
                cmd.Parameters.AddWithValue("@cantidadCosechada", txtCantidad.Text.Trim());
                cmd.Parameters.AddWithValue("@fechaSiembra", fechaSiembra);
                cmd.Parameters.AddWithValue("@fechaCosecha", fechaCosecha);
                cmd.Parameters.AddWithValue("@fertilizanteId", fertilizanteItem.Value);
                cmd.ExecuteNonQuery();
                LoadData(); // Actualiza la vista de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la cosecha: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void cmbTipoFruta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadTiposFruta()
        {
            try
            {
                conexion.Open();
                string query = "SELECT id, nombre FROM tipo_frutas";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbTipoFruta.Items.Add(new ComboBoxItem { Text = reader["nombre"].ToString(), Value = Convert.ToInt32(reader["id"]) });
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

        private void loadFertilizantes()
        {
            try
            {
                conexion.Open();
                string query = "SELECT id, nombre FROM fertilizante";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbFertilizante.Items.Add(new ComboBoxItem { Text = reader["nombre"].ToString(), Value = Convert.ToInt32(reader["id"]) });
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

        private void btnCosechas_Click(object sender, EventArgs e)
        {
            AdminCosechasForm cosechas = new AdminCosechasForm();
            cosechas.Show();
            this.Hide();
        }

        private void LoadData()
        {
            try
            {
                conexion.Open();
                string query = "SELECT * FROM cultivo_de_frutas";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion.getConnection());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "cultivo_de_frutas");
                dgvDatos.DataSource = ds.Tables["cultivo_de_frutas"];
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para actualizar.");
                return;
            }

            var tipoFrutaItem = cmbTipoFruta.SelectedItem as ComboBoxItem;
            var fertilizanteItem = cmbFertilizante.SelectedItem as ComboBoxItem;
            DateTime fechaCosecha = dtpFechaCosecha.Value;
            DateTime fechaSiembra = dtpFechaSiembra.Value;

            if (tipoFrutaItem == null || fertilizanteItem == null
                || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            DataGridViewRow row = dgvDatos.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["ID_Cultivo"].Value);

            try
            {
                conexion.Open();
                string query = "UPDATE cultivo_de_frutas SET Tipo_fruta_id = @tipoFrutaId, CantidadCosechada = @cantidadCosechada, FechaSiembra = @fechaSiembra, FechaSiembra = @fechaCosecha, Fertilizante_id = @fertilizanteId WHERE ID_Cultivo = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@tipoFrutaId", tipoFrutaItem.Value);
                cmd.Parameters.AddWithValue("@cantidadCosechada", txtCantidad.Text.Trim());
                cmd.Parameters.AddWithValue("@fechaSiembra", fechaSiembra);
                cmd.Parameters.AddWithValue("@fechaCosecha", fechaCosecha);
                cmd.Parameters.AddWithValue("@fertilizanteId", fertilizanteItem.Value);
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la cosecha: " + ex.Message);
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
            int id = Convert.ToInt32(row.Cells["ID_Cultivo"].Value);

            try
            {
                conexion.Open();
                string query = "DELETE FROM cultivo_de_frutas WHERE ID_Cultivo = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la cosecha: " + ex.Message);
            }
            finally
            {
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
                string query = @"
                        SELECT * 
                        FROM cultivo_de_frutas 
                        WHERE Tipo_fruta_id LIKE @textoBusqueda 
                        OR Fertilizante_id LIKE @textoBusqueda 
                        OR CantidadCosechada LIKE @textoBusqueda";

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
    }
}
