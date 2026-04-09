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
            clsArchivoTexto objMes = new clsArchivoTexto();
            objMes.NombArchivo = "Meses.csv";
            objMes.Grabar(txtNombreMeses.Text);
            objMes.Recorrer(lstMeses);
            MessageBox.Show("Mes Grabado Correctamente");
        }
    }
}
