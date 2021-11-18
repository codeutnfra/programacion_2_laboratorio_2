using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Entidades
{
    public class LogDAO
    {
        private SqlConnection sqlConnection;

        public LogDAO()
        {
            sqlConnection = new SqlConnection("Server=.;Database=bomberos-db;Trusted_Connection=True;");
        }

        public void InsertarLog(string mensaje)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO dbo.log (entrada, alumno) VALUES (@mensaje, 'Mauricio Cerizza')", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@mensaje", mensaje);
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public string LeerLog()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT entrada FROM dbo.log;", sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                StringBuilder stringBuilder = new StringBuilder();

                if (reader.Read())
                {
                    stringBuilder.AppendLine(reader.GetString(0));
                }

                return stringBuilder.ToString();
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
