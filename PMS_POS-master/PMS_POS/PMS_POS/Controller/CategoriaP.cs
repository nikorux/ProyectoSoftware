using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS_POS.Model;
using MySql.Data.MySqlClient;

namespace PMS_POS.Controller
{
    class CategoriaP
    {
        MySqlConnection conex;
        string cadenaconex;

        public static int Agregar(Categoria categoria)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into categoria (NombreCategoria) values ('{0}')",
                categoria.NombreCategoria), BDGeneral.ObtenerConexion());
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
