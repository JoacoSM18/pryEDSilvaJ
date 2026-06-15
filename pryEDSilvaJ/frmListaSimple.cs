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
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtTramite.Text == "")
            {
                MessageBox.Show("Debe Completar Todos Los Campos");
                return;
            }
            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;
            ListaSimple.Agregar(n);
            ListaSimple.Recorrer(dgvLista);
            ListaSimple.Recorrer(lstLista);
            ListaSimple.Recorrer(cmbCodigo);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar un Código para Eliminar");
                return;
            }
            int codigoSeleccionado = Convert.ToInt32(cmbCodigo.SelectedItem.ToString());
            ListaSimple.Eliminar(codigoSeleccionado);
            ListaSimple.Recorrer(dgvLista);
            ListaSimple.Recorrer(lstLista);
            ListaSimple.Recorrer(cmbCodigo);
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Solo Se Permiten Números");
            }
        }
    }
}
