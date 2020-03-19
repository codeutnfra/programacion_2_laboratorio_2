using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_10_Library;

namespace Clase_8_Library
{
    public class Empresa
    {
        List<Persona> _nominaEmpleados;
        string _razonSocial;
        string _direccion;
        float _ganancias;

        #region "Constructores"
        private Empresa()
        {
            this._nominaEmpleados = new List<Persona>();
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
            foreach (Persona p in this._nominaEmpleados)
            {
                sb.AppendLine(p.ToString());
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores Completos"
        ///// <summary>
        ///// Agregará un empleado a una empresa, siempre y cuando no figure ya en la nómina
        ///// </summary>
        ///// <param name="empresa">Empresa interesada.</param>
        ///// <param name="empleado">Empleado a agregar.</param>
        ///// <returns></returns>
        //public static Empresa operator +(Empresa empresa, Empleado empleado)
        //{
        //    foreach (Persona p in empresa._nominaEmpleados)
        //    {
        //        if (p is Empleado)
        //        {
        //            // Si encuentro al empleado en la nómina, salgo del método.
        //            if (empleado == (Empleado)p)
        //                return empresa;
        //        }
        //    }
        //    // Agrego al empleado a la nómina
        //    empresa._nominaEmpleados.Add(empleado);
        //    return empresa;
        //}
        ///// <summary>
        ///// Agregará un accionista a una empresa, siempre y cuando no figure ya en la nómina
        ///// </summary>
        ///// <param name="empresa">Empresa interesada.</param>
        ///// <param name="empleado">Accionista a agregar.</param>
        ///// <returns></returns>
        //public static Empresa operator +(Empresa empresa, Accionista accionista)
        //{
        //    foreach (Persona p in empresa._nominaEmpleados)
        //    {
        //        if (p is Accionista)
        //        {
        //            // Si encuentro al accionista en la nómina, salgo del método.
        //            if (accionista == (Accionista)p)
        //                return empresa;
        //        }
        //    }
        //    // Agrego al accionista a la nómina
        //    empresa._nominaEmpleados.Add(accionista);
        //    return empresa;
        //}
        #endregion

        #region "Operadores Reutilizacion"
        private Empresa AgregarPersona(Persona nuevo)
        {
            foreach (Persona p in this._nominaEmpleados)
            {
                if (p is Empleado && nuevo is Empleado)
                {
                    // Si encuentro al empleado en la nómina, salgo del método.
                    if (nuevo == (Empleado)p)
                        return this;
                }
                else if (p is Accionista && nuevo is Accionista)
                {
                    // Si encuentro al empleado en la nómina, salgo del método.
                    if (nuevo == (Accionista)p)
                        return this;
                }
            }
            // Agrego al empleado a la nómina
            this._nominaEmpleados.Add(nuevo);
            return this;
        }

        /// <summary>
        /// Agregará un empleado a una empresa, siempre y cuando no figure ya en la nómina
        /// </summary>
        /// <param name="empresa">Empresa interesada.</param>
        /// <param name="empleado">Empleado a agregar.</param>
        /// <returns></returns>
        public static Empresa operator +(Empresa empresa, Empleado empleado)
        {
            return empresa.AgregarPersona(empleado);
        }
        /// <summary>
        /// Agregará un accionista a una empresa, siempre y cuando no figure ya en la nómina
        /// </summary>
        /// <param name="empresa">Empresa interesada.</param>
        /// <param name="empleado">Accionista a agregar.</param>
        /// <returns></returns>
        public static Empresa operator +(Empresa empresa, Accionista accionista)
        {
            return empresa.AgregarPersona(accionista);
        }
        #endregion


    }
}
