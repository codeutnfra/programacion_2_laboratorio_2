
namespace Presentacion
{
    partial class FrmIdentificacionComputadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picboxSistemaOperativo = new System.Windows.Forms.PictureBox();
            this.lblNombreMaquina = new System.Windows.Forms.Label();
            this.lblSistemaOperativo = new System.Windows.Forms.Label();
            this.lblArquitectura = new System.Windows.Forms.Label();
            this.lblCantProcesadores = new System.Windows.Forms.Label();
            this.lblDirectorioActual = new System.Windows.Forms.Label();
            this.lblEspacioTotal = new System.Windows.Forms.Label();
            this.lblEspacioDisponible = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSistemaOperativo)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxSistemaOperativo
            // 
            this.picboxSistemaOperativo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxSistemaOperativo.Location = new System.Drawing.Point(746, 37);
            this.picboxSistemaOperativo.Name = "picboxSistemaOperativo";
            this.picboxSistemaOperativo.Size = new System.Drawing.Size(225, 225);
            this.picboxSistemaOperativo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxSistemaOperativo.TabIndex = 0;
            this.picboxSistemaOperativo.TabStop = false;
            // 
            // lblNombreMaquina
            // 
            this.lblNombreMaquina.AutoSize = true;
            this.lblNombreMaquina.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreMaquina.Location = new System.Drawing.Point(12, 52);
            this.lblNombreMaquina.Name = "lblNombreMaquina";
            this.lblNombreMaquina.Size = new System.Drawing.Size(227, 16);
            this.lblNombreMaquina.TabIndex = 1;
            this.lblNombreMaquina.Text = "Nombre de la máquina: ";
            // 
            // lblSistemaOperativo
            // 
            this.lblSistemaOperativo.AutoSize = true;
            this.lblSistemaOperativo.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSistemaOperativo.Location = new System.Drawing.Point(12, 12);
            this.lblSistemaOperativo.Name = "lblSistemaOperativo";
            this.lblSistemaOperativo.Size = new System.Drawing.Size(187, 16);
            this.lblSistemaOperativo.TabIndex = 2;
            this.lblSistemaOperativo.Text = "Sistema Operativo:";
            // 
            // lblArquitectura
            // 
            this.lblArquitectura.AutoSize = true;
            this.lblArquitectura.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArquitectura.Location = new System.Drawing.Point(13, 92);
            this.lblArquitectura.Name = "lblArquitectura";
            this.lblArquitectura.Size = new System.Drawing.Size(137, 16);
            this.lblArquitectura.TabIndex = 3;
            this.lblArquitectura.Text = "Arquitectura:";
            // 
            // lblCantProcesadores
            // 
            this.lblCantProcesadores.AutoSize = true;
            this.lblCantProcesadores.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantProcesadores.Location = new System.Drawing.Point(13, 132);
            this.lblCantProcesadores.Name = "lblCantProcesadores";
            this.lblCantProcesadores.Size = new System.Drawing.Size(197, 16);
            this.lblCantProcesadores.TabIndex = 4;
            this.lblCantProcesadores.Text = "Cant. procesadores:";
            // 
            // lblDirectorioActual
            // 
            this.lblDirectorioActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDirectorioActual.AutoSize = true;
            this.lblDirectorioActual.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDirectorioActual.Location = new System.Drawing.Point(13, 287);
            this.lblDirectorioActual.Name = "lblDirectorioActual";
            this.lblDirectorioActual.Size = new System.Drawing.Size(231, 13);
            this.lblDirectorioActual.TabIndex = 5;
            this.lblDirectorioActual.Text = "Identificación ejecutada en:";
            this.lblDirectorioActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEspacioTotal
            // 
            this.lblEspacioTotal.AutoSize = true;
            this.lblEspacioTotal.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEspacioTotal.Location = new System.Drawing.Point(13, 172);
            this.lblEspacioTotal.Name = "lblEspacioTotal";
            this.lblEspacioTotal.Size = new System.Drawing.Size(147, 16);
            this.lblEspacioTotal.TabIndex = 6;
            this.lblEspacioTotal.Text = "Espacio total:";
            // 
            // lblEspacioDisponible
            // 
            this.lblEspacioDisponible.AutoSize = true;
            this.lblEspacioDisponible.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEspacioDisponible.Location = new System.Drawing.Point(13, 212);
            this.lblEspacioDisponible.Name = "lblEspacioDisponible";
            this.lblEspacioDisponible.Size = new System.Drawing.Size(197, 16);
            this.lblEspacioDisponible.TabIndex = 7;
            this.lblEspacioDisponible.Text = "Espacio disponible:";
            // 
            // FrmIdentificacionComputadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(983, 337);
            this.Controls.Add(this.lblEspacioDisponible);
            this.Controls.Add(this.lblEspacioTotal);
            this.Controls.Add(this.lblDirectorioActual);
            this.Controls.Add(this.lblCantProcesadores);
            this.Controls.Add(this.lblArquitectura);
            this.Controls.Add(this.lblSistemaOperativo);
            this.Controls.Add(this.lblNombreMaquina);
            this.Controls.Add(this.picboxSistemaOperativo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIdentificacionComputadora";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compu de [USUARIO]";
            this.Load += new System.EventHandler(this.FrmIdentificacionComputadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxSistemaOperativo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxSistemaOperativo;
        private System.Windows.Forms.Label lblNombreMaquina;
        private System.Windows.Forms.Label lblSistemaOperativo;
        private System.Windows.Forms.Label lblArquitectura;
        private System.Windows.Forms.Label lblCantProcesadores;
        private System.Windows.Forms.Label lblDirectorioActual;
        private System.Windows.Forms.Label lblEspacioTotal;
        private System.Windows.Forms.Label lblEspacioDisponible;
    }
}