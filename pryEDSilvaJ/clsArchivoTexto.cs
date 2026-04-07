using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
//Agregamos un espacio de nombre
//Que tiene los metodos de procesamiento de archivos

namespace pryEDSilvaJ
{
    internal class clsArchivoTexto
    {
        //Creamos una variable publica para guardar el nombre del archivo
        public String NombArchivo = "Colores.txt";

        //Desarrollar los procedimientos
        public void Grabar()
        {
            StreamWriter AD = new StreamWriter(NombArchivo, true);
            AD.WriteLine("Hola!");
            AD.Close();
        }

        public void Grabar(String Dato)
        {
            StreamWriter AD = new StreamWriter(NombArchivo, true);
            AD.WriteLine(Dato);
            AD.Close();
        }

        public void Grabar (String Codigo,String Nombre)
        {
            StreamWriter AD = new StreamWriter(NombArchivo, true); //Abrir
            AD.Write(Codigo); //Grabar sin <ENTER>
            AD.Write(";"); //Grabar sin <ENTER>
            AD.WriteLine(Nombre); //Grabar con un <ENTER>
            AD.Close(); //Cerrar
        }
        public void Recorrer (ListBox lst)
        {
            String DatoLeido;
            lst.Items.Clear();
            StreamReader AD = new StreamReader(NombArchivo);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                lst.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

    }
}
