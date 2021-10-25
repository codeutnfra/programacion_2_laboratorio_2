
namespace Vista
{
    partial class FrmCartelera
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
            this.pnlCartel = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dialogFuente = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.lblMenu = new System.Windows.Forms.Label();
            this.grpContenido = new System.Windows.Forms.GroupBox();
            this.lblTxtMensaje = new System.Windows.Forms.Label();
            this.rtxtMensaje = new System.Windows.Forms.RichTextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTxtTitulo = new System.Windows.Forms.Label();
            this.btnColorPanel = new System.Windows.Forms.Button();
            this.btnGuardarConfiguracion = new System.Windows.Forms.Button();
            this.btnImportarConfiguracion = new System.Windows.Forms.Button();
            this.btnColorTitulo = new System.Windows.Forms.Button();
            this.btnColorMensaje = new System.Windows.Forms.Button();
            this.btnEliminarConfiguracion = new System.Windows.Forms.Button();
            this.pnlCartel.SuspendLayout();
            this.grpContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCartel
            // 
            this.pnlCartel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCartel.Controls.Add(this.lblMensaje);
            this.pnlCartel.Controls.Add(this.lblTitulo);
            this.pnlCartel.Location = new System.Drawing.Point(354, 12);
            this.pnlCartel.Name = "pnlCartel";
            this.pnlCartel.Size = new System.Drawing.Size(621, 439);
            this.pnlCartel.TabIndex = 3;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.Location = new System.Drawing.Point(26, 103);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(104, 32);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Mensaje";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(15, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.Location = new System.Drawing.Point(13, 13);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(265, 25);
            this.lblMenu.TabIndex = 4;
            this.lblMenu.Text = "Opciones de personalización";
            // 
            // grpContenido
            // 
            this.grpContenido.Controls.Add(this.lblTxtMensaje);
            this.grpContenido.Controls.Add(this.rtxtMensaje);
            this.grpContenido.Controls.Add(this.txtTitulo);
            this.grpContenido.Controls.Add(this.lblTxtTitulo);
            this.grpContenido.Location = new System.Drawing.Point(13, 50);
            this.grpContenido.Name = "grpContenido";
            this.grpContenido.Size = new System.Drawing.Size(335, 210);
            this.grpContenido.TabIndex = 5;
            this.grpContenido.TabStop = false;
            this.grpContenido.Text = "Contenido";
            // 
            // lblTxtMensaje
            // 
            this.lblTxtMensaje.AutoSize = true;
            this.lblTxtMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTxtMensaje.Location = new System.Drawing.Point(7, 82);
            this.lblTxtMensaje.Name = "lblTxtMensaje";
            this.lblTxtMensaje.Size = new System.Drawing.Size(53, 15);
            this.lblTxtMensaje.TabIndex = 3;
            this.lblTxtMensaje.Text = "Mensaje";
            // 
            // rtxtMensaje
            // 
            this.rtxtMensaje.Location = new System.Drawing.Point(7, 100);
            this.rtxtMensaje.Name = "rtxtMensaje";
            this.rtxtMensaje.Size = new System.Drawing.Size(322, 96);
            this.rtxtMensaje.TabIndex = 2;
            this.rtxtMensaje.Text = "Mensaje";
            this.rtxtMensaje.TextChanged += new System.EventHandler(this.rtxtMensaje_TextChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(7, 42);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceholderText = "Ingrese el título";
            this.txtTitulo.Size = new System.Drawing.Size(322, 23);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.Text = "Título";
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // lblTxtTitulo
            // 
            this.lblTxtTitulo.AutoSize = true;
            this.lblTxtTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTxtTitulo.Location = new System.Drawing.Point(7, 23);
            this.lblTxtTitulo.Name = "lblTxtTitulo";
            this.lblTxtTitulo.Size = new System.Drawing.Size(39, 15);
            this.lblTxtTitulo.TabIndex = 0;
            this.lblTxtTitulo.Text = "Título";
            // 
            // btnColorPanel
            // 
            this.btnColorPanel.Location = new System.Drawing.Point(13, 302);
            this.btnColorPanel.Name = "btnColorPanel";
            this.btnColorPanel.Size = new System.Drawing.Size(335, 30);
            this.btnColorPanel.TabIndex = 5;
            this.btnColorPanel.Text = "Elegir color de fondo del panel";
            this.btnColorPanel.UseVisualStyleBackColor = true;
            this.btnColorPanel.Click += new System.EventHandler(this.btnColorPanel_Click);
            // 
            // btnGuardarConfiguracion
            // 
            this.btnGuardarConfiguracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarConfiguracion.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardarConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnGuardarConfiguracion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarConfiguracion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarConfiguracion.Location = new System.Drawing.Point(13, 373);
            this.btnGuardarConfiguracion.Name = "btnGuardarConfiguracion";
            this.btnGuardarConfiguracion.Size = new System.Drawing.Size(329, 36);
            this.btnGuardarConfiguracion.TabIndex = 6;
            this.btnGuardarConfiguracion.Text = "Guardar configuración";
            this.btnGuardarConfiguracion.UseVisualStyleBackColor = false;
            this.btnGuardarConfiguracion.Click += new System.EventHandler(this.btnGuardarConfiguracion_Click);
            // 
            // btnImportarConfiguracion
            // 
            this.btnImportarConfiguracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportarConfiguracion.BackColor = System.Drawing.Color.DarkGray;
            this.btnImportarConfiguracion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImportarConfiguracion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImportarConfiguracion.Location = new System.Drawing.Point(13, 415);
            this.btnImportarConfiguracion.Name = "btnImportarConfiguracion";
            this.btnImportarConfiguracion.Size = new System.Drawing.Size(162, 36);
            this.btnImportarConfiguracion.TabIndex = 7;
            this.btnImportarConfiguracion.Text = "Importar configuración";
            this.btnImportarConfiguracion.UseVisualStyleBackColor = false;
            this.btnImportarConfiguracion.Click += new System.EventHandler(this.btnImportarConfiguracion_Click);
            // 
            // btnColorTitulo
            // 
            this.btnColorTitulo.Location = new System.Drawing.Point(13, 266);
            this.btnColorTitulo.Name = "btnColorTitulo";
            this.btnColorTitulo.Size = new System.Drawing.Size(162, 30);
            this.btnColorTitulo.TabIndex = 3;
            this.btnColorTitulo.Text = "Configurar color título";
            this.btnColorTitulo.UseVisualStyleBackColor = true;
            this.btnColorTitulo.Click += new System.EventHandler(this.btnColorTitulo_Click);
            // 
            // btnColorMensaje
            // 
            this.btnColorMensaje.Location = new System.Drawing.Point(186, 266);
            this.btnColorMensaje.Name = "btnColorMensaje";
            this.btnColorMensaje.Size = new System.Drawing.Size(162, 30);
            this.btnColorMensaje.TabIndex = 4;
            this.btnColorMensaje.Text = "Configurar color mensaje";
            this.btnColorMensaje.UseVisualStyleBackColor = true;
            this.btnColorMensaje.Click += new System.EventHandler(this.btnColorMensaje_Click);
            // 
            // btnEliminarConfiguracion
            // 
            this.btnEliminarConfiguracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarConfiguracion.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnEliminarConfiguracion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarConfiguracion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarConfiguracion.Location = new System.Drawing.Point(180, 415);
            this.btnEliminarConfiguracion.Name = "btnEliminarConfiguracion";
            this.btnEliminarConfiguracion.Size = new System.Drawing.Size(162, 36);
            this.btnEliminarConfiguracion.TabIndex = 8;
            this.btnEliminarConfiguracion.Text = "Eliminar configuración";
            this.btnEliminarConfiguracion.UseVisualStyleBackColor = false;
            this.btnEliminarConfiguracion.Click += new System.EventHandler(this.btnEliminarConfiguracion_Click);
            // 
            // FrmCartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 463);
            this.Controls.Add(this.btnEliminarConfiguracion);
            this.Controls.Add(this.btnColorMensaje);
            this.Controls.Add(this.btnColorTitulo);
            this.Controls.Add(this.btnImportarConfiguracion);
            this.Controls.Add(this.btnGuardarConfiguracion);
            this.Controls.Add(this.btnColorPanel);
            this.Controls.Add(this.grpContenido);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.pnlCartel);
            this.MinimumSize = new System.Drawing.Size(989, 502);
            this.Name = "FrmCartelera";
            this.Text = "Cartelera";
            this.Load += new System.EventHandler(this.FrmCartelera_Load);
            this.pnlCartel.ResumeLayout(false);
            this.pnlCartel.PerformLayout();
            this.grpContenido.ResumeLayout(false);
            this.grpContenido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlCartel;
        private System.Windows.Forms.FontDialog dialogFuente;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.GroupBox grpContenido;
        private System.Windows.Forms.Label lblTxtMensaje;
        private System.Windows.Forms.RichTextBox rtxtMensaje;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTxtTitulo;
        private System.Windows.Forms.Button btnColorPanel;
        private System.Windows.Forms.Button btnGuardarConfiguracion;
        private System.Windows.Forms.Button btnImportarConfiguracion;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnColorTitulo;
        private System.Windows.Forms.Button btnColorMensaje;
        private System.Windows.Forms.Button btnEliminarConfiguracion;
    }
}

