using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS_POS.Model;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace PMS_POS.Controller
{
    class CategoriaP
    {
        MySqlConnection conex;
        string cadenaconex;

        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;


        public bool Agregar(string categoria, int EnMostrador)
        {

            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "Insert into categoria (NombreCategoria, EnMostrador) values (@categoria, @EnMostrador)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@categoria", categoria);
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
        
    } }
