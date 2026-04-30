using System;
using System.Collections;
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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }
        clsListaDoble Lista = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            Lista.Agregar(ObjNodo);
            Lista.Recorrer(dgvListaDoble);
            Lista.Recorrer(lstLista);
            Lista.Recorrer(dgvListaDoble);
            Lista.Recorrer("clsListaDoble.csv");

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }
    }
}
