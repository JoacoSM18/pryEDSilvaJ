using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryEDSilvaJ
{
    internal class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private string cadenaConexion1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        private string cadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";


        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion1;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";
                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Libro");
                Grilla.DataSource = DS.Tables["Libro"];
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Listar1(String tabla, DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion1;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, tabla);
                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables[tabla];
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }
        public void Listar(DataGridView Grilla, String varInstrucionSQL)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion1;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = varInstrucionSQL;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Resultado");
                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Resultado"];
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
            }
        }
    }
}
