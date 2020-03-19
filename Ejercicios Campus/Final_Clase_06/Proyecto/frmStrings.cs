using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_6_Forms
{
    public partial class frmStrings : Form
    {
        public frmStrings()
        {
            InitializeComponent();
        }

        private void rtxtTexto_TextChanged(object sender, EventArgs e)
        {
            int cantidadPalabras = 0;
            int cantidadFinalizaLA = 0;
            // Quito los espacios en blanco a izquierda y derecha
            string texto = rtxtTexto.Text.Trim();
            // Divido la cadena a través de los espacios vacios ' ' y la recorro
            foreach (string s in texto.Split(' '))
            {
                // Si la palabra no es null o vacia, incremento mi acumulador
                if (!string.IsNullOrEmpty(s))
                {
                    cantidadPalabras += 1;
                    // Si finaliza en "la" incremento mi acumulador
                    if(s.Length>=2)
                        if(s.ToLower().LastIndexOf("la") == s.Length-2)
                            cantidadFinalizaLA += 1;
                }
            }

            lblCantPalabras.Text = cantidadPalabras.ToString();
            lblCantFinalizaLA.Text = cantidadFinalizaLA.ToString();
        }

        private void btn20Palabras_Click(object sender, EventArgs e)
        {
            // Limpio el cuadro de resultados
            txtResultado.Text = "";

            int acum = 0;
            // Quito los espacios en blanco a izquierda y derecha
            string texto = rtxtTexto.Text.Trim();
            // Divido la cadena a través de los espacios vacios ' ' y la recorro
            foreach (string s in texto.Split(' '))
            {
                // Si la palabra no es null o vacia, la muestro
                if (!string.IsNullOrEmpty(s))
                {
                    txtResultado.Text += "* " + s;
                    // Cuanto haya llegado a las 20 palabras, rompo el FOR
                    acum++;
                    if (acum >= 20)
                        break;
                }
            }
        }

        private void btn100Letras_Click(object sender, EventArgs e)
        {
            // Limpio el cuadro de resultados
            txtResultado.Text = "";

            // Calculo el valor máximo para substring
            //         = CONDICION ? true : false;
            int valMax = rtxtTexto.Text.Length >= 100 ? 100 : rtxtTexto.Text.Length;

            txtResultado.Text = rtxtTexto.Text.Substring(0, valMax);
        }

        private void btn3PrimerasA_Click(object sender, EventArgs e)
        {
            txtResultado.Text = buscarPalabraFinalizadaEn("a ", 3);
        }

        private void btn3PrimerasO_Click(object sender, EventArgs e)
        {
            txtResultado.Text = buscarPalabraFinalizadaEn("o ", 3);
        }

        private string buscarPalabraFinalizadaEn(string contenidoFinal, short cantidadAEncontrar)
        {
            string acumPalabras = "";
            int acum = 0;
            int indice = -1;
            int inicioCadena;
            // Quito los espacios en blanco a izquierda y derecha
            string texto = rtxtTexto.Text.Trim();
            // 
            do
            {
                // Busco una palabra finalizada según el parámetro contenidoFinal,
                // tomando como indice de inicio al último obtenido
                indice = texto.IndexOf(contenidoFinal, indice + 1);
                if (indice == -1)
                    break;
                // ¡Encontré una nueva palabra!
                acum++;

                // Calculo donde inicia la palabra. Si inicioCadena es -1,
                // quiere decir que estoy en la primer palabra del texto,
                // por ende el indice de inicio será 0.
                inicioCadena = texto.LastIndexOf(" ", indice);
                if (inicioCadena == -1)
                    inicioCadena = 0;
                // Recorto la palabra y la acumulo
                acumPalabras += "* " + texto.Substring(inicioCadena, (indice-inicioCadena) + 1);
            } while (acum < cantidadAEncontrar);

            return acumPalabras;
        }
    }
}
