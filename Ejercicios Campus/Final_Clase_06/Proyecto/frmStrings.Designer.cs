namespace Clase_6_Forms
{
    partial class frmStrings
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
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn20Palabras = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn100Letras = new System.Windows.Forms.Button();
            this.btn3PrimerasO = new System.Windows.Forms.Button();
            this.btn3PrimerasA = new System.Windows.Forms.Button();
            this.lblCantFinalizaLA = new System.Windows.Forms.Label();
            this.lblCantPalabras = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtTexto.Location = new System.Drawing.Point(0, 137);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(508, 279);
            this.rtxtTexto.TabIndex = 0;
            this.rtxtTexto.Text = "";
            this.rtxtTexto.TextChanged += new System.EventHandler(this.rtxtTexto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Palabras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Finaliza en LA";
            // 
            // btn20Palabras
            // 
            this.btn20Palabras.Location = new System.Drawing.Point(405, 96);
            this.btn20Palabras.Name = "btn20Palabras";
            this.btn20Palabras.Size = new System.Drawing.Size(91, 35);
            this.btn20Palabras.TabIndex = 3;
            this.btn20Palabras.Text = "20 palabras";
            this.btn20Palabras.UseVisualStyleBackColor = true;
            this.btn20Palabras.Click += new System.EventHandler(this.btn20Palabras_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(15, 70);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(481, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Palabras";
            // 
            // btn100Letras
            // 
            this.btn100Letras.Location = new System.Drawing.Point(308, 96);
            this.btn100Letras.Name = "btn100Letras";
            this.btn100Letras.Size = new System.Drawing.Size(91, 35);
            this.btn100Letras.TabIndex = 6;
            this.btn100Letras.Text = "100 letras";
            this.btn100Letras.UseVisualStyleBackColor = true;
            this.btn100Letras.Click += new System.EventHandler(this.btn100Letras_Click);
            // 
            // btn3PrimerasO
            // 
            this.btn3PrimerasO.Location = new System.Drawing.Point(114, 96);
            this.btn3PrimerasO.Name = "btn3PrimerasO";
            this.btn3PrimerasO.Size = new System.Drawing.Size(91, 35);
            this.btn3PrimerasO.TabIndex = 8;
            this.btn3PrimerasO.Text = "3 primeras \"o \"";
            this.btn3PrimerasO.UseVisualStyleBackColor = true;
            this.btn3PrimerasO.Click += new System.EventHandler(this.btn3PrimerasO_Click);
            // 
            // btn3PrimerasA
            // 
            this.btn3PrimerasA.Location = new System.Drawing.Point(211, 96);
            this.btn3PrimerasA.Name = "btn3PrimerasA";
            this.btn3PrimerasA.Size = new System.Drawing.Size(91, 35);
            this.btn3PrimerasA.TabIndex = 7;
            this.btn3PrimerasA.Text = "3 primeras \"a \"";
            this.btn3PrimerasA.UseVisualStyleBackColor = true;
            this.btn3PrimerasA.Click += new System.EventHandler(this.btn3PrimerasA_Click);
            // 
            // lblCantFinalizaLA
            // 
            this.lblCantFinalizaLA.AutoSize = true;
            this.lblCantFinalizaLA.Location = new System.Drawing.Point(111, 32);
            this.lblCantFinalizaLA.Name = "lblCantFinalizaLA";
            this.lblCantFinalizaLA.Size = new System.Drawing.Size(13, 13);
            this.lblCantFinalizaLA.TabIndex = 10;
            this.lblCantFinalizaLA.Text = "0";
            // 
            // lblCantPalabras
            // 
            this.lblCantPalabras.AutoSize = true;
            this.lblCantPalabras.Location = new System.Drawing.Point(111, 9);
            this.lblCantPalabras.Name = "lblCantPalabras";
            this.lblCantPalabras.Size = new System.Drawing.Size(13, 13);
            this.lblCantPalabras.TabIndex = 9;
            this.lblCantPalabras.Text = "0";
            // 
            // frmStrings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 416);
            this.Controls.Add(this.lblCantFinalizaLA);
            this.Controls.Add(this.lblCantPalabras);
            this.Controls.Add(this.btn3PrimerasO);
            this.Controls.Add(this.btn3PrimerasA);
            this.Controls.Add(this.btn100Letras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btn20Palabras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtTexto);
            this.Name = "frmStrings";
            this.Text = "Clase 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn20Palabras;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn100Letras;
        private System.Windows.Forms.Button btn3PrimerasO;
        private System.Windows.Forms.Button btn3PrimerasA;
        private System.Windows.Forms.Label lblCantFinalizaLA;
        private System.Windows.Forms.Label lblCantPalabras;
    }
}

