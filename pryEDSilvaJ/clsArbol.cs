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
        public clsNodo Raiz
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
        public void Eliminar(int Codigo)
        {
            Raiz = EliminarNodo(Raiz, Codigo);
        }

        private clsNodo EliminarNodo(clsNodo R, int Codigo)
        {
            if (R == null) return null;

            if (Codigo < R.Codigo)
            {
                R.Izquierdo = EliminarNodo(R.Izquierdo, Codigo);
            }
            else if (Codigo > R.Codigo)
            {
                R.Derecho = EliminarNodo(R.Derecho, Codigo);
            }
            else
            {
                if (R.Izquierdo == null) return R.Derecho;
                if (R.Derecho == null) return R.Izquierdo;
                clsNodo menorDerecho = R.Derecho;
                while (menorDerecho.Izquierdo != null)
                    menorDerecho = menorDerecho.Izquierdo;
                R.Codigo = menorDerecho.Codigo;
                R.Nombre = menorDerecho.Nombre;
                R.Tramite = menorDerecho.Tramite;
                R.Derecho = EliminarNodo(R.Derecho, menorDerecho.Codigo);
            }
            return R;
        }

        public void Equilibrar()
        {
            List<clsNodo> lista = new List<clsNodo>();
            InOrdenLista(Raiz, lista);
            Raiz = ConstruirEquilibrado(lista, 0, lista.Count - 1);
        }

        private void InOrdenLista(clsNodo R, List<clsNodo> lista)
        {
            if (R == null) return;
            InOrdenLista(R.Izquierdo, lista);
            R.Izquierdo = null;
            R.Derecho = null;
            lista.Add(R);
            InOrdenLista(R.Derecho, lista);
        }

        private clsNodo ConstruirEquilibrado(List<clsNodo> lista, int ini, int fin)
        {
            if (ini > fin) return null;
            int mid = (ini + fin) / 2;
            clsNodo nodo = lista[mid];
            nodo.Izquierdo = ConstruirEquilibrado(lista, ini, mid - 1);
            nodo.Derecho = ConstruirEquilibrado(lista, mid + 1, fin);
            return nodo;
        }

        public void PostOrden(DataGridView Dgv, clsNodo R)
        {
            if (R == null) return;
            PostOrden(Dgv, R.Izquierdo);
            PostOrden(Dgv, R.Derecho);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }
        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }
    }
}
