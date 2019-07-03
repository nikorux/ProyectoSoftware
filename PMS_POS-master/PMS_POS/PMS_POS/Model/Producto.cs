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
    class Producto
    {
        public int IdInsumo { get; set; }

        public string NombreInsumo { get; set; }
        public int IdRubro { get; set; }
        public string DescripcionInsumo { get; set; }
        public int IdProveedor { get; set; }
        public float PrecioCompra { get; set; }
        public float PorcientoImpuesto { get; set; }
        public string Impuesto { get; set; }
        public float PrecioVenta { get; set; }
        public float CantActual { get; set; }
        public float CantMinima { get; set; }
        public float CantMaxima { get; set; }
        public int UnidadMedida { get; set; }

        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public DataTable Select()
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT * FROM insumo WHERE IsDeleted=0";
                // creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool Insert(Producto x)
        {

            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO insumo (NombreInsumo, IdRubro, DescripcionInsumo, IdProveedor, PrecioCompra, PorcientoImpuesto, Impuesto, PrecioVenta, CantActual, CantMinima, CantMaxima, UnidadMedida) VALUES (@NombreInsumo, @IdRubro, @DescripcionInsumo, @IdProveedor, @PrecioCompra, @PorcientoImpuesto, @Impuesto, @PrecioVenta, @CantActual, @CantMinima, @CantMaxima, @UnidadMedida)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NombreInsumo", x.NombreInsumo);
                cmd.Parameters.AddWithValue("@IdRubro", x.IdRubro);
                cmd.Parameters.AddWithValue("@DescripcionInsumo", x.DescripcionInsumo);
                cmd.Parameters.AddWithValue("@IdProveedor", x.IdProveedor);
                cmd.Parameters.AddWithValue("@PrecioCompra", x.PrecioCompra);
                cmd.Parameters.AddWithValue("@PorcientoImpuesto", x.PorcientoImpuesto);
                cmd.Parameters.AddWithValue("@Impuesto", x.Impuesto);
                cmd.Parameters.AddWithValue("@PrecioVenta", x.PrecioVenta);
                cmd.Parameters.AddWithValue("@CantActual", x.CantActual);
                cmd.Parameters.AddWithValue("@CantMinima", x.CantMinima);
                cmd.Parameters.AddWithValue("@CantMaxima", x.CantMaxima);
                cmd.Parameters.AddWithValue("@UnidadMedida", x.UnidadMedida);

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


        //Update
        public bool Update(Producto x)
        {
            //SQL Connection
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {

                //SQL query Update
                string sql = "UPDATE insumo SET NombreInsumo=@NombreInsumo, IdRubro=@IdRubro, DescripcionInsumo=@DescripcionInsumo, IdProveedor=@IdProveedor, PrecioCompra=@PrecioCompra, PorcientoImpuesto=@PorcientoImpuesto, Impuesto=@Impuesto, PrecioVenta=@PrecioVenta, CantActual=@CantActual, CantMinima=@CantMinima, CantMaxima=@CantMaxima, UnidadMedida=@UnidadMedida WHERE IdInsumo=@IdInsumo";

                //Creating SQL Command
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NombreInsumo", x.NombreInsumo);
                cmd.Parameters.AddWithValue("@IdRubro", x.IdRubro);
                cmd.Parameters.AddWithValue("@DescripcionInsumo", x.DescripcionInsumo);
                cmd.Parameters.AddWithValue("@IdProveedor", x.IdProveedor);
                cmd.Parameters.AddWithValue("@PrecioCompra", x.PrecioCompra);
                cmd.Parameters.AddWithValue("@PorcientoImpuesto", x.PorcientoImpuesto);
                cmd.Parameters.AddWithValue("@Impuesto", x.Impuesto);
                cmd.Parameters.AddWithValue("@PrecioVenta", x.PrecioVenta);
                cmd.Parameters.AddWithValue("@CantActual", x.CantActual);
                cmd.Parameters.AddWithValue("@CantMinima", x.CantMinima);
                cmd.Parameters.AddWithValue("@CantMaxima", x.CantMaxima);
                cmd.Parameters.AddWithValue("@UnidadMedida", x.UnidadMedida);

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
        //Delete
        public bool Delete(Producto x)
        {
            //Create Sql Connection
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                //Sql to delete
                string sql = "UPDATE insumo SET IsDeleted=@IsDeleted WHERE IdInsumo=@IdInsumo";

                //Creating SQL Command
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdHabitacion", x.IdInsumo);
                cmd.Parameters.AddWithValue("@IsDeleted", 1);
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