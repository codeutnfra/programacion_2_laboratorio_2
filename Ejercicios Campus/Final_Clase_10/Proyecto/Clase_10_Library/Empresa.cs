using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8_Library
{
    public class Empresa
    {
        List<Empleado> _nominaEmpleados;
        string _razonSocial;
        string _direccion;
        float _ganancias;

        #region "Constructores"
        private Empresa()
        {
            this._nominaEmpleados = new List<Empleado>();
        }
        public Empresa(string razonSocial, string direccion, float ganancias)
            : this()
        {
            this._razonSocial = razonSocial;
            this._direccion = direccion;
            this._ganancias = ganancias;
        }
        #endregion

        #region "Propiedades"
        public string RazonSocial
        {
            get
            {
                return this._razonSocial;
            }
            set
            {
                this._razonSocial = value;
            }
        }
        public string Direccion
        {
            get
            {
                return this._direccion;
            }
            set
            {
                this._direccion = value;
            }
        }
        public float Ganancias
        {
            get
            {
                return this._ganancias;
            }
            set
            {
                this._ganancias = value;
            }
        }
        #endregion

        #region "Métodos"
        public string MostrarEmpresa()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("La empresa {0} sita en la calle {1} cuenta con ganancias por {2} y con {3} empleados:", this._razonSocial, this._direccion, this._ganancias, this._nominaEmpleados.Count);
            sb.AppendLine("");
            foreach (Empleado e in this._nominaEmpleados)
            {
                sb.AppendLine(e.ToString());
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un empleado a una empresa, siempre y cuando no figure ya en la nómina
        /// </summary>
        /// <param name="empresa">Empresa interesada.</param>
        /// <param name="empleado">Empleado a agregar.</param>
        /// <returns></returns>
        public static Empresa operator +(Empresa empresa, Empleado empleado)
        {
            foreach (Empleado e in empresa._nominaEmpleados)
            {
                // Si encuentro al empleado en la nómina, salgo del método.
                if (empleado == e)
                    return empresa;
            }
            // Agrego al empleado a la nómina
            empresa._nominaEmpleados.Add(empleado);
            return empresa;
        }
        #endregion
    }
}
