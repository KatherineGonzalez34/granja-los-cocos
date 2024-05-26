
namespace GranjaLosCocos
{
    partial class VacunasAdminForm
    {

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnGallinas;
        private System.Windows.Forms.Button btnCosechas;
        private System.Windows.Forms.Button btnProduccionDiaria;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvDatos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnGallinas = new System.Windows.Forms.Button();
            this.btnCosechas = new System.Windows.Forms.Button();
            this.btnProduccionDiaria = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaUso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.cmbTipoVacuna = new System.Windows.Forms.ComboBox();
            this.cmbNombreVacuna = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnGallinas);
            this.panelMenu.Controls.Add(this.btnCosechas);
            this.panelMenu.Controls.Add(this.btnProduccionDiaria);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(297, 784);
            this.panelMenu.TabIndex = 0;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnInventario.Location = new System.Drawing.Point(42, 153);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(213, 41);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnGallinas
            // 
            this.btnGallinas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGallinas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGallinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGallinas.Location = new System.Drawing.Point(42, 248);
            this.btnGallinas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGallinas.Name = "btnGallinas";
            this.btnGallinas.Size = new System.Drawing.Size(213, 41);
            this.btnGallinas.TabIndex = 2;
            this.btnGallinas.Text = "Gallinas";
            this.btnGallinas.UseVisualStyleBackColor = false;
            this.btnGallinas.Click += new System.EventHandler(this.btnGallinas_Click);
            // 
            // btnCosechas
            // 
            this.btnCosechas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCosechas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCosechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCosechas.Location = new System.Drawing.Point(42, 330);
            this.btnCosechas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCosechas.Name = "btnCosechas";
            this.btnCosechas.Size = new System.Drawing.Size(213, 41);
            this.btnCosechas.TabIndex = 3;
            this.btnCosechas.Text = "Cosechas";
            this.btnCosechas.UseVisualStyleBackColor = false;
            // 
            // btnProduccionDiaria
            // 
            this.btnProduccionDiaria.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProduccionDiaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProduccionDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnProduccionDiaria.Location = new System.Drawing.Point(42, 419);
            this.btnProduccionDiaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduccionDiaria.Name = "btnProduccionDiaria";
            this.btnProduccionDiaria.Size = new System.Drawing.Size(213, 41);
            this.btnProduccionDiaria.TabIndex = 4;
            this.btnProduccionDiaria.Text = "Producción diaria";
            this.btnProduccionDiaria.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.Location = new System.Drawing.Point(42, 502);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(213, 41);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.Location = new System.Drawing.Point(42, 709);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(213, 41);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(619, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(403, 35);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Administración de vacunas";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F);
            this.lblNombre.Location = new System.Drawing.Point(467, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(180, 23);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre de vacuna:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTipo.Location = new System.Drawing.Point(509, 143);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(148, 23);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo de vacuna:";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCrear.Location = new System.Drawing.Point(472, 273);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(188, 41);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Location = new System.Drawing.Point(792, 273);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(188, 41);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(1068, 273);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 41);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(395, 358);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(831, 27);
            this.txtBuscar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(1259, 358);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 39);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(349, 450);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(1048, 309);
            this.dgvDatos.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 400);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar por nombre de vacuna, tipo de Vacuna o fecha de uso (yyyy-mm-dd)";
            // 
            // dtpFechaUso
            // 
            this.dtpFechaUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpFechaUso.Location = new System.Drawing.Point(717, 192);
            this.dtpFechaUso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaUso.Name = "dtpFechaUso";
            this.dtpFechaUso.Size = new System.Drawing.Size(392, 24);
            this.dtpFechaUso.TabIndex = 14;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Arial", 12F);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(527, 192);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(135, 23);
            this.lblFechaNacimiento.TabIndex = 13;
            this.lblFechaNacimiento.Text = "Fecha de uso:";
            // 
            // cmbTipoVacuna
            // 
            this.cmbTipoVacuna.AutoCompleteCustomSource.AddRange(new string[] {
            "Vacuna contra la enfermedad de Newcastle (ND)",
            "Vacuna contra la bronquitis infecciosa aviar (IB)",
            "Vacuna contra la enfermedad de Marek (MD)",
            "Vacuna contra la coccidiosis",
            "Vacuna contra la enfermedad de Gumboro (IBD)",
            "Vacuna contra la laringotraqueítis infecciosa (ILT)",
            "Vacuna contra la salmonelosis",
            "Vacuna contra el metapneumovirus aviar (AMPV)"});
            this.cmbTipoVacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoVacuna.FormattingEnabled = true;
            this.cmbTipoVacuna.Items.AddRange(new object[] {
            "Vacuna contra la enfermedad de Newcastle (ND)",
            "Vacuna contra la bronquitis infecciosa aviar (IB)",
            "Vacuna contra la enfermedad de Marek (MD)",
            "Vacuna contra la coccidiosis",
            "Vacuna contra la enfermedad de Gumboro (IBD)",
            "Vacuna contra la laringotraqueítis infecciosa (ILT)",
            "Vacuna contra la salmonelosis",
            "Vacuna contra el metapneumovirus aviar (AMPV)"});
            this.cmbTipoVacuna.Location = new System.Drawing.Point(717, 143);
            this.cmbTipoVacuna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoVacuna.Name = "cmbTipoVacuna";
            this.cmbTipoVacuna.Size = new System.Drawing.Size(392, 26);
            this.cmbTipoVacuna.TabIndex = 15;
            // 
            // cmbNombreVacuna
            // 
            this.cmbNombreVacuna.AutoCompleteCustomSource.AddRange(new string[] {
            "Lasota",
            "Hitchner B1",
            "H120",
            "Ma5",
            "CVI988/Rispens",
            "HVT (Virus de la enfermedad de herpes del pavo)",
            "Coccivac-D",
            "Paracox-8",
            "Bursa-Vac",
            "Vaxxitek HVT+IBD",
            "CEO (Chicken Embryo Origin)",
            "TCO (Tissue Culture Origin)",
            "Salmovac SE",
            "AviPro Salmonella Duo",
            "Nobilis Rhino CV"});
            this.cmbNombreVacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombreVacuna.FormattingEnabled = true;
            this.cmbNombreVacuna.Items.AddRange(new object[] {
            "Lasota",
            "Hitchner B1",
            "H120",
            "Ma5",
            "CVI988/Rispens",
            "HVT (Virus de la enfermedad de herpes del pavo)",
            "Coccivac-D",
            "Paracox-8",
            "Bursa-Vac",
            "Vaxxitek HVT+IBD",
            "CEO (Chicken Embryo Origin)",
            "TCO (Tissue Culture Origin)",
            "Salmovac SE",
            "AviPro Salmonella Duo",
            "Nobilis Rhino CV"});
            this.cmbNombreVacuna.Location = new System.Drawing.Point(717, 97);
            this.cmbNombreVacuna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNombreVacuna.Name = "cmbNombreVacuna";
            this.cmbNombreVacuna.Size = new System.Drawing.Size(392, 26);
            this.cmbNombreVacuna.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GranjaLosCocos.Properties.Resources.Screenshot_cocos;
            this.pictureBox1.Location = new System.Drawing.Point(55, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // VacunasAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 785);
            this.Controls.Add(this.cmbNombreVacuna);
            this.Controls.Add(this.cmbTipoVacuna);
            this.Controls.Add(this.dtpFechaUso);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VacunasAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de vacunas";
            this.Load += new System.EventHandler(this.VacunasAdminForm_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaUso;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbTipoVacuna;
        private System.Windows.Forms.ComboBox cmbNombreVacuna;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}