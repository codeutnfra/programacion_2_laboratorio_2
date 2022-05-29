using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public static class UsuarioDao
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static UsuarioDao()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT CODIGO_USUARIO, USERNAME FROM USUARIOS";

                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        usuarios.Add(new Usuario(dataReader["USERNAME"].ToString(), Convert.ToInt32(dataReader["CODIGO_USUARIO"])));
                    }

                }
            }
            finally
            {
                conexion.Close();
            }

            return usuarios;
        }


    }
}
