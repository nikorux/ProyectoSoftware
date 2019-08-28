using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS_POS.Model;
using MySql.Data.MySqlClient;

namespace PMS_POS.Controller
{
    class TipoHabitacionC
    {
        MySqlConnection conex;
        string cadenaconex;

        public static int Agregar(TipoHabitacion pNombreTipoHab)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into tipo_habitacion (NombreTipoHab) values ('{0}')",
            pNombreTipoHab.NombreTipoHab), BDGeneral.ObtenerConexion());
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
