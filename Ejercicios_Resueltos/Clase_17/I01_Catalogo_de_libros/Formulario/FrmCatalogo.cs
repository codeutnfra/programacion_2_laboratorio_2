using BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FrmCatalogo : Form
    {
        private SerieDAO serieDAO;
        private PlataformaDAO plataformaDAO;

        public FrmCatalogo()
        {
            InitializeComponent();
            serieDAO = new SerieDAO();
            plataformaDAO = new PlataformaDAO();
        }

        private void FrmCatalogo_Load(object sender, EventArgs e)
        {
            List<Plataforma> plataformas = plataformaDAO.Listar();
            plataformas.Insert(0, new Plataforma(0, "Todas"));
            cmbPlataforma.DataSource = plataformas;
            dgvCatalogo.DataSource = serieDAO.Listar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbPlataforma.SelectedIndex = 0;
            txtTitulo.Text = string.Empty;
            dtpFechaEstrenoDesde.Value = DateTime.Today;
            dtpFechaEstrenoDesde.Checked = false;
            dtpFechaEstrenoHasta.Value = DateTime.Today;
            dtpFechaEstrenoHasta.Checked = false;
            chkFinalizada.Checked = false;
            nudMinimoCantCapitulos.Minimum = 0;
            nudMaximoCantCapitulos.Maximum = 9999;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
