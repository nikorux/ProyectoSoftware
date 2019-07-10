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
        public int IdCategoria { get; set; }
        public string DescripcionInsumo { get; set; }
        public int IdProveedor { get; set; }
        public float PrecioCompra { get; set; }
        public float PorcientoImpuesto { get; set; }
        public float Impuesto { get; set; }
        public float PrecioVenta { get; set; }
        public float CantActual { get; set; }
        public float CantMinima { get; set; }
        public float CantMaxima { get; set; }
        public string UnidadMedida { get; set; }

        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public string SelectNombreCategoriaFROMIdCategoria(int IdCategoria)
        {
            string NombreCategoriaP = null;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT NombreCategoria FROM categoria WHERE IdCategoria=@idCategoria";// creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idCategoria", IdCategoria);
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                return NombreCategoriaP = cmd.ExecuteScalar().ToString();
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return NombreCategoriaP;
        }

        public string SelectNombreCompaniaFROMIdProveedor(int IdProveedor)
        {
            string NombreCompaniaP = null;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT NombreCompañia FROM proveedor WHERE IdProveedor=@idProveedor";// creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idProveedor", IdProveedor);
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                return NombreCompaniaP = cmd.ExecuteScalar().ToString();
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return NombreCompaniaP;
        }

        public int SelectIdProveedorFROMnombreCompania(string NombreProveedor)
        {
            int IdProveedor = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT IdProveedor FROM proveedor WHERE NombreCompañia=@nombreProveedor";// creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombreProveedor", NombreProveedor);
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                return IdProveedor = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return IdProveedor;
        }

        public int SelectIdCategoria(string NombreCategoria)
        {
            int IdCategoria = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT IdCategoria FROM categoria WHERE NombreCategoria=@nombreCategoria";// creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombreCategoria", NombreCategoria);
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                return IdCategoria = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return IdCategoria;
        }

        public DataTable FiltrarPORcategoria(string NombreCategoria)
        {
            int IdCategoria = SelectIdCategoria(NombreCategoria);
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT * FROM insumo WHERE IdCategoria=@idCategoria AND IsDeleted=0";
                // creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idCategoria", IdCategoria);
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
                string sql = "INSERT INTO insumo (NombreInsumo, IdCategoria, DescripcionInsumo, Proveedor, PrecioCompra, PorcientoImpuesto, Impuesto, PrecioVenta, CantActual, CantMinima, CantMaxima, UnidadMedida) VALUES (@NombreInsumo, @IdCategoria, @DescripcionInsumo, @IdProveedor, @PrecioCompra, @PorcientoImpuesto, @Impuesto, @PrecioVenta, @CantActual, @CantMinima, @CantMaxima, @UnidadMedida)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NombreInsumo", x.NombreInsumo);
                cmd.Parameters.AddWithValue("@IdCategoria", x.IdCategoria);
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

        //actualiza el stock luego de que se calcule la conversion de unidades de medida
        public bool UpdateAjusteStock(int IdInsumo, float CantidadAjuste)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE insumo SET CantActual=@CantActual WHERE IdInsumo=@IdInsumo";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CantActual", CantidadAjuste);
                cmd.Parameters.AddWithValue("@IdInsumo", IdInsumo);
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
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE insumo SET NombreInsumo=@NombreInsumo, IdCategoria=@IdCategoria, DescripcionInsumo=@DescripcionInsumo, Proveedor=@IdProveedor, PrecioCompra=@PrecioCompra, PorcientoImpuesto=@PorcientoImpuesto, Impuesto=@Impuesto, PrecioVenta=@PrecioVenta, CantActual=@CantActual, CantMinima=@CantMinima, CantMaxima=@CantMaxima, UnidadMedida=@UnidadMedida WHERE IdInsumo=@IdInsumo";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NombreInsumo", x.NombreInsumo);
                cmd.Parameters.AddWithValue("@IdCategoria", x.IdCategoria);
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
                cmd.Parameters.AddWithValue("@IdInsumo", x.IdInsumo);
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
        }
    }
}