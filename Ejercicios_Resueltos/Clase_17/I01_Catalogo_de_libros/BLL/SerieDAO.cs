using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BLL
{
    public class SerieDAO : BaseDAO, ICrud<Serie>
    {
        public List<Serie> Listar()
        {
            string consulta = "SELECT " +
                    "s.id_serie, s.titulo, s.id_plataforma, s.fecha_estreno, s.cantidad_capitulos, s.finalizada, p.nombre " +
                    "FROM series s " +
                    "INNER JOIN plataformas p ON s.id_plataforma = p.id_plataforma";

            return Listar(consulta);
        }

        public List<Serie> Listar(string titulo, int idPlataforma, 
            DateTime? fechaEstrenoDesde, DateTime? fechaEstrenoHasta, 
            int cantCapitulosMin, int cantCapitulosMax, bool finalizada)
        {
            bool seAplicoFiltro = false;
            string filtroTitulo = null;
            string filtroFechaEstreno = null;
            string filtroCantCapitulos = null;
            string filtroFinalizada = null;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT ");
            stringBuilder.Append("s.id_serie, s.titulo, s.id_plataforma, s.fecha_estreno, s.cantidad_capitulos, s.finalizada, p.nombre ");
            stringBuilder.Append("FROM series s ");
            stringBuilder.Append("INNER JOIN plataformas p ON s.id_plataforma = p.id_plataforma");
            stringBuilder.Append("WHERE ");

            if (!string.IsNullOrWhiteSpace(titulo))
            {
                seAplicoFiltro = true;
                string filtroTitulo = "FROM series s ");
            }




            return Listar(consulta);
        }

        private List<Serie> Listar(string consulta)
        {
            List<Serie> series = new List<Serie>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(consulta, connection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    string titulo = dataReader.GetString(1);
                    int idPlataforma = dataReader.GetInt32(2);
                    DateTime fechaEstreno = dataReader.GetDateTime(3);
                    int cantidadCapitulos = dataReader.GetInt32(4);
                    bool finalizada = dataReader.GetBoolean(5);
                    string nombrePlataforma = dataReader.GetString(6);
                    Plataforma plataforma = new Plataforma(idPlataforma, nombrePlataforma);
                    series.Add(new Serie(id, titulo, plataforma, fechaEstreno, cantidadCapitulos, finalizada));
                }
            }

            return series;
        }

        public void Insertar(Serie objeto)
        {

        }

        public void Modificar(Serie objeto)
        {

        }

        public void Eliminar(Serie objeto)
        {

        }
    }
}
