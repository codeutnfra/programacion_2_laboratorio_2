using System.Windows.Forms;

namespace Vista
{
    public partial class FrmTestDelegados : Form
    {
        public delegate void ActualizarNombreDelegate(string nombre);
        private ActualizarNombreDelegate actualizarNombreDelegate;

        public FrmTestDelegados(ActualizarNombreDelegate actualizarNombreDelegate)
        {
            this.actualizarNombreDelegate = actualizarNombreDelegate;
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, System.EventArgs e)
        {
            actualizarNombreDelegate.Invoke(txtNombre.Text);
        }
    }
}
