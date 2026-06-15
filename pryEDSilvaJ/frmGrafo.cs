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
            if (cmbOrigenes.SelectedIndex == -1 || cmbDestinos.SelectedIndex == -1 || txtPrecio.Text == " ")
            {
                MessageBox.Show("Debe Completar Todos Los Campos");
                return;
            }
            if (cmbOrigenes.SelectedIndex == cmbDestinos.SelectedIndex)
            {
                MessageBox.Show("El Origen y el Destino no Pueden Ser Iguales");
                return;
            }
            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("El Precio Debe ser un Número Válido Mayor a 0");
                return;
            }
            grafo.Agregar(cmbOrigenes.SelectedIndex, cmbDestinos.SelectedIndex, precio);
            grafo.MostrarTodo(dgvViajes);
            txtPrecio.Text = "";
            cmbOrigenes.SelectedIndex = -1;
            cmbDestinos.SelectedIndex = -1;
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            grafo.BorrarTodo();
            grafo.MostrarTodo(dgvViajes);
            txtPrecio.Text = "";
            cmbOrigenes.SelectedIndex = -1;
            cmbDestinos.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbOrigenes2.SelectedIndex == -1 || cmbDestinos2.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar Origen y Destino");
                return;
            }
            decimal precio = grafo.Consultar(cmbOrigenes2.SelectedIndex, cmbDestinos2.SelectedIndex);
            if (precio == 0)
                lblPrecio3D.Text = "No Hay Viajes Disponibles";
            else
                lblPrecio3D.Text = "$" + precio.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cmbOrigenes2.SelectedIndex == -1 || cmbDestinos2.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar Origen y Destino");
                return;
            }
            grafo.Eliminar(cmbOrigenes2.SelectedIndex, cmbDestinos2.SelectedIndex);
            grafo.MostrarTodo(dgvViajes);
            lblPrecio3D.Text = "";
            cmbOrigenes2.SelectedIndex = -1;
            cmbDestinos2.SelectedIndex = -1;
        }

        private void btnListarDestinos_Click(object sender, EventArgs e)
        {
            if (cmbDesde.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar un Origen");
                return;
            }
            grafo.MostrarDestinos(cmbDesde.SelectedIndex, dgvViajes);
        }

        private void btnListarOrigenes_Click(object sender, EventArgs e)
        {
            if (cmbHasta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar un Destino");
                return;
            }
            grafo.MostrarOrigenes(cmbHasta.SelectedIndex, dgvViajes);
        }

        private void btnVerTodoslosViajes_Click(object sender, EventArgs e)
        {
            grafo.MostrarTodo(dgvViajes);
        }
    }
}
