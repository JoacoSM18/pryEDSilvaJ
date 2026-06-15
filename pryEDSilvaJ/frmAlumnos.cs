using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDSilvaJ
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            clsArchivoTexto obj = new clsArchivoTexto();
            obj.NombArchivo = "Carreras.csv";

            if (File.Exists(obj.NombArchivo))
            {
                obj.Recorrer(cmbCarreras);
            }
            else
            {
                MessageBox.Show("Primero Cargá Carreras en la Seccion Carreras");
            }
        }

        private void cmbCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto objCarrera = new clsArchivoTexto();
            objCarrera.NombArchivo = "Alumnos.csv";
            objCarrera.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarreras.Text);
            objCarrera.Recorrer(dgvAlumnos);
            MessageBox.Show("Carrera Grabada Correctamente");
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Solo Se Permiten Números");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Solo Se Permiten Letras y/o Espacios");
            }
        }
    }
}
