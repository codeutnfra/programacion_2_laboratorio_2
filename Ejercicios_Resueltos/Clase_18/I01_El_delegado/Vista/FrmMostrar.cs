using System.Windows.Forms;

namespace Vista
{
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string nombre)
        {
            lblNombre.Text = nombre;
        }
    }
}
