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
        public int id { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
        public int historialPrecio { get; set; }
        public int idCategoria { get; set; }
        public int idReceta { get; set; }
        public bool EnMenu { get; set; }

        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public DataTable SelectItemsParaMenuConMatchingIdCategoria(int IdCategoria)
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

        public DataTable SelectItemsListMenu(string categoria)
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT NombreInsumo FROM insumo WHERE IsDeleted=0 AND EnMostrador=1 WHERE NombreCategoria=@nombreCategoria";
                // creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombreCategoria", categoria);
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

        //Cuando se cree una receta
        public bool InsertMostradorComida(string tipoProducto, Mostrador x)
        {
            int row = 0;
            string sql = null;
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                switch (tipoProducto)
                {
                    case "Bebidas":
                        sql = "UPDATE bebida SET NombreBebida=@nombre, PrecioBebida=@precio, IdHistorialPrecio=@historialPrecio, IdCategoria=@idCategoria, IdReceta=@idReceta, EnMostrador=@EnMostrador WHERE IdInsumo=@id";
                        break;
                    case "Plato":
                        sql = "UPDATE plato SET NombrePlato=@nombre, PrecioPlato=@precio, IdHistorialPrecio=@historialPrecio, IdCategoria=@idCategoria, IdReceta=@idReceta, EnMostrador=@EnMostrador WHERE IdInsumo=@id";
                        break;
                }
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", x.id);
                cmd.Parameters.AddWithValue("@nombre", x.nombre);
                cmd.Parameters.AddWithValue("@precio", x.precio);
                cmd.Parameters.AddWithValue("@historialPrecio", x.historialPrecio);
                cmd.Parameters.AddWithValue("@idCategoria", x.idCategoria);
                cmd.Parameters.AddWithValue("@idReceta", x.idReceta);
                cmd.Parameters.AddWithValue("@EnMostrador", 1);
                row = cmd.ExecuteNonQuery();
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

    }
}
