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
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();
        }
        clsGrafoMatricial grafo = new clsGrafoMatricial();

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            grafo.MostrarCiudades(cmbOrigenes);
            grafo.MostrarCiudades(cmbDestinos);
            grafo.MostrarCiudades(cmbDestinos2);
            grafo.MostrarCiudades(cmbOrigenes2);
            grafo.MostrarCiudades(cmbDesde);
            grafo.MostrarCiudades(cmbHasta);
            grafo.MostrarTodo(dgvViajes);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {

        }
    }
}
