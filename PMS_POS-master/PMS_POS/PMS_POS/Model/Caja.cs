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
    class Caja
    {
        public int IdCaja { get; set; }
        public string NombreCaja { get; set; }
        public string DescripcionCaja { get; set; }
        public int DisponibleCaja { get; set; }

        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public DataTable Select(string estado)
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            string sql = null;
            try
            {
                //Select query
                switch (estado)
                {
                    case "Disponible":
                        sql = "SELECT * FROM caja WHERE IsDeleted=0 AND Disponible=1";
                        break;
                    case "NO Disponible":
                        sql = "SELECT * FROM caja WHERE IsDeleted=0 AND Disponible=0";
                        break;
                }
                // creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Creating data adapter
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

        public bool Insert(Caja x)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO caja (NombreCaja, Descripcion) VALUES (@NombreCaja, @DescripcionCaja)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NombreCaja", x.NombreCaja);
                cmd.Parameters.AddWithValue("@DescripcionCaja", x.DescripcionCaja);
                int row = cmd.ExecuteNonQuery();
                mySqlConn.Close();
                if (row > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }


        public bool Update(Caja x)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE caja SET NombreCaja=@NombreCaja, Descripcion=@Descripcion, Disponible=@Disponible WHERE IdCaja=@IdCaja";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdCaja", x.IdCaja);
                cmd.Parameters.AddWithValue("@NombreCaja", x.NombreCaja);
                cmd.Parameters.AddWithValue("@Descripcion", x.DescripcionCaja);
                cmd.Parameters.AddWithValue("@Disponible", x.DisponibleCaja);
                int row = cmd.ExecuteNonQuery();
                mySqlConn.Close();
                if (row > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }


        //Delete
        public bool Delete(Caja x)
        {
            //Create Sql Connection
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                //Sql to delete
                string sql = "UPDATE caja SET IsDeleted=@IsDeleted, DeletedDate=@DeletedDated WHERE IdCaja=@IdCaja";

                //Creating SQL Command
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdCaja", x.IdCaja);
                cmd.Parameters.AddWithValue("@IsDeleted", 1);
                cmd.Parameters.AddWithValue("@DeletedDated", DateTime.Now);
                //Open Connection
                mySqlConn.Open();
                int row = cmd.ExecuteNonQuery();
                mySqlConn.Close();
                if (row > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
