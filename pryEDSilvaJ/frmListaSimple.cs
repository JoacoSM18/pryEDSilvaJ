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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple ListaSimple = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;
            ListaSimple.Agregar(n);
            ListaSimple.Recorrer(lstLista);
            ListaSimple.Recorrer(lstLista);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
