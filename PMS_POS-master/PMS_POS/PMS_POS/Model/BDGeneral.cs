using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PMS_POS.Model
{
    class BDGeneral
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=hostal; Uid=root; pwd=root;");

            conectar.Open();
            return conectar;
        }
    }
}
