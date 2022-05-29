using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarBiblioteca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefrescarBiblioteca()
        {
            dtgvBiblioteca.DataSource = JuegoDao.Leer();
            dtgvBiblioteca.Refresh();
            dtgvBiblioteca.Update();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvBiblioteca.SelectedRows.Count > 0)
                {
                    Biblioteca biblioteca = (Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;

                    JuegoDao.Eliminar(biblioteca.CodigoJuego);
                    RefrescarBiblioteca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAlta frmAlta = new FrmAlta();

                if (frmAlta.ShowDialog() == DialogResult.OK)
                {
                    RefrescarBiblioteca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dtgvBiblioteca.SelectedRows.Count > 0)
                {
                    Biblioteca biblioteca = (Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;

                    FrmAlta frmAlta = new FrmAlta(biblioteca.CodigoJuego);

                    if (frmAlta.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarBiblioteca();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
