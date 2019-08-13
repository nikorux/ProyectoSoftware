using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using PMS_POS.Controller;
using System.Configuration;

namespace PMS_POS.Model
{
    class Categoria
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public int EnMostrador { get; set; }


        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public DataTable Select()
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT * FROM categoria WHERE IsDeleted=0";
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

        public bool Insert(Categoria x)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO categoria (NombreCategoria, EnMostrador) VALUES (@NombreCategoria, @EnMostrador)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NombreCategoria", x.NombreCategoria);
                cmd.Parameters.AddWithValue("@EnMostrador", 1);
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


        public bool Update(Categoria x)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE categoria SET NombreCategoria=@NombreCategoria, EnMostrador=@EnMostrador WHERE IdCategoria=@IdCategoria";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdCategoria", x.IdCategoria);
                cmd.Parameters.AddWithValue("@NombreCategoria", x.NombreCategoria);
                cmd.Parameters.AddWithValue("@EnMostrador", x.EnMostrador);
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
        public bool Delete(Categoria x)
        {
            //Create Sql Connection
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                //Sql to delete
                string sql = "UPDATE categoria SET IsDeleted=@IsDeleted, DeletedDate=@DeletedDated WHERE IdCategoria=@IdCategoria";

                //Creating SQL Command
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdCategoria", x.IdCategoria);
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

        public bool UpdateEnMostrador(string nombre, int EnMostrador)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE categoria SET NombreCategoria=@nombre, EnMostrador=@EnMostrador WHERE NombreCategoria=@nombre";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@EnMostrador", EnMostrador);
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

        public bool Delete(int IdCategoria)
        {
            //Create Sql Connection
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                //Sql to delete
                string sql = "UPDATE categoria SET IsDeleted=@IsDeleted, DeletedDate=@DeletedDated WHERE IdCategoria=@IdCategoria";

                //Creating SQL Command
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdCategoria", IdCategoria);
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
