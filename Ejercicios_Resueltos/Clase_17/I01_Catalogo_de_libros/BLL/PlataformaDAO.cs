using System.Collections.Generic;
using System.Data.SqlClient;

namespace BLL
{
    public class PlataformaDAO : BaseDAO
    {
        public List<Plataforma> Listar()
        {
            List<Plataforma> plataformas = new List<Plataforma>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT id_plataforma, nombre FROM plataformas", connection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    string nombre = dataReader.GetString(1);
                    plataformas.Add(new Plataforma(id, nombre));
                }
            }

            return plataformas;
        }
    }
}
