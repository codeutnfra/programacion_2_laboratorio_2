
namespace Vista
{
    partial class FrmReloj
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
            this.components = new System.ComponentModel.Container();
            this.lblHora = new System.Windows.Forms.Label();
            this.rtxtContenido = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnDetenerReloj = new System.Windows.Forms.Button();
            this.btnIniciarReloj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(13, 14);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(136, 15);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "DD/MM/YYYY HH:MI:SS";
            // 
            // rtxtContenido
            // 
            this.rtxtContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtContenido.Location = new System.Drawing.Point(13, 41);
            this.rtxtContenido.Name = "rtxtContenido";
            this.rtxtContenido.Size = new System.Drawing.Size(775, 397);
            this.rtxtContenido.TabIndex = 1;
            this.rtxtContenido.Text = "";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnDetenerReloj
            // 
            this.btnDetenerReloj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetenerReloj.Location = new System.Drawing.Point(627, 10);
            this.btnDetenerReloj.Name = "btnDetenerReloj";
            this.btnDetenerReloj.Size = new System.Drawing.Size(161, 23);
            this.btnDetenerReloj.TabIndex = 2;
            this.btnDetenerReloj.Text = "Detener reloj";
            this.btnDetenerReloj.UseVisualStyleBackColor = true;
            this.btnDetenerReloj.Click += new System.EventHandler(this.btnDetenerReloj_Click);
            // 
            // btnIniciarReloj
            // 
            this.btnIniciarReloj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarReloj.Location = new System.Drawing.Point(460, 10);
            this.btnIniciarReloj.Name = "btnIniciarReloj";
            this.btnIniciarReloj.Size = new System.Drawing.Size(161, 23);
            this.btnIniciarReloj.TabIndex = 3;
            this.btnIniciarReloj.Text = "Iniciar reloj";
            this.btnIniciarReloj.UseVisualStyleBackColor = true;
            this.btnIniciarReloj.Click += new System.EventHandler(this.btnIniciarReloj_Click);
            // 
            // FrmReloj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIniciarReloj);
            this.Controls.Add(this.btnDetenerReloj);
            this.Controls.Add(this.rtxtContenido);
            this.Controls.Add(this.lblHora);
            this.Name = "FrmReloj";
            this.Text = "Reloj";
            this.Load += new System.EventHandler(this.FrmReloj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.RichTextBox rtxtContenido;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnDetenerReloj;
        private System.Windows.Forms.Button btnIniciarReloj;
    }
}

