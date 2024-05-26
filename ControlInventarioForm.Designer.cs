
namespace GranjaLosCocos
{
    partial class ControlInventarioForm
    {
       
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnGallinas;
        private System.Windows.Forms.Button btnCosechas;
        private System.Windows.Forms.Button btnProduccionDiaria;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCerrarSesion;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnGallinas = new System.Windows.Forms.Button();
            this.btnCosechas = new System.Windows.Forms.Button();
            this.btnProduccionDiaria = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(639, 27);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(349, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Controles de inventario";
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.AutoCompleteCustomSource.AddRange(new string[] {
            "Reporte inventario de cosechas",
            "Reporte inventario de produccion de huevos",
            "Reporte de salud de gallinas"});
            this.cmbTipoReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoReporte.FormattingEnabled = true;
            this.cmbTipoReporte.Items.AddRange(new object[] {
            "Reporte de produccion de huevos",
            "Reporte del inventario de cosechas",
            "Reporte de salud de gallinas"});
            this.cmbTipoReporte.Location = new System.Drawing.Point(765, 144);
            this.cmbTipoReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(393, 28);
            this.cmbTipoReporte.TabIndex = 1;
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReporte.Location = new System.Drawing.Point(556, 144);
            this.lblTipoReporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(151, 23);
            this.lblTipoReporte.TabIndex = 2;
            this.lblTipoReporte.Text = "Tipo de reporte:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(452, 241);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(140, 38);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(792, 241);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 38);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(1149, 241);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(140, 38);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(343, 346);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(1059, 402);
            this.dgvDatos.TabIndex = 6;
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
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(293, 802);
            this.panelMenu.TabIndex = 7;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Location = new System.Drawing.Point(39, 180);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(213, 37);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnGallinas
            // 
            this.btnGallinas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGallinas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGallinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGallinas.Location = new System.Drawing.Point(39, 264);
            this.btnGallinas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGallinas.Name = "btnGallinas";
            this.btnGallinas.Size = new System.Drawing.Size(213, 37);
            this.btnGallinas.TabIndex = 1;
            this.btnGallinas.Text = "Gallinas";
            this.btnGallinas.UseVisualStyleBackColor = false;
            this.btnGallinas.Click += new System.EventHandler(this.btnGallinas_Click);
            // 
            // btnCosechas
            // 
            this.btnCosechas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCosechas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCosechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosechas.Location = new System.Drawing.Point(39, 346);
            this.btnCosechas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCosechas.Name = "btnCosechas";
            this.btnCosechas.Size = new System.Drawing.Size(213, 37);
            this.btnCosechas.TabIndex = 2;
            this.btnCosechas.Text = "Cosechas";
            this.btnCosechas.UseVisualStyleBackColor = false;
            // 
            // btnProduccionDiaria
            // 
            this.btnProduccionDiaria.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProduccionDiaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProduccionDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduccionDiaria.Location = new System.Drawing.Point(39, 423);
            this.btnProduccionDiaria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProduccionDiaria.Name = "btnProduccionDiaria";
            this.btnProduccionDiaria.Size = new System.Drawing.Size(213, 37);
            this.btnProduccionDiaria.TabIndex = 3;
            this.btnProduccionDiaria.Text = "Producción diaria";
            this.btnProduccionDiaria.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(39, 508);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(213, 37);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(39, 724);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(213, 37);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GranjaLosCocos.Properties.Resources.Screenshot_cocos;
            this.pictureBox1.Location = new System.Drawing.Point(56, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ControlInventarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 796);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblTipoReporte);
            this.Controls.Add(this.cmbTipoReporte);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ControlInventarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}