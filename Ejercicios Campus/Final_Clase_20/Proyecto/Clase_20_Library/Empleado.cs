using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;

using Archivos;
using Clase_10_Library;

namespace Clase_8_Library
{
    public class Empleado : Persona
    {
        public enum EPuestoJerarquico
        {
            Administración,
            Gerencia,
            Sistemas,
            Accionista
        }
        string _legajo;
        EPuestoJerarquico _puesto;
        int _salario;

        public string Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }
        public int Salario
        {
            get
            {
                return this._salario;
            }
            set
            {
                this._salario = value;
            }
        }
        public EPuestoJerarquico PuestoJerarquico
        {
            get
            {
                return this._puesto;
            }
            set
            {
                this._puesto = value;
            }
        }

        public Empleado()
        {
        }
        public Empleado(Persona persona, string legajo, EPuestoJerarquico puesto, int salario)
            : this(persona.Nombre, persona.Apellido, legajo, puesto, salario)
        {
        }

        public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
            : base(nombre, apellido)
        {
            this._legajo = legajo;
            this._puesto = puesto;
            this._salario = salario;
        }

        public override string PosicionSocietaria()
        {
            return "Empleado de " + this._puesto.ToString();
        }

        /// <summary>
        /// Dos empleados son iguales si, y sólo si, comparten el mismo número de legajo.
        /// </summary>
        /// <param name="e1">Primer empleado a comparar</param>
        /// <param name="e2">Segundo empleado a comparar</param>
        /// <returns></returns>
        public static bool operator ==(Empleado e1, Empleado e2)
        {
            // Controlo que ninguno de los dos empleados no haya sido instanciado, para evitar errores.
            if (!object.ReferenceEquals(e1, null) && !object.ReferenceEquals(e2, null))
            {
                if (e1._legajo == e2._legajo)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Dos empleados son distintos si, y sólo si, NO comparten el mismo número de legajo.
        /// </summary>
        /// <param name="e1">Primer empleado a comparar</param>
        /// <param name="e2">Segundo empleado a comparar</param>
        /// <returns></returns>
        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Persona.Mostrar(this));
            sb.AppendLine("Legajo  : " + this._legajo);
            sb.AppendLine(this.PosicionSocietaria()); //"Puesto  : " + this._puesto.ToString());
            sb.AppendLine("Salario : $" + this._salario);
            sb.AppendLine("******************");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #region ISerializable<Empleado> Members

        public bool guardar(string archivo)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Empleado));
                TextWriter writer = new StreamWriter(archivo);
                serializer.Serialize(writer, this);
                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                throw new ErrorEscrituraException(e);
            }
        }

        public bool leer(string archivo, out Empleado datos)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Empleado));
                TextReader writer = new StreamReader(archivo);
                datos = (Empleado)serializer.Deserialize(writer);
                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                throw new ErrorLecturaException(e);
            }
        }

        public bool modificar(string archivo)
        {
            return this.guardar(archivo);
        }

        public bool eliminar(string archivo)
        {
            if (File.Exists(archivo))
            {
                File.Delete(archivo);
                return true;
            }
            return false;
        }

        #endregion
    }
}
