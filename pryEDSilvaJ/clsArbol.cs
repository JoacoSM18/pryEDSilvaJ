using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDSilvaJ
{
    internal class clsArbol
    {
        private clsNodo PrimerNodo;
        private clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }
        public void Agregar(clsNodo Nvo)
        {
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo Aux = Raiz;
                clsNodo Ant = Raiz;
                while (Aux != null)
                {
                    Ant = Aux;
                    if (Nvo.Codigo < Aux.Codigo) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;
                }
                if (Nvo.Codigo < Ant.Codigo) Ant.Izquierdo = Nvo;
                else Ant.Derecho = Nvo;
            }
        }
        public void Agregar(DataGridView Grilla) 
        {
            Grilla.Rows.Clear();
            InOrdenAsc (Grilla, Raiz);
        }
        public void InOrdenAsc (DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);
        }
        public void InOrdenDesc (ListBox Lst, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrdenDesc(Lst, R.Derecho);
            }
            Lst.Items.Add (R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrdenDesc(Lst, R.Izquierdo);
            }
        }
        public void PreOrden (clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode (R.Codigo.ToString ());
            nodoTreeView.Nodes.Add (NodoPadre);
            if (R.Izquierdo != null)
            {
                PreOrden (R.Izquierdo, NodoPadre);
            }
            if (R.Derecho != null)
            {
                PreOrden (R.Derecho, NodoPadre);
            }
        }
        public void Recorrer (DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        public void Recorrer (TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }
    }
}
