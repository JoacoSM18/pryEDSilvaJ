using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDSilvaJ
{
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void btnGrabarCarrera_Click(object sender, EventArgs e)
        {
            clsArchivoTexto objCarrera = new clsArchivoTexto();
            objCarrera.NombArchivo = "Carreras.csv";
            objCarrera.Grabar(txtCarrera.Text);
            objCarrera.Recorrer(lstCarreras);
            MessageBox.Show("Carrera Grabada Correctamente");
        }
    }
}
