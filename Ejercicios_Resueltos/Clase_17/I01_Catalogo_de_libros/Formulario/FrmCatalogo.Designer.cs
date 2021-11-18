
namespace Formulario
{
    partial class FrmCatalogo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.cmbPlataforma = new System.Windows.Forms.ComboBox();
            this.lblPlataforma = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblMaximoCantCapitulos = new System.Windows.Forms.Label();
            this.nudMaximoCantCapitulos = new System.Windows.Forms.NumericUpDown();
            this.lblMinimoCantCapitulos = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.nudMinimoCantCapitulos = new System.Windows.Forms.NumericUpDown();
            this.lblCantCapitulos = new System.Windows.Forms.Label();
            this.chkFinalizada = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblFechaEstrenoHasta = new System.Windows.Forms.Label();
            this.dtpFechaEstrenoHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.lblFechaEstrenoDesde = new System.Windows.Forms.Label();
            this.dtpFechaEstrenoDesde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximoCantCapitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimoCantCapitulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.AllowUserToAddRows = false;
            this.dgvCatalogo.AllowUserToDeleteRows = false;
            this.dgvCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogo.Location = new System.Drawing.Point(0, 171);
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.ReadOnly = true;
            this.dgvCatalogo.RowTemplate.Height = 25;
            this.dgvCatalogo.Size = new System.Drawing.Size(967, 391);
            this.dgvCatalogo.TabIndex = 0;
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFiltros.Location = new System.Drawing.Point(18, 9);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(67, 25);
            this.lblFiltros.TabIndex = 0;
            this.lblFiltros.Text = "Filtros";
            // 
            // cmbPlataforma
            // 
            this.cmbPlataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlataforma.FormattingEnabled = true;
            this.cmbPlataforma.Location = new System.Drawing.Point(109, 57);
            this.cmbPlataforma.Name = "cmbPlataforma";
            this.cmbPlataforma.Size = new System.Drawing.Size(145, 23);
            this.cmbPlataforma.TabIndex = 2;
            // 
            // lblPlataforma
            // 
            this.lblPlataforma.AutoSize = true;
            this.lblPlataforma.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlataforma.Location = new System.Drawing.Point(22, 58);
            this.lblPlataforma.Name = "lblPlataforma";
            this.lblPlataforma.Size = new System.Drawing.Size(80, 17);
            this.lblPlataforma.TabIndex = 3;
            this.lblPlataforma.Text = "Plataforma:";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFiltros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFiltros.Controls.Add(this.btnLimpiar);
            this.pnlFiltros.Controls.Add(this.lblMaximoCantCapitulos);
            this.pnlFiltros.Controls.Add(this.nudMaximoCantCapitulos);
            this.pnlFiltros.Controls.Add(this.lblMinimoCantCapitulos);
            this.pnlFiltros.Controls.Add(this.btnFiltrar);
            this.pnlFiltros.Controls.Add(this.nudMinimoCantCapitulos);
            this.pnlFiltros.Controls.Add(this.lblCantCapitulos);
            this.pnlFiltros.Controls.Add(this.chkFinalizada);
            this.pnlFiltros.Controls.Add(this.lblTitulo);
            this.pnlFiltros.Controls.Add(this.txtTitulo);
            this.pnlFiltros.Controls.Add(this.lblFechaEstrenoHasta);
            this.pnlFiltros.Controls.Add(this.dtpFechaEstrenoHasta);
            this.pnlFiltros.Controls.Add(this.lblFechaEstreno);
            this.pnlFiltros.Controls.Add(this.lblFechaEstrenoDesde);
            this.pnlFiltros.Controls.Add(this.dtpFechaEstrenoDesde);
            this.pnlFiltros.Controls.Add(this.lblPlataforma);
            this.pnlFiltros.Controls.Add(this.cmbPlataforma);
            this.pnlFiltros.Controls.Add(this.lblFiltros);
            this.pnlFiltros.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(967, 176);
            this.pnlFiltros.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLimpiar.Location = new System.Drawing.Point(845, 115);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 31);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblMaximoCantCapitulos
            // 
            this.lblMaximoCantCapitulos.AutoSize = true;
            this.lblMaximoCantCapitulos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaximoCantCapitulos.Location = new System.Drawing.Point(566, 122);
            this.lblMaximoCantCapitulos.Name = "lblMaximoCantCapitulos";
            this.lblMaximoCantCapitulos.Size = new System.Drawing.Size(62, 17);
            this.lblMaximoCantCapitulos.TabIndex = 16;
            this.lblMaximoCantCapitulos.Text = "Máximo:";
            // 
            // nudMaximoCantCapitulos
            // 
            this.nudMaximoCantCapitulos.Location = new System.Drawing.Point(634, 122);
            this.nudMaximoCantCapitulos.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMaximoCantCapitulos.Name = "nudMaximoCantCapitulos";
            this.nudMaximoCantCapitulos.Size = new System.Drawing.Size(69, 23);
            this.nudMaximoCantCapitulos.TabIndex = 8;
            this.nudMaximoCantCapitulos.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // lblMinimoCantCapitulos
            // 
            this.lblMinimoCantCapitulos.AutoSize = true;
            this.lblMinimoCantCapitulos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinimoCantCapitulos.Location = new System.Drawing.Point(410, 122);
            this.lblMinimoCantCapitulos.Name = "lblMinimoCantCapitulos";
            this.lblMinimoCantCapitulos.Size = new System.Drawing.Size(60, 17);
            this.lblMinimoCantCapitulos.TabIndex = 14;
            this.lblMinimoCantCapitulos.Text = "Mínimo:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnFiltrar.FlatAppearance.BorderSize = 2;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFiltrar.Location = new System.Drawing.Point(737, 115);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(92, 31);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // nudMinimoCantCapitulos
            // 
            this.nudMinimoCantCapitulos.Location = new System.Drawing.Point(476, 122);
            this.nudMinimoCantCapitulos.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudMinimoCantCapitulos.Name = "nudMinimoCantCapitulos";
            this.nudMinimoCantCapitulos.Size = new System.Drawing.Size(69, 23);
            this.nudMinimoCantCapitulos.TabIndex = 7;
            // 
            // lblCantCapitulos
            // 
            this.lblCantCapitulos.AutoSize = true;
            this.lblCantCapitulos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantCapitulos.Location = new System.Drawing.Point(410, 99);
            this.lblCantCapitulos.Name = "lblCantCapitulos";
            this.lblCantCapitulos.Size = new System.Drawing.Size(106, 17);
            this.lblCantCapitulos.TabIndex = 13;
            this.lblCantCapitulos.Text = "Cant. Capitulos:";
            // 
            // chkFinalizada
            // 
            this.chkFinalizada.AutoSize = true;
            this.chkFinalizada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkFinalizada.Location = new System.Drawing.Point(283, 57);
            this.chkFinalizada.Name = "chkFinalizada";
            this.chkFinalizada.Size = new System.Drawing.Size(89, 21);
            this.chkFinalizada.TabIndex = 3;
            this.chkFinalizada.Text = "Finalizada";
            this.chkFinalizada.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(22, 116);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 17);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(109, 115);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceholderText = "Titulo de la serie";
            this.txtTitulo.Size = new System.Drawing.Size(263, 23);
            this.txtTitulo.TabIndex = 6;
            // 
            // lblFechaEstrenoHasta
            // 
            this.lblFechaEstrenoHasta.AutoSize = true;
            this.lblFechaEstrenoHasta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaEstrenoHasta.Location = new System.Drawing.Point(681, 58);
            this.lblFechaEstrenoHasta.Name = "lblFechaEstrenoHasta";
            this.lblFechaEstrenoHasta.Size = new System.Drawing.Size(47, 17);
            this.lblFechaEstrenoHasta.TabIndex = 10;
            this.lblFechaEstrenoHasta.Text = "Hasta:";
            // 
            // dtpFechaEstrenoHasta
            // 
            this.dtpFechaEstrenoHasta.Checked = false;
            this.dtpFechaEstrenoHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstrenoHasta.Location = new System.Drawing.Point(737, 57);
            this.dtpFechaEstrenoHasta.Name = "dtpFechaEstrenoHasta";
            this.dtpFechaEstrenoHasta.ShowCheckBox = true;
            this.dtpFechaEstrenoHasta.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaEstrenoHasta.TabIndex = 5;
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaEstreno.Location = new System.Drawing.Point(410, 37);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(116, 17);
            this.lblFechaEstreno.TabIndex = 8;
            this.lblFechaEstreno.Text = "Fecha de estreno:";
            // 
            // lblFechaEstrenoDesde
            // 
            this.lblFechaEstrenoDesde.AutoSize = true;
            this.lblFechaEstrenoDesde.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaEstrenoDesde.Location = new System.Drawing.Point(410, 58);
            this.lblFechaEstrenoDesde.Name = "lblFechaEstrenoDesde";
            this.lblFechaEstrenoDesde.Size = new System.Drawing.Size(50, 17);
            this.lblFechaEstrenoDesde.TabIndex = 6;
            this.lblFechaEstrenoDesde.Text = "Desde:";
            // 
            // dtpFechaEstrenoDesde
            // 
            this.dtpFechaEstrenoDesde.Checked = false;
            this.dtpFechaEstrenoDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstrenoDesde.Location = new System.Drawing.Point(466, 57);
            this.dtpFechaEstrenoDesde.Name = "dtpFechaEstrenoDesde";
            this.dtpFechaEstrenoDesde.ShowCheckBox = true;
            this.dtpFechaEstrenoDesde.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaEstrenoDesde.TabIndex = 4;
            // 
            // FrmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 562);
            this.Controls.Add(this.dgvCatalogo);
            this.Controls.Add(this.pnlFiltros);
            this.MinimumSize = new System.Drawing.Size(983, 601);
            this.Name = "FrmCatalogo";
            this.ShowIcon = false;
            this.Text = "Catalogo de series";
            this.Load += new System.EventHandler(this.FrmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximoCantCapitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimoCantCapitulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.ComboBox cmbPlataforma;
        private System.Windows.Forms.Label lblPlataforma;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblFechaEstrenoHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaEstrenoHasta;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.Label lblFechaEstrenoDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaEstrenoDesde;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.CheckBox chkFinalizada;
        private System.Windows.Forms.NumericUpDown nudMinimoCantCapitulos;
        private System.Windows.Forms.Label lblCantCapitulos;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblMaximoCantCapitulos;
        private System.Windows.Forms.NumericUpDown nudMaximoCantCapitulos;
        private System.Windows.Forms.Label lblMinimoCantCapitulos;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

