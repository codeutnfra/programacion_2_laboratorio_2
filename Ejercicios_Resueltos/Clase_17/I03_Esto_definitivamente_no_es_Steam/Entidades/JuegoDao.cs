using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public static class JuegoDao
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static JuegoDao()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static void Guardar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO JUEGOS (NOMBRE,PRECIO,GENERO,CODIGO_USUARIO) VALUES (@nombre,@precio,@genero,@codigoUsuario)";
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@genero", juego.Genero);
                comando.Parameters.AddWithValue("@precio", juego.Precio);
                comando.Parameters.AddWithValue("@codigoUsuario", juego.CodigoUsuario);

                comando.ExecuteNonQuery();

            }
            finally
            {
                conexion.Close();
            }
        }

        public static Juego LeerPorId(int codigoJuego)
        {
            Juego juego = null;

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM JUEGOS WHERE CODIGO_JUEGO = {codigoJuego}";

                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        juego = new Juego(dataReader["NOMBRE"].ToString(), Convert.ToDouble(dataReader["PRECIO"]), dataReader["GENERO"].ToString(),
                         Convert.ToInt32(dataReader["CODIGO_JUEGO"]), Convert.ToInt32(dataReader["CODIGO_USUARIO"]));
                    }
                }

            }
            finally
            {
                conexion.Close();
            }

            return juego;
        }

        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> biblioteca = new List<Biblioteca>();

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT JUEGOS.NOMBRE as juego, JUEGOS.GENERO as genero, JUEGOS.CODIGO_JUEGO as codigoJuego, USUARIOS.USERNAME as usuario " +
                    $"FROM JUEGOS JOIN USUARIOS ON JUEGOS.CODIGO_USUARIO = USUARIOS.CODIGO_USUARIO";
                
                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        biblioteca.Add(new Biblioteca(dataReader["usuario"].ToString(), dataReader["genero"].ToString(), dataReader["juego"].ToString(),
                          Convert.ToInt32(dataReader["codigoJuego"])));
                    }
                }

            }
            finally
            {
                conexion.Close();
            }

            return biblioteca;
        }

        public static void Eliminar(int codigoJuego)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"DELETE FROM JUEGOS WHERE CODIGO_JUEGO = {codigoJuego}";
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void Modificar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE JUEGOS SET NOMBRE = @nombre, PRECIO = @precio, GENERO = @genero WHERE CODIGO_JUEGO = {juego.CodigoJuego}";
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@genero", juego.Genero);
                comando.Parameters.AddWithValue("@precio", juego.Precio);

                comando.ExecuteNonQuery();

            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
