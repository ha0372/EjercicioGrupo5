using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio_Practico_Excepciones.VISTA
{
    public partial class FrmFichero : Form
    {
        public FrmFichero()
        {
            InitializeComponent();
        }

        private void FrmFichero_Load(object sender, EventArgs e)
        {

            /* PUEDES CORREGIR LA DIRECCION DEL FICHERO DESPUES DE CAPTURAR LA EXCEPCION*/ /* "excepciones.txt" */

            TextReader text = new StreamReader("excepcionestxt");

            txtMostrar.AppendText(text.ReadToEnd());


           




        }
    }
}
