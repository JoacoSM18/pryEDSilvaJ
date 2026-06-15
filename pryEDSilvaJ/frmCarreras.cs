using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public void btnGrabarCarrera_Click(object sender, EventArgs e)
        {
            if (txtCarrera.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Carrera");
                return;
            }
            clsArchivoTexto objCarrera = new clsArchivoTexto();
            objCarrera.NombArchivo = "Carreras.csv";
            objCarrera.Grabar(txtCarrera.Text);
            objCarrera.Recorrer(lstCarreras);
            MessageBox.Show("Carrera Grabada Correctamente");
        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {
            clsArchivoTexto X = new clsArchivoTexto();
            X.NombArchivo = "Carreras.csv";
            if (File.Exists(X.NombArchivo)) X.Recorrer(lstCarreras);
        }
    }
}
