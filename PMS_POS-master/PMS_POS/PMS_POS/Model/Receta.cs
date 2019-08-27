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
        public int IdInsumo_receta { get; set; }

        //tabla 'insumo_receta'
        public int IdInsumoReceta_InsumoReceta { get; set; }
        public int IdReceta_InsumoReceta { get; set; }
        public int IdInsumo_InsumoReceta { get; set; }
        public float CantidadInsumo_InsumoReceta { get; set; }
        public string UnidadMedida_InsumoReceta { get; set; }


        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;
        //----
        public bool UpdateEnTablaReceta(Receta x, int idReceta)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE receta SET NombreReceta=@NombreReceta, DescripcionReceta=@DescripcionReceta, ComentarioReceta=@ComentarioReceta WHERE @IdReceta=@idReceta";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NombreReceta", x.NombreReceta_receta);
                cmd.Parameters.AddWithValue("@DescripcionReceta", x.DescripcionReceta_receta);
                cmd.Parameters.AddWithValue("@ComentarioReceta", x.ComentarioReceta_receta);
                cmd.Parameters.AddWithValue("@idReceta", idReceta);
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

        public bool UpdateEnTablaInsumoReceta(Receta x, int idReceta, int idInsumo)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE insumo_receta SET IdReceta=@idReceta, IdInsumo=@idInsumo, CantidadInsumo=@CantidadInsumo, UnidadMedida=@UnidadMedida WHERE IdReceta=@idReceta AND IdInsumo=@idInsumo";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdReceta", idReceta);
                cmd.Parameters.AddWithValue("@IdInsumo", idInsumo);
                cmd.Parameters.AddWithValue("@CantidadInsumo", x.CantidadInsumo_InsumoReceta);
                cmd.Parameters.AddWithValue("@UnidadMedida", x.UnidadMedida_InsumoReceta);
                cmd.Parameters.AddWithValue("@idReceta", idReceta);
                cmd.Parameters.AddWithValue("@idInsumo", idInsumo);
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

        public bool InsertEnTablaReceta(string NombreReceta, string DescripcionReceta, string ComentarioReceta, int IdInsumo)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO receta (NombreReceta, DescripcionReceta, ComentarioReceta, IdInsumo) VALUES (@NombreReceta, @DescripcionReceta, @ComentarioReceta, @idInsumo)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NombreReceta", NombreReceta);
                cmd.Parameters.AddWithValue("@DescripcionReceta", DescripcionReceta);
                cmd.Parameters.AddWithValue("@ComentarioReceta", ComentarioReceta);
                cmd.Parameters.AddWithValue("@idInsumo", IdInsumo);
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

        public bool InsertEnTablaInsumoReceta(int IdReceta, int IdInsumo, string NombreInsumo, float CantidadInsumo, string UnidadMedida)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO insumo_receta (IdReceta, IdInsumo, NombreInsumo, CantidadInsumo, UnidadMedida) VALUES (@IdReceta, @IdInsumo, @NombreInsumo, @CantidadInsumo, @UnidadMedida)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdReceta", IdReceta);
                cmd.Parameters.AddWithValue("@IdInsumo", IdInsumo);
                cmd.Parameters.AddWithValue("@NombreInsumo", NombreInsumo);
                cmd.Parameters.AddWithValue("@CantidadInsumo", CantidadInsumo);
                cmd.Parameters.AddWithValue("@UnidadMedida", UnidadMedida);
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

        public int SearchIdRecetaDelIdInsumo(int idInsumo)
        {
            int IdInsumo = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT IdReceta FROM receta WHERE IdInsumo=@idInsumo";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idInsumo", idInsumo);
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

        public int CountRecetasRegistradas()
        {
            int cantRecetas = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT COUNT(*) FROM receta";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                return cantRecetas = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return cantRecetas;
        }

        public int CountInsumosRegistrados()
        {
            int cantRecetas = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT COUNT(*) FROM insumo";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                return cantRecetas = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return cantRecetas;
        }

        public DataTable SearchProductosEnReceta(int IdReceta)
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT IdInsumo, NombreInsumo, CantidadInsumo, UnidadMedida FROM hostal.insumo_receta WHERE IdReceta=@idReceta AND IsDeleted=0";
                // creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idReceta", IdReceta);
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                dt.Columns["IdInsumo"].ColumnName = "##";
                dt.Columns["NombreInsumo"].ColumnName = "Nombre";
                dt.Columns["CantidadInsumo"].ColumnName = "Cantidad";
                dt.Columns["UnidadMedida"].ColumnName = "Unidad Medida";
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
                string sql = "SELECT IdInsumo FROM insumo ORDER BY IdInsumo DESC LIMIT 1";
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

        public string SearchDescripcionReceta(int IdReceta)
        {
            string NombreInsumo = null;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT DescripcionReceta FROM receta WHERE IdReceta=@idReceta AND IsDeleted=0";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idReceta", IdReceta);
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

        public string SearchComentarioReceta(int IdReceta)
        {
            string NombreInsumo = null;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT ComentarioReceta FROM receta WHERE IdReceta=@idReceta AND IsDeleted=0";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idReceta", IdReceta);
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

        public bool DeleteTablaRelacionalReceta(int idReceta)
        {
            //Create Sql Connection
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                //Sql to delete
                string sql = "UPDATE hostal.insumo_receta SET IsDeleted = @IsDeleted, DeletedDate = @DeletedDated WHERE IdReceta = @idReceta";
                //Creating SQL Command
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdInsumo", idReceta);
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

        //Delete ingrediente de la receta
        public bool Delete(int idReceta)
        {
            bool error = DeleteTablaRelacionalReceta(idReceta);

            if(error == true)
            {
                //Create Sql Connection
                using (MySqlConnection mySqlConn = new MySqlConnection(connString))
                {
                    //Sql to delete
                    string sql = "UPDATE hostal.receta SET IsDeleted=@IsDeleted, DeletedDate=@DeletedDated WHERE IdReceta=@idReceta";

                    //Creating SQL Command
                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@IdInsumo", idReceta);
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
            else
            {
                return false;
            }
        }

    }
}
