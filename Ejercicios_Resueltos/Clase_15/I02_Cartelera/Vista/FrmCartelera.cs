using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCartelera : Form
    {
        private static string rutaConfiguracion;

        static FrmCartelera()
        {
            rutaConfiguracion = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "configuracion.json");
        }

        public FrmCartelera()
        {
            InitializeComponent();
        }

        private void FrmCartelera_Load(object sender, EventArgs e)
        {
            ImportarConfiguracion(rutaConfiguracion);
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = txtTitulo.Text;
        }

        private void rtxtMensaje_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = rtxtMensaje.Text;
        }

        private void btnColorPanel_Click(object sender, EventArgs e)
        {
            pnlCartel.BackColor = ElegirColor(pnlCartel.BackColor);
        }

        private void btnColorTitulo_Click(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = ElegirColor(lblTitulo.ForeColor);
        }

        private void btnColorMensaje_Click(object sender, EventArgs e)
        {
            lblMensaje.ForeColor = ElegirColor(lblMensaje.ForeColor);
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            GuardarConfiguracion();
        }

        private void btnImportarConfiguracion_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json files(*.json)|*.json";
            openFileDialog.ShowDialog();
            ImportarConfiguracion(openFileDialog.FileName);
        }

        private void btnEliminarConfiguracion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la configuración?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                EliminarConfiguracion();
            }
        }

        private Color ElegirColor(Color colorActual)
        {
            colorDialog.Color = colorActual;
            colorDialog.ShowDialog();
            return colorDialog.Color;
        }

        private void GuardarConfiguracion()
        {
            try
            {
                Texto titulo = new Texto(lblTitulo.Text, lblTitulo.ForeColor.ToArgb());
                Texto mensaje = new Texto(lblMensaje.Text, lblMensaje.ForeColor.ToArgb());
                Cartel cartel = new Cartel(pnlCartel.BackColor.ToArgb(), titulo, mensaje);

                string cartelJson = JsonSerializer.Serialize(cartel);
                File.WriteAllText(rutaConfiguracion, cartelJson);
            }
            catch (Exception ex)
            {
                MostrarMensajeDeError(ex);
            }
        }

        private void ImportarConfiguracion(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string cartelJson = File.ReadAllText(path);
                    Cartel cartel = JsonSerializer.Deserialize<Cartel>(cartelJson);

                    pnlCartel.BackColor = Color.FromArgb(cartel.ColorARGB);

                    txtTitulo.Text = cartel.Titulo.Contenido;
                    lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                    rtxtMensaje.Text = cartel.Mensaje.Contenido;
                    lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);
                }
            }
            catch (JsonException)
            {
                MessageBox.Show("El archivo de configuración no se encuentra en el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MostrarMensajeDeError(ex);
            }
        }

        private void EliminarConfiguracion()
        {
            try
            {
                if (File.Exists(rutaConfiguracion))
                {
                    File.Delete(rutaConfiguracion);
                }

                txtTitulo.Text = "Título";
                lblTitulo.ForeColor = Control.DefaultForeColor;

                rtxtMensaje.Text = "Mensaje";
                lblMensaje.ForeColor = Control.DefaultForeColor;

                pnlCartel.BackColor = Control.DefaultBackColor;
            }
            catch (Exception ex)
            {
                MostrarMensajeDeError(ex);
            }
        }

        private void MostrarMensajeDeError(Exception ex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(ex.Message);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine(ex.StackTrace);

            MessageBox.Show(stringBuilder.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
