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
    class Mostrador
    {
        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        /*public DataTable SelectItemsParaMenuConMatchingIdCategoria(int IdCategoria)
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT NombreInsumo FROM insumo WHERE IsDeleted=0 AND EnMostrador=1 AND IdCategoria=@idCategoria";
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
        }*/

        public string SelectEstadoPedido(string columna)
        {
            string sql = null;
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                switch (columna)
                {
                    case "Facturado":
                        sql = "SELECT * FROM pedido WHERE IsDeleted=0";
                        break;
                    case "Cancelado":
                        sql = "SELECT * FROM pedido WHERE IsDeleted=1";
                        break;
                    case "Todos":
                        sql = "SELECT * FROM pedido";
                        break;
                }
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@columna", columna);
                return cmd.ExecuteNonQuery().ToString();

            }
        }

        public DataTable SelectPedidos()
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT * FROM pedido";
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

        public DataTable SelectItemsDisponiblesParaMenu()
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT IdInsumo, NombreInsumo, UnidadMedida FROM insumo WHERE IsDeleted=0 AND EnMostrador=0";
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

        public DataTable SelectItemsEnMenu()
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT IdInsumo, NombreInsumo FROM insumo WHERE IsDeleted=0 AND EnMostrador=1";
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


        //Remover item del menu
        public bool UpdateRemoverDelMostrador(int IdInsumo)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE insumo SET EnMostrador=@EnMostrador WHERE IdInsumo=@IdInsumo";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdInsumo", IdInsumo);
                cmd.Parameters.AddWithValue("@EnMostrador", 0);
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

        //Mover un producto al menu
        public bool UpdateProductoAMenu(int IdInsumo)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE insumo SET EnMostrador=@EnMostrador WHERE IdInsumo=@IdInsumo";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdInsumo", IdInsumo);
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

        public bool UpdateHistorialPrecio(int IdInsumo, float PrecioModificado, float NuevoPrecio)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE historial_precio SET PrecioActual=@PrecioActual, PrecioCancelado=@PrecioCancelado, FechaCancelado=@FechaCancelado WHERE IdInsumo=@IdInsumo";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@PrecioActual", NuevoPrecio);
                cmd.Parameters.AddWithValue("@PrecioCancelado", PrecioModificado);
                cmd.Parameters.AddWithValue("@FechaCancelado", DateTime.Now);
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

        //===============================================================================================
        //===============================================================================================
        //===============================================================================================
        //===============================================================================================
        //===============================================================================================


        public DataTable FiltrarPORmesa(string NombreMesa)
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT IdFactura FROM factura_mostrador WHERE IdCategoria=@nombreMesa AND Pagado=0";
                // creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombreMesa", NombreMesa);
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

        public string SearchNombreClienteFROMIdFactura(int idFactura)
        {
            string resp = null;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT NombreCliente FROM factura_mostrador WHERE IdFactura=@idFactura AND Pagado=0";// creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idFactura", idFactura);
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                return resp = cmd.ExecuteScalar().ToString();
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

        public DataTable SelectOrdenesAbiertas()
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "select IdFacturaMostrador, NombreCliente from factura_mostrador where Pagado=0";
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

        public DataTable SelectInsumosDisponibleParaMostrador()
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT * FROM insumo WHERE IsDeleted=0 AND EnMostrador=1";
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

        public int CantidadDeFacturas()
        {
            int resp = -1;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "select count(*) from factura_mostrador";// creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
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

        public int CantidadDePedidos()
        {
            int resp = -1;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "select count(*) from pedido";// creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
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

        public int CantidadDeOrdenes()
        {
            int resp = -1;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "select count(*) from factura_mostrador where Pagado=1";// creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
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
        //------COPIADAS DE LA CLASE PRODUCTO.CS DEL REPO

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
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool InsertFactura(string NombreCliente, string FormaDePago, float ITBIS, float SubTotal, float Total, int Pagado)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO factura_mostrador (NombreCliente, TipoFactura, Fecha, FormaDePago, ITBIS, SubTotal, Total, Pagado) VALUES (@NombreCliente, @TipoFactura, @Fecha, @FormaDePago, @ITBIS, @SubTotal, @Total, @Pagado)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NombreCliente", NombreCliente);
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@ITBIS", ITBIS);
                cmd.Parameters.AddWithValue("@SubTotal", SubTotal);
                cmd.Parameters.AddWithValue("@Total", Total);
                cmd.Parameters.AddWithValue("@TipoFactura", "Mostrador");
                cmd.Parameters.AddWithValue("@Pagado", Pagado);
                cmd.Parameters.AddWithValue("@FormaDePago", FormaDePago);
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

        public bool InsertPedido(string NombreCliente)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO pedido (NombreCliente, Fecha) VALUES (@NombreCliente, @Fecha)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NombreCliente", NombreCliente);
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Now);
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

        public bool InsertRelacionPedidoFactura(int IdPedido, int IdFactura, string nombreCliente)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO detalle_pedido (IdPedido, IdFactura, NombreClienteFactura) VALUES (@IdPedido, @IdFactura, @nombreCliente)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPedido", IdPedido);
                cmd.Parameters.AddWithValue("@IdFactura", IdFactura);
                cmd.Parameters.AddWithValue("@NombreClienteFactura", nombreCliente);
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

        public bool InsertRelacionFacturaInsumo(int IdFactura, int IdInsumo, float PrecioVenta, int CantidadComprada)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO facturamostrador_insumo (IdFacturaMostrador, IdInsumo, PrecioVenta, CantidadComprada) VALUES (@IdFactura, @IdInsumo, @PrecioVenta, @CantidadComprada)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdFactura", IdFactura);
                cmd.Parameters.AddWithValue("@IdInsumo", IdInsumo);
                cmd.Parameters.AddWithValue("@PrecioVenta", PrecioVenta);
                cmd.Parameters.AddWithValue("@CantidadComprada", CantidadComprada);
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

        public int SearchIdMesaFROMNombreMesa(string NombreMesa)
        {
            int IdCategoria = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT IdMesa FROM mesa WHERE NombreMesa=@NombreMesa";// creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NombreMesa", NombreMesa);
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

        public bool InsertRelacionFacturaMesa(string NombreMesa, int IdFactura, string NombreCliente)
        {
            int IdMesa = SearchIdMesaFROMNombreMesa(NombreMesa);
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO mesa_factura (IdMesa, IdFactura, NombreCliente, FechaHoraOcupada) VALUES (@IdMesa, @IdFactura, @NombreCliente, @FechaHoraOcupada)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdMesa", IdMesa);
                cmd.Parameters.AddWithValue("@IdFactura", IdFactura);
                cmd.Parameters.AddWithValue("@NombreCliente", NombreCliente);
                cmd.Parameters.AddWithValue("@FechaHoraOcupada", DateTime.Now);
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

        public int SelectIdPedidoCorrespondienteConIdFactura(int idFactura)
        {
            int resp = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT IdPedido FROM detalle_pedido WHERE IdFactura=@idFactura";// creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idFactura", idFactura);
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

        public DataTable SelectFacturasEnOrden(int IdPedido)
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT IdFactura FROM detalle_pedido WHERE IdPedido=@idPedido";
                // creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idPedido", IdPedido);
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

        public DataTable ItemsEnFactura(int IdFactura)//PENDIENTE
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT IdInsumo FROM facturamostrador_insumo WHERE IdFactura=@IdFactura";
                // creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdFactura", IdFactura);
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

        public string filldgvFacturaFromFacturaAbierta(string columna, int IdFactura, int idInsumo)//FIX PENDIENTE
        {
            string sql = null;
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                switch (columna)
                {
                    case "ID":
                        sql = "SELECT IdInsumo FROM facturamostrador_insumo WHERE IdFacturaMostrador=@IdFactura";
                        break;
                    case "Producto":
                        sql = "SELECT NombreInsumo FROM insumo WHERE IdInsumo=@idInsumo AND IdFactura=@IdFactura";
                        break;
                    case "Cantidad":
                        sql = "SELECT CantidadComprada FROM facturamostrador_insumo WHERE IdFacturaMostrador=@IdFactura";
                        break;
                    case "Precio":
                        sql = "SELECT PrecioVenta FROM facturamostrador_insumo WHERE IdFacturaMostrador=@IdFactura";
                        break;
                    case "ITBIS":
                        sql = "SELECT * FROM factura_mostrador WHERE IdFactura=@IdFactura";
                        break;
                }
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@columna", columna);
                cmd.Parameters.AddWithValue("@IdFactura", IdFactura);
                cmd.Parameters.AddWithValue("@idInsumo", idInsumo);
                return cmd.ExecuteNonQuery().ToString();

            }
        }

        public int encontrarIdFactura(int IdPedido, string NombreCliente)//PENDIENTE
        {
            int IdCategoria = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                //Select query
                string sql = "SELECT IdFactura FROM detalle_pedido WHERE IdPedido=@IdPedido AND NombreClienteFactura=@NombreCliente";// creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombreCategoria", IdPedido);
                cmd.Parameters.AddWithValue("@nombreCategoria", NombreCliente);
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
    }    
}