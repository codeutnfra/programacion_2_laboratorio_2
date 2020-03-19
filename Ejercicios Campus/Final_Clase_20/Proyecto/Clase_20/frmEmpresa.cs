using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase_10_Library;
using Clase_8_Library;

namespace Clase_8
{
    public partial class frmEmpresa : Form
    {
        Empresa _empresa;

        public Empresa Empresa
        {
            get
            {
                return this._empresa;
            }
        }

        public frmEmpresa(Empresa empresa)
        {
            InitializeComponent();

            this._empresa = empresa;
            if (this._empresa == null)
            {
                this._empresa = new Empresa("", "", 0);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.generarEmpresaDesdeFormulario();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        static string ARCHIVO = "empresa.txt";
        private void generarEmpresaDesdeFormulario()
        {
            float ganancias = float.Parse(this.mtxtGanancias.Text.Replace(".", ",").Substring(1, mtxtGanancias.Text.Length - 1));

            this._empresa.RazonSocial = this.txtRazonSocial.Text;
            this._empresa.Direccion = this.txtDireccion.Text;
            this._empresa.Ganancias = ganancias;
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._empresa.eliminar(ARCHIVO);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.generarEmpresaDesdeFormulario();
            try
            {
                this._empresa.guardar(ARCHIVO);
            }
            catch (ErrorEscrituraException ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void leerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string empresa;
            try
            {
                this._empresa.leer(ARCHIVO, out empresa);

                lblEmpresa.Text = empresa;
            }
            catch (ErrorLecturaException ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                guardarToolStripMenuItem_Click(sender, e);
            }
            catch (ErrorEscrituraException ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
