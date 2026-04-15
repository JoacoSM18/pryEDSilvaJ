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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe x = new frmAcercaDe();
            x.ShowDialog();
        }
        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses x = new frmMeses();
            x.ShowDialog();
        }

        private void coloresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmColores x = new frmColores();
            x.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes x = new frmClientes();
            x.ShowDialog();
        }

        private void alumnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAlumnos x = new frmAlumnos();
            x.ShowDialog();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreras x = new frmCarreras();
            x.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola x = new frmCola();
            x.ShowDialog();
        }
    }
}
