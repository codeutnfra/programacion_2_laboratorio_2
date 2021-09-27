using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo()
        {
            appsInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }

        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Sistema operativo: {sistemaOperativo}{Environment.NewLine}");

            foreach (Aplicacion app in appsInstaladas)
            {
                stringBuilder.AppendLine(app.ObtenerInformacionApp());
            }

            return stringBuilder.ToString();
        }

        public static bool InstalarApp(Aplicacion app)
        {
            if (app.SistemaOperativo != sistemaOperativo)
            {
                return false;
            }

            return appsInstaladas + app;
        }
    }
}
