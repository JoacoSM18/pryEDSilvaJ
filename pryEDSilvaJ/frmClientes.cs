using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDSilvaJ
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clsArchivoTexto X = new clsArchivoTexto();
            X.NombArchivo = "Clientes.csv";
            if (File.Exists(X.NombArchivo)) X.Recorrer(dgvClientes);
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDeuda.Text == "")
            {
                MessageBox.Show("Por Favor, Complete Todos los Campos");
                return;
            }
            clsArchivoTexto objCliente = new clsArchivoTexto();
            objCliente.NombArchivo = "Clientes.csv";
            objCliente.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            objCliente.Recorrer(dgvClientes);
            MessageBox.Show("Cliente Grabado Correctamente");
        }
    }
}
