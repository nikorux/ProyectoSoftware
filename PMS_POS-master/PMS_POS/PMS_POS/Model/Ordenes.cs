using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS_POS.Model
{
    class Ordenes
    {
        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public DataTable SelectOrdenes()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM pedido WHERE IsDeleted=0 AND Fecha=@FechaDeHoy";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FechaDeHoy", DateTime.Now);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }

    
}
