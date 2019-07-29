using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using PMS_POS.View;
using PMS_POS.Model;

namespace PMS_POS.Controller
{
    class DocumentoC
    {
        MySqlConnection conex;
        string cadenaconex;

        public static int Agregar(Documento pNombreDocumento)
        {

            int retorno = 0;//Prueba 3

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into documento (NombreDocumento) values ('{0}')",
                pNombreDocumento.NombreDocumento), BDGeneral.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public MySqlConnection conexion()
        {
            cadenaconex = "server=localhost; database=hostal; Uid=root; pwd=root";
            conex = new MySqlConnection(cadenaconex);
            return conex;
        }

        protected void AbrirConexion()
        {
            conex.Open();
        }

        protected void Cerrarconexion()
        {
            conex.Close();
        }
    }
}


