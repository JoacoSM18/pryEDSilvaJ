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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        private void frmCola_Load(object sender, EventArgs e)
        {
            
        }
        clsCola fila = new clsCola();
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
            fila.Agregar(n);
            fila.Recorrer(dgvCola);
            fila.Recorrer(lstCola);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (fila.Primero != null)
            {
                lblCodigo3D.Text = (fila.Primero.Codigo.ToString());
                lblNombre3D.Text = (fila.Primero.Nombre);
                lblTramite3D.Text = (fila.Primero.Tramite);
                fila.Eliminar();
                fila.Recorrer(dgvCola);
                fila.Recorrer(lstCola);
                fila.Recorrer();
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
