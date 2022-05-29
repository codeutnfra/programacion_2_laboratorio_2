using System;

namespace Entidades
{
    public class Usuario
    {
        string username;
        int codigoUsuario;

        public Usuario(string username, int codigoUsuario)
        {
            this.username = username;
            this.codigoUsuario = codigoUsuario;
        }

        public string Username { get => username; }
        public int CodigoUsuario { get => codigoUsuario; }

        public override string ToString()
        {
            return username;
        }
    }
}
