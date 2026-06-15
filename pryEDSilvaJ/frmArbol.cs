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
    public partial class frmArbol : Form
    {
        public frmArbol()
        {
            InitializeComponent();
        }
        clsArbol ObjArbol = new clsArbol();
        private void frmArbol_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtTramite.Text == "")
            {
                MessageBox.Show("Debe Completar Todos Los Campos");
                return;
            }
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;
            ObjArbol.Agregar(Persona);
            ObjArbol.Recorrer(dgvArbol);
            ObjArbol.Recorrer(trvArbol);
            cmbCodigo.Items.Add(txtCodigo.Text);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar un Código para Eliminar");
                return;
            }
            int codigoSeleccionado = Convert.ToInt32(cmbCodigo.SelectedItem.ToString());
            ObjArbol.Eliminar(codigoSeleccionado);
            cmbCodigo.Items.Remove(cmbCodigo.SelectedItem);
            ObjArbol.Recorrer(dgvArbol);
            ObjArbol.Recorrer(trvArbol);
        }

        private void btnInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (btnInOrden.Checked)
            {
                if (ObjArbol.CantNodos == 0) { MessageBox.Show("No Hay Nodos Cargados"); return; }
                ObjArbol.Recorrer(dgvArbol);
            }
        }

        private void btnPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPreOrden.Checked)
            {
                if (ObjArbol.CantNodos == 0) { MessageBox.Show("No Hay Nodos Cargados"); return; }
                ObjArbol.Recorrer(trvArbol);
            }
        }
        private void btnPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPostOrden.Checked)
            {
                if (ObjArbol.CantNodos == 0) { MessageBox.Show("No Hay Nodos Cargados"); return; }
                ObjArbol.RecorrerPostOrden(dgvArbol);
            }
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            if (ObjArbol.CantNodos < 3)
            {
                MessageBox.Show("Debe Haber al Menos 3 Nodos Para Poder Equilibrar");
                return;
            }
            ObjArbol.Equilibrar();
            ObjArbol.Recorrer(dgvArbol);
            ObjArbol.Recorrer(trvArbol);
        }
    }
}
