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
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombArchivo = "Meses.csv";
            x.Grabar(txtCarrera.Text);
            x.Recorrer(lstCarreras);
            MessageBox.Show("Carrera Grabada Correctamente");
        }
    }
}
