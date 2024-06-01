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
    public partial class AdminUsuarios : Form
    {
        private cConexion conexion;
        public AdminUsuarios()
        {
            InitializeComponent();
            conexion = new cConexion();
            loadRoles();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loadRoles()
        {
            try
            {
                conexion.Open();
                string query = "SELECT id, nombre FROM roles";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbRol.Items.Add(new ComboBoxItem { Text = reader["nombre"].ToString(), Value = Convert.ToInt32(reader["id"]) });
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

        private void LoadData()
        {
            try
            {
                conexion.Open();
                string query = "SELECT * FROM trabajador";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion.getConnection());
                DataSet ds = new DataSet();
                adapter.Fill(ds, "trabajador");
                dgvDatos.DataSource = ds.Tables["trabajador"];
                dgvDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                txtNombre.Text = "";
                txtUsuario.Text = "";
                txtClave.Text = "";
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
            var rolItem = cmbRol.SelectedItem as ComboBoxItem;

            if (rolItem == null || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                conexion.Open();
                string query = "INSERT INTO trabajador (Nombre, usuario, clave, Roles_id) VALUES (@nombre, @usuario, @clave, @rolId)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim());
                cmd.Parameters.AddWithValue("@clave", txtClave.Text.Trim());
                cmd.Parameters.AddWithValue("@rolId", rolItem.Value);
                cmd.ExecuteNonQuery();
                LoadData(); // Actualiza la vista de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
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

            var rolItem = cmbRol.SelectedItem as ComboBoxItem;

            if (rolItem == null || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            DataGridViewRow row = dgvDatos.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["ID_Trabajador"].Value);

            try
            {
                conexion.Open();
                string query = "UPDATE trabajador SET Nombre = @nombre, usuario = @usuario, clave = @clave, Roles_id = @rolId WHERE ID_Trabajador = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                cmd.Parameters.AddWithValue("@ID", id); 
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim());
                cmd.Parameters.AddWithValue("@clave", txtClave.Text.Trim());
                cmd.Parameters.AddWithValue("@rolId", rolItem.Value);
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
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
            int id = Convert.ToInt32(row.Cells["ID_Trabajador"].Value);

            try
            {
                conexion.Open();
                string query = "DELETE FROM trabajador WHERE ID_Trabajador = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
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
                        FROM trabajador 
                        WHERE Nombre LIKE @textoBusqueda 
                        OR usuario LIKE @textoBusqueda 
                        OR Roles_id LIKE @textoBusqueda";

                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConnection());
                cmd.Parameters.AddWithValue("@textoBusqueda", "%" + textoBusqueda + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "trabajador");
                dgvDatos.DataSource = ds.Tables["trabajador"];
                dgvDatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar usuarios: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
