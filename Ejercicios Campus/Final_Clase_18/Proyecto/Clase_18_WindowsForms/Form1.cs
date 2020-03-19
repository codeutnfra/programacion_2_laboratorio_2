using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase_8_Library;
using Clase_18_Library;

namespace Clase_18_WindowsForms
{
    public partial class frmPrueba : Form, IGrafica
    {
        public frmPrueba()
        {
            InitializeComponent();
        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado("Jorge", "Martínez", "123-456", Empleado.EPuestoJerarquico.Sistemas, 15000);
            empleado.Mostrar(this);
        }

        #region IGrafica Members

        public void MostrarEnGUI(string datos)
        {
            lblTexto.Text = datos;
        }

        #endregion
    }
}
