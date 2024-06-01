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
    public partial class AdminProduccionDiariaForm : Form
    {
        private cConexion conexion;
        public AdminProduccionDiariaForm()
        {
            InitializeComponent();
            conexion = new cConexion();
            loadGaleras();
            loadTamanio();
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

        private void loadGaleras()
        {
            try
            {
                conexion.Open();
                string query = "SELECT id, nombre FROM galera";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbGalera.Items.Add(new ComboBoxItem { Text = reader["nombre"].ToString(), Value = Convert.ToInt32(reader["id"]) });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar galeras: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void loadTamanio()
        {
            try
            {
                conexion.Open();
                string query = "SELECT id, nombre FROM tamanio";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbTamanio.Items.Add(new ComboBoxItem { Text = reader["nombre"].ToString(), Value = Convert.ToInt32(reader["id"]) });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tamaños: " + ex.Message);
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
                string query = "SELECT * FROM produccion_de_huevos";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion.getConnection());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "produccion_de_huevos");
                dgvDatos.DataSource = ds.Tables["produccion_de_huevos"];
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


        private void btnCrear_Click(object sender, EventArgs e)
        {
            var galeraItem = cmbGalera.SelectedItem as ComboBoxItem;
            var tamanioItem = cmbTamanio.SelectedItem as ComboBoxItem;
            DateTime fechaRecoleccion = dtpFechaRecoleccion.Value;

            if (galeraItem == null || tamanioItem == null
                || string.IsNullOrEmpty(txtCantDiaria.Text) || string.IsNullOrEmpty(txtCant.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                conexion.Open();
                string query = "INSERT INTO produccion_de_huevos (ID_Galera, CantidadDiariaHuevos, CalidadHuevo, FechaRecoleccion, ID_Tamanio) VALUES (@idGalera, @cantidadDiaria, @cantidad, @fechaRecoleccion, @idTamanio)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                cmd.Parameters.AddWithValue("@idGalera", galeraItem.Value);
                cmd.Parameters.AddWithValue("@cantidadDiaria", txtCantDiaria.Text.Trim());
                cmd.Parameters.AddWithValue("@cantidad", txtCant.Text.Trim());
                cmd.Parameters.AddWithValue("@fechaRecoleccion", fechaRecoleccion);
                cmd.Parameters.AddWithValue("@idTamanio", tamanioItem.Value);
                cmd.ExecuteNonQuery();
                LoadData(); // Actualiza la vista de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la producción: " + ex.Message);
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

            var galeraItem = cmbGalera.SelectedItem as ComboBoxItem;
            var tamanioItem = cmbTamanio.SelectedItem as ComboBoxItem;
            DateTime fechaRecoleccion = dtpFechaRecoleccion.Value;

            if (galeraItem == null || tamanioItem == null
                || string.IsNullOrEmpty(txtCantDiaria.Text) || string.IsNullOrEmpty(txtCant.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            DataGridViewRow row = dgvDatos.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["ID_Produccion"].Value);

            try
            {
                conexion.Open();
                string query = "UPDATE produccion_de_huevos SET ID_Galera = @idGalera, CantidadDiariaHuevos = @cantidadDiaria, CalidadHuevo = @cantidad, FechaRecoleccion = @fechaRecoleccion, ID_Tamanio = @idTamanio WHERE ID_Produccion= @ID";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@idGalera", galeraItem.Value);
                cmd.Parameters.AddWithValue("@cantidadDiaria", txtCantDiaria.Text.Trim());
                cmd.Parameters.AddWithValue("@cantidad", txtCant.Text.Trim());
                cmd.Parameters.AddWithValue("@fechaRecoleccion", fechaRecoleccion);
                cmd.Parameters.AddWithValue("@idTamanio", tamanioItem.Value);
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la producción: " + ex.Message);
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
            int id = Convert.ToInt32(row.Cells["ID_Produccion"].Value);

            try
            {
                conexion.Open();
                string query = "DELETE FROM produccion_de_huevos WHERE ID_Produccion = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la : " + ex.Message);
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
                        FROM produccion_de_huevos 
                        WHERE ID_Galera LIKE @textoBusqueda 
                        OR ID_Tamanio LIKE @textoBusqueda 
                        OR CantidadDiariaHuevos LIKE @textoBusqueda 
                        OR CalidadHuevo LIKE @textoBusqueda";

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
                MessageBox.Show("Error al buscar producción: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
