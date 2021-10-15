using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, EventArgs e)
        {
            Text = $"Compu de {Environment.UserName}";
            ConfigurarLogoSistemaOperativo();
            lblSistemaOperativo.Text = $"Sistema operativo: {Environment.OSVersion}";
            lblNombreMaquina.Text = $"Nombre de la máquina: {Environment.MachineName}";
            ConfigurarArquitectura();
            lblCantProcesadores.Text = $"Cant. procesadores: {Environment.ProcessorCount} procesadores lógicos";
            lblDirectorioActual.Text = $"Identificación ejecutada en: {Environment.NewLine}{Environment.CurrentDirectory}";
            ConfigurarEspacioTotalYDisponible();
        }

        private void ConfigurarEspacioTotalYDisponible()
        {
            long espacioTotalBytes = 0;
            long espacioDisponibleBytes = 0;

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                espacioTotalBytes += drive.TotalSize;
                espacioDisponibleBytes += drive.AvailableFreeSpace;
            }

            double espacioTotal = Math.Round(espacioTotalBytes * 9.31e-10);
            double espacioDisponible = Math.Round(espacioDisponibleBytes * 9.31e-10);

            lblEspacioTotal.Text = $"Espacio total: {espacioTotal} Gigabytes";
            lblEspacioDisponible.Text = $"Espacio disponible: {espacioDisponible} Gigabytes";
        }

        private void ConfigurarArquitectura()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                lblArquitectura.Text = "Arquitectura: 64 bits";
            }
            else
            {
                lblArquitectura.Text = "Arquitectura: 32 bits";
            }
        }

        private void ConfigurarLogoSistemaOperativo()
        {
            if (OperatingSystem.IsMacOS())
            {
                picboxSistemaOperativo.Image = Properties.Resources.mac;
            }
            else if (OperatingSystem.IsLinux())
            {
                picboxSistemaOperativo.Image = Properties.Resources.linux;
            }
            else if (OperatingSystem.IsWindows())
            {
                picboxSistemaOperativo.Image = Properties.Resources.windows;
            }
        }
    }
}
