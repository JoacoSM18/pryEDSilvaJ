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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila pila = new clsPila();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtTramite.Text == "")
            {
                MessageBox.Show("Debe Completar Todos Los Campos");
                return;
            }
            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = Convert.ToInt32(txtCodigo.Text);
            nuevo.Nombre = txtNombre.Text;
            nuevo.Tramite = txtTramite.Text;
            pila.Agregar(nuevo);
            pila.Recorrer(dgvPila);
            pila.Recorrer(lstPila);
            pila.Recorrer("ArchivoPila.csv");
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (pila.Primero != null)
            {
                lblCodigo3D.Text = pila.Primero.Codigo.ToString();
                lblNombre3D.Text = pila.Primero.Nombre;
                lblTramite3D.Text = pila.Primero.Tramite;
                pila.Eliminar();
                pila.Recorrer(dgvPila);
                pila.Recorrer(lstPila);
                pila.Recorrer();
            }
            else
            { 
                lblCodigo3D.Text = "";
                lblNombre3D.Text = "";
                lblTramite3D.Text = "";
            }
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
