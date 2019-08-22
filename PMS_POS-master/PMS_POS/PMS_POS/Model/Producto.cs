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
        public string NombreCaja { get; set; }
        public float PrecioCompra { get; set; }
        public float PorcientoImpuesto { get; set; }
        public float Impuesto { get; set; }
        public float PrecioVenta { get; set; }
        public float CantActual { get; set; }
        public float CantMinima { get; set; }
        public float CantMaxima { get; set; }
        public string UnidadMedida { get; set; }

        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public DataTable SelectItemsEnInventario()
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT IdInsumo, NombreInsumo FROM insumo WHERE IsDeleted=0";
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

        public string SelectNombreCategoriaFROMIdCategoria(int IdCategoria)
        {
            string NombreCategoriaP = null;
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
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
                string sql = "SELECT NombreCompañia FROM proveedor WHERE IdProveedor=@idProveedor";
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

        public int CheckSiProductTieneReceta(int idInsumo)
        {
            int resp = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT TieneReceta FROM insumo WHERE IdInsumo=@idInsumo";// creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idInsumo", idInsumo);
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                return resp = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return resp;
        }

        public int SelectIdProveedorFROMnombreCompania(string NombreProveedor)
        {
            int IdProveedor = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT IdProveedor FROM proveedor WHERE NombreCompañia=@nombreProveedor";
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
        public string getDetallesFacturas(string columna)
        {
            string sql = null;
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                switch (columna)
                {
                    case "Tarjeta":
                        sql = "SELECT * FROM factura WHERE FormaDePago=@columna";
                        break;
                    case "Efectivo":
                        sql = "SELECT * FROM factura WHERE FormaDePago=@columna";
                        break;
                    case "Compra proveedor":
                        sql = "SELECT * FROM factura WHERE TipoFactura=@columna";
                        break;
                    case "Mostrador":
                        sql = "SELECT * FROM factura WHERE TipoFactura=@columna";
                        break;
                    case "Pagada":
                        sql = "SELECT * FROM factura WHERE Pagado=1";
                        break;
                    case "Pendiente":
                        sql = "SELECT * FROM factura WHERE Pagado=0";
                        break;
                    case "Todas":
                        sql = "SELECT * FROM factura";
                        break;
                }
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@columna", columna);
                return cmd.ExecuteNonQuery().ToString();

            }
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
            catch (Exception)
            {
                
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable FiltrarPORproveedor(string NombreProveedor)
        {
            int IdProveedor = SelectIdProveedorFROMnombreCompania(NombreProveedor);
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT * FROM insumo WHERE Proveedor=@idProveedor AND IsDeleted=0";
                // creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idProveedor", IdProveedor);
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
                dt.Columns["IdInsumo"].ColumnName = "##";
                dt.Columns["NombreInsumo"].ColumnName = "Nombre";
                dt.Columns["DescripcionInsumo"].ColumnName = "Descripción";
                dt.Columns["PrecioCompra"].ColumnName = "Precio Compra";
                dt.Columns["PrecioVenta"].ColumnName = "Precio Venta";
                dt.Columns["CantActual"].ColumnName = "Cant. Actual";
                dt.Columns["CantMinima"].ColumnName = "Cant. Mínima";
                dt.Columns["CantMaxima"].ColumnName = "Cant. Máxima";
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

        public DataTable SelectFacturas()
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT * FROM factura";
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

        public DataTable SelectHistorialComprasProveedores()
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT * FROM historial_compra_insumo";
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

        public DataTable SelectAjustes()
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT * FROM ajustesinventario";
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

        public bool InsertAjuste(int IdInsumo, string NombreInsumo, string Accion, float CantidadAjuste, string UnidadMedida)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO insumo (IdInsumo, NombreInsumo, Accion, CantidadAjuste, UnidadMedida, DeleteDate) VALUES (@IdInsumo, @NombreInsumo, @Accion, @CantidadAjuste, @UnidadMedida, @DeleteDate)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdInsumo", IdInsumo);
                cmd.Parameters.AddWithValue("@NombreInsumo", NombreInsumo);
                cmd.Parameters.AddWithValue("@Accion", Accion);
                cmd.Parameters.AddWithValue("@CantidadAjuste", CantidadAjuste);
                cmd.Parameters.AddWithValue("@UnidadMedida", UnidadMedida);
                cmd.Parameters.AddWithValue("@DeleteDate", DateTime.Now);
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

        public DataTable SelectBebidas()
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT NombreBebida FROM bebida WHERE IsDeleted=0";
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

        public DataTable SelectPlato()
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT NombrePlato FROM plato WHERE IsDeleted=0";
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

        public bool Insert(Producto x, int EnMostrador)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO insumo (NombreInsumo, IdCategoria, DescripcionInsumo, Proveedor, NombreCaja, PrecioCompra, PorcientoImpuesto, Impuesto, PrecioVenta, CantActual, CantMinima, CantMaxima, UnidadMedida, EnMostrador) VALUES (@NombreInsumo, @IdCategoria, @DescripcionInsumo, @IdProveedor, @NombreCaja, @PrecioCompra, @PorcientoImpuesto, @Impuesto, @PrecioVenta, @CantActual, @CantMinima, @CantMaxima, @UnidadMedida, @EnMostrador)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NombreInsumo", x.NombreInsumo);
                cmd.Parameters.AddWithValue("@IdCategoria", x.IdCategoria);
                cmd.Parameters.AddWithValue("@DescripcionInsumo", x.DescripcionInsumo);
                cmd.Parameters.AddWithValue("@IdProveedor", x.IdProveedor);
                cmd.Parameters.AddWithValue("@NombreCaja", x.NombreCaja);
                cmd.Parameters.AddWithValue("@PrecioCompra", x.PrecioCompra);
                cmd.Parameters.AddWithValue("@PorcientoImpuesto", x.PorcientoImpuesto);
                cmd.Parameters.AddWithValue("@Impuesto", x.Impuesto);
                cmd.Parameters.AddWithValue("@PrecioVenta", x.PrecioVenta);
                cmd.Parameters.AddWithValue("@CantActual", x.CantActual);
                cmd.Parameters.AddWithValue("@CantMinima", x.CantMinima);
                cmd.Parameters.AddWithValue("@CantMaxima", x.CantMaxima);
                cmd.Parameters.AddWithValue("@UnidadMedida", x.UnidadMedida);
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
        public bool UpdateInsumoTieneReceta(int IdInsumo)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE insumo SET TieneReceta=1 WHERE IdInsumo=@IdInsumo";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
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

        public bool UpdateInsumoCantidad(int IdInsumo, float cant)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE insumo SET CantActual=@cant WHERE IdInsumo=@IdInsumo";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cant", cant);
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

        public int findCantidadActualInsumo(int idInsumo)
        {
            int resp = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT CantActual FROM insumo WHERE IdInsumo=@idInsumo";// creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idInsumo", idInsumo);
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                return resp = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return resp;
        }
    }
}