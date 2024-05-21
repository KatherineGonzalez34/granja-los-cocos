﻿
namespace GranjaLosCocos
{
    partial class GallinasAdminForm
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
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvDatos;

        /// <param name="disposing">true si managed resources should be disposed; otherwise, false.</param>
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
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnGallinas);
            this.panelMenu.Controls.Add(this.btnCosechas);
            this.panelMenu.Controls.Add(this.btnProduccionDiaria);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 570);
            this.panelMenu.TabIndex = 0;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnInventario.Location = new System.Drawing.Point(20, 50);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(160, 30);
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
            this.btnGallinas.Location = new System.Drawing.Point(20, 100);
            this.btnGallinas.Name = "btnGallinas";
            this.btnGallinas.Size = new System.Drawing.Size(160, 30);
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
            this.btnCosechas.Location = new System.Drawing.Point(20, 150);
            this.btnCosechas.Name = "btnCosechas";
            this.btnCosechas.Size = new System.Drawing.Size(160, 30);
            this.btnCosechas.TabIndex = 3;
            this.btnCosechas.Text = "Cosechas";
            this.btnCosechas.UseVisualStyleBackColor = false;
            // 
            // btnProduccionDiaria
            // 
            this.btnProduccionDiaria.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProduccionDiaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProduccionDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnProduccionDiaria.Location = new System.Drawing.Point(20, 200);
            this.btnProduccionDiaria.Name = "btnProduccionDiaria";
            this.btnProduccionDiaria.Size = new System.Drawing.Size(160, 30);
            this.btnProduccionDiaria.TabIndex = 4;
            this.btnProduccionDiaria.Text = "Producción diaria";
            this.btnProduccionDiaria.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.Location = new System.Drawing.Point(20, 250);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(160, 30);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.Location = new System.Drawing.Point(20, 500);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(160, 30);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(464, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(393, 35);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Administración de gallinas";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Arial", 12F);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(386, 76);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(169, 23);
            this.lblFechaNacimiento.TabIndex = 2;
            this.lblFechaNacimiento.Text = "Fecha nacimiento:";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Arial", 12F);
            this.lblRaza.Location = new System.Drawing.Point(492, 118);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(61, 23);
            this.lblRaza.TabIndex = 3;
            this.lblRaza.Text = "Raza:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(567, 75);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(295, 24);
            this.dtpFechaNacimiento.TabIndex = 4;
            // 
            // cmbRaza
            // 
            this.cmbRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Items.AddRange(new object[] {
            "Leghorn",
            "Rhode Island Red",
            "Plymouth Rock (Barred Rock)",
            "Sussex",
            "Australorp",
            "Isa Brown",
            "Ancona",
            "Minorca",
            "Golden Comet",
            "Marans",
            "Andalusian",
            "New Hampshire",
            "Hamburg",
            "Welsummer",
            "Bovan Brown"});
            this.cmbRaza.Location = new System.Drawing.Point(567, 118);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(295, 26);
            this.cmbRaza.TabIndex = 5;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCrear.Location = new System.Drawing.Point(327, 162);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(141, 33);
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
            this.btnActualizar.Location = new System.Drawing.Point(567, 162);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(141, 33);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(774, 162);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 33);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtBuscar.Location = new System.Drawing.Point(339, 233);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(540, 27);
            this.txtBuscar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(921, 228);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 32);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(239, 279);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(786, 255);
            this.dgvDatos.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(257, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar:";
            // 
            // GallinasAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.cmbRaza);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblTitulo);
            this.Name = "GallinasAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de gallinas";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}