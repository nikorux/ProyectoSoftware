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
    class Receta
    {
        // tabla 'receta'
        public int IdReceta_receta { get; set; }
        public string NombreReceta_receta { get; set; }
        public string DescripcionReceta_receta { get; set; }
        public string ComentarioReceta_receta { get; set; }

        //tabla 'insumo_receta'
        public int IdInsumoReceta_InsumoReceta { get; set; }
        public int IdReceta_InsumoReceta { get; set; }
        public int IdInsumo_InsumoReceta { get; set; }
        public float CantidadInsumo_InsumoReceta { get; set; }
        public string UnidadMedida_InsumoReceta { get; set; }


        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public bool InsertEnTablaReceta(Receta x)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO receta (NombreReceta, DescripcionReceta, ComentarioReceta) VALUES (@NombreReceta, @DescripcionReceta, @ComentarioReceta)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NombreReceta", x.NombreReceta_receta);
                cmd.Parameters.AddWithValue("@DescripcionReceta", x.DescripcionReceta_receta);
                cmd.Parameters.AddWithValue("@ComentarioReceta", x.ComentarioReceta_receta);
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

        public bool InsertEnTablaInsumoReceta(Receta x)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO insumo_receta (IdReceta, IdInsumo, CantidadInsumo, UnidadMedida) VALUES (@IdReceta, @IdInsumo, @CantidadInsumo, @UnidadMedida)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdReceta", x.IdReceta_InsumoReceta);
                cmd.Parameters.AddWithValue("@IdInsumo", x.IdInsumo_InsumoReceta);
                cmd.Parameters.AddWithValue("@CantidadInsumo", x.CantidadInsumo_InsumoReceta);
                cmd.Parameters.AddWithValue("@UnidadMedida", x.UnidadMedida_InsumoReceta);
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

        public int SearchProductosEnReceta()
        {
            int IdReceta = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT r.NombreReceta, DescripcionReceta, ComentarioReceta, ir.CantidadInsumo, ir.UnidadMedida FROM hostal.receta r, hostal.insumo_receta ir";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                return IdReceta = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return IdReceta;
        }

        public int SearchIdRECETALastRecord()
        {
            int IdReceta = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT IdReceta FROM receta ORDER BY IdReceta DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                return IdReceta = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return IdReceta;
        }

        public int SearchIdINSUMOLastRecord()
        {
            int IdInsumo = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT IdInsumo FROM insumo ORDER BY IdReceta DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                return IdInsumo = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return IdInsumo;
        }

        public string SearchNombreUltimoProducto()
        {
            string NombreInsumo = null;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT NombreInsumo FROM insumo ORDER BY IdInsumo DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                return NombreInsumo = cmd.ExecuteScalar().ToString();
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return NombreInsumo;
        }

        /*public bool Delete()
        {
            //Create Sql Connection
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                //Sql to delete
                string sql = "UPDATE insumo SET IsDeleted=@IsDeleted, DeletedDate=@DeletedDated WHERE IdInsumo=@IdInsumo";

                //Creating SQL Command
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdInsumo", x.IdInsumo);
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
        }*/

    }
}
