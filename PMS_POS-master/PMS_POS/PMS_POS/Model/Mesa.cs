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
    class Mesa
    {
        public int IdMesa { get; set; }
        public string NombreMesa { get; set; }
        public string DescripcionMesa { get; set; }
        public int DisponibleMesa { get; set; }

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
                        sql = "SELECT * FROM mesa WHERE IsDeleted=0 AND Disponible=1";
                        break;
                    case "NO Disponible":
                        sql = "SELECT * FROM mesa WHERE IsDeleted=0 AND Disponible=0";
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

        public bool Insert(Mesa x)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO mesa (Nombre, Descripcion) VALUES (@NombreMesa, @DescripcionMesa)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NombreMesa", x.NombreMesa);
                cmd.Parameters.AddWithValue("@DescripcionMesa", x.DescripcionMesa);
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


        public bool Update(Mesa x)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE mesa SET NombreMesa=@NombreMesa, DescripcionMesa=@DescripcionMesa, DisponibleMesa=@DisponibleMesa WHERE IdMesa=@IdMesa";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdMesa", x.IdMesa);
                cmd.Parameters.AddWithValue("@NombreMesa", x.NombreMesa);
                cmd.Parameters.AddWithValue("@DescripcionMesa", x.DescripcionMesa);
                cmd.Parameters.AddWithValue("@DisponibleMesa", x.DisponibleMesa);
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
        public bool Delete(Mesa x)
        {
            //Create Sql Connection
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                //Sql to delete
                string sql = "UPDATE insumo SET IsDeleted=@IsDeleted, DeletedDate=@DeletedDated WHERE IdInsumo=@IdInsumo";

                //Creating SQL Command
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdMesa", x.IdMesa);
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
