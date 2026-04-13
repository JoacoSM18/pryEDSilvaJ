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
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }
        private void frmColores_Load(object sender, EventArgs e)
        {
            clsArchivoTexto X = new clsArchivoTexto();
            X.NombArchivo = "Colores.csv";
            if (File.Exists(X.NombArchivo)) X.Recorrer(lstColores);
        }
        private void btnGrabarColor_Click(object sender, EventArgs e)
        {
            clsArchivoTexto objColor = new clsArchivoTexto();
            objColor.NombArchivo = "Colores.csv";
            objColor.Grabar (txtNombreColor.Text);
            objColor.Recorrer(lstColores);
            MessageBox.Show("Color Grabado Correctamente");
        }
    }
}
