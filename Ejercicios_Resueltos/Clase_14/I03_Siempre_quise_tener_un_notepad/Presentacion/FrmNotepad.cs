using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmNotepad : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private string ultimoArchivo;

        private string UltimoArchivo
        {
            get
            {
                return ultimoArchivo;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    ultimoArchivo = value;
                }
            }
        }

        public FrmNotepad()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de texto|*.txt";
        }

        private void FrmNotepad_Load(object sender, EventArgs e)
        {
            stripStatusLabelCaracteres.Text = "0 caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ultimoArchivo = openFileDialog.FileName;
                    using StreamReader streamReader = new StreamReader(ultimoArchivo);
                    rtxtContenido.Text = streamReader.ReadToEnd();
                }
                catch (Exception ex)
                {
                    MostrarVentanaDeError(ex);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UltimoArchivo = SeleccionarUbicacionGuardado();
             
            GuardarArchivo(UltimoArchivo);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(UltimoArchivo))
            {
                UltimoArchivo = SeleccionarUbicacionGuardado();
            }

            GuardarArchivo(UltimoArchivo);
        }

        private string SeleccionarUbicacionGuardado()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return string.Empty;
        }

        private void GuardarArchivo(string ruta)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(ruta))
                {
                    using StreamWriter streamWriter = new StreamWriter(ultimoArchivo);
                    streamWriter.Write(rtxtContenido.Text);
                }
            }
            catch (Exception ex)
            {
                MostrarVentanaDeError(ex);
            }
        }

        private void MostrarVentanaDeError(Exception ex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Error: {ex.Message}");
            stringBuilder.AppendLine("Detalle:");
            stringBuilder.AppendLine(ex.StackTrace);

            MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rtxtContenido_TextChanged(object sender, EventArgs e)
        {
            stripStatusLabelCaracteres.Text = $"{rtxtContenido.Text.Length} caracteres";
        }
    }
}
