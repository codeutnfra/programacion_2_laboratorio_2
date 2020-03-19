using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    class Fruta
    {
        public float _peso;
        public int _volumen;

        public Fruta()
        {
            Random r = new Random();
            this._peso = r.Next(1, 5);
            this._volumen = r.Next(1, 10);
        }
    }
}
