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
    }
}
