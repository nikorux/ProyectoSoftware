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
    class Categoria : CategoriaP
    {
        string instruccion;

        public string NombreCategoria { get; set; }
        public int EnMostrador { get; set; }

        public Categoria() { }

        public Categoria(string NombreCategoria)

        {
            this.NombreCategoria = NombreCategoria;
        }

        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public DataTable VistaTabla()
        {
            instruccion = "Select IdCategoria, NombreCategoria, EnMostrador from categoria";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion());
            DataTable COnsulta = new DataTable();
            adp.Fill(COnsulta);
            return COnsulta;
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
