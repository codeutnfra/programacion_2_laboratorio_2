using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Xml.Serialization;

namespace Entidades
{
    public delegate void FinDeSalida(int bomberoIndex);

    public class Bombero : IArchivo<Bombero>, IArchivo<string>
    {
        public event FinDeSalida MarcarFin;
        private string nombre;
        private List<Salida> salidas;
        private static string rutaArchivo;
        private static Random random;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public List<Salida> Salidas
        {
            get
            {
                return salidas;
            }
            set
            {
                salidas = value;
            }
        }

        static Bombero()
        {
            rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Bombero.xml");
            random = new Random();
        }

        public Bombero(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Bombero()
        {
            salidas = new List<Salida>();
        }

        public void AtenderSalida(int bomberoIndex)
        {
            // i
            Salida salida = new Salida();
            salidas.Add(salida);

            // ii
            Thread.Sleep(random.Next(2000,4000));
            
            // iii
            salida.FinalizarSalida();
            
            // iv
            string log = $"Salida finalizada. Inicio: {salida.FechaInicio.ToLongTimeString()}. " +
                $"Fin: {salida.FechaFin.ToLongTimeString()}. Duración: {salida.TiempoTotal} segundos.";
            ((IArchivo<string>)this).Guardar(log);
            
            // v
            MarcarFin(bomberoIndex);
        }

        public void Guardar(Bombero info)
        {
            using StreamWriter streamWriter = new StreamWriter(rutaArchivo);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
            xmlSerializer.Serialize(streamWriter, info);
        }

        public Bombero Leer()
        {
            using StreamReader streamReader = new StreamReader(rutaArchivo);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
            return (Bombero)xmlSerializer.Deserialize(streamReader);
        }

        void IArchivo<string>.Guardar(string info)
        {
            LogDAO logDAO = new LogDAO();
            logDAO.InsertarLog(info);
        }

        string IArchivo<string>.Leer()
        {
            LogDAO logDAO = new LogDAO();
            return logDAO.LeerLog();
        }
    }
}
