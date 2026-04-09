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
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabarMeses_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NombArchivo = "Meses.csv";
            x.Grabar(txtNombreMeses.Text);
            x.Recorrer(lstMeses);
            MessageBox.Show("Mes Grabado Correctamente");
        }
    }
}
