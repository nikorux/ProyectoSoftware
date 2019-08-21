using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PMS_POS.Model
{
    class Factura_Reservacion
    {
        public int IdFactura { get; set; }
        public int IdReservacion { get; set; }
        public int IdHuesped { get; set; }
        public string Empleado { get; set; }
        public float SubTotal { get; set; }
        public float ITBIS { get; set; }
        public float Descuento { get; set; }
        public float TotalAPagar { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripción { get; set; }
        public float EfectivoRecibido { get; set; }
        public float Devuelta { get; set; }

        public string FormaDePago { get; set; }
        public string CompaniaTarjeta { get; set; }
        public int UltimosDigitos { get; set; }



        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public bool InsertEfectivo(Factura_Reservacion f)
        {
            //bool success = false;


            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "Insert into factura_reservacion (IdReservacion, IdHuesped, Empleado, Descuento, SubTotal, TotalAPagar, Fecha, FormaDePago, EfectivoRecibido, Devuelta) VALUES(@IdReservacion, @IdHuesped, @Empleado, @Descuento, @SubTotal, @TotalAPagar, @Fecha, @FormaDePago, @EfectivoRecibido, @Devuelta)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                //cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdReservacion", f.IdReservacion);          //1
                cmd.Parameters.AddWithValue("@IdHuesped", f.IdHuesped);                  //2
                cmd.Parameters.AddWithValue("@Empleado", f.Empleado);                    //
                cmd.Parameters.AddWithValue("@Descuento", f.Descuento);                  //
                cmd.Parameters.AddWithValue("@SubTotal", f.SubTotal);                    //3
                cmd.Parameters.AddWithValue("@TotalAPagar", f.TotalAPagar);              //4
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Today);                   //5
                cmd.Parameters.AddWithValue("@FormaDePago", f.FormaDePago);              //6
                cmd.Parameters.AddWithValue("@EfectivoRecibido", f.EfectivoRecibido);    //7
                cmd.Parameters.AddWithValue("@Devuelta", f.Devuelta);                    //8
               // cmd.Parameters.AddWithValue("@CompaniaTarjeta", f.CompaniaTarjeta);       //
               // cmd.Parameters.AddWithValue("@UltimosDigitos", f.UltimosDigitos);         //

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

        public bool InsertTarjeta(Factura_Reservacion f)
        {
            //bool success = false;


            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "Insert into factura_reservacion (IdReservacion, IdHuesped,Empleado,Descuento, SubTotal, TotalAPagar, Fecha, FormaDePago, CompaniaTarjeta, UltimosDigitos) VALUES(@IdReservacion, @IdHuesped,@Empleado,@Descuento, @SubTotal, @TotalAPagar, @Fecha, @FormaDePago, @CompaniaTarjeta,@UltimosDigitos)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                //cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdReservacion", f.IdReservacion);          //1
                cmd.Parameters.AddWithValue("@IdHuesped", f.IdHuesped);                  //2
                cmd.Parameters.AddWithValue("@Empleado", f.Empleado);                    //
                cmd.Parameters.AddWithValue("@Descuento", f.Descuento);                  //
                cmd.Parameters.AddWithValue("@SubTotal", f.SubTotal);                    //3
                cmd.Parameters.AddWithValue("@TotalAPagar", f.TotalAPagar);              //4
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Today);                   //5
                cmd.Parameters.AddWithValue("@FormaDePago", f.FormaDePago);              //6
               // cmd.Parameters.AddWithValue("@EfectivoRecibido", f.EfectivoRecibido);    //7
               // cmd.Parameters.AddWithValue("@Devuelta", f.Devuelta);                    //8
                cmd.Parameters.AddWithValue("@CompaniaTarjeta",f.CompaniaTarjeta);       // 9 
                cmd.Parameters.AddWithValue("@UltimosDigitos",f.UltimosDigitos);         // 10
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
        public bool InsertSinRecargo(Factura_Reservacion f)
        {
            //bool success = false;


            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "Insert into factura_reservacion (IdReservacion, IdHuesped, Empleado, SubTotal, TotalAPagar, Fecha, ) VALUES(@IdReservacion, @IdHuesped, @Empleado,  @SubTotal, @TotalAPagar, @Fecha)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                //cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdReservacion", f.IdReservacion);          //1
                cmd.Parameters.AddWithValue("@IdHuesped", f.IdHuesped);                  //2
                cmd.Parameters.AddWithValue("@Empleado", f.Empleado);                    //
               // cmd.Parameters.AddWithValue("@Descuento", f.Descuento);                  //
                cmd.Parameters.AddWithValue("@SubTotal", f.SubTotal);                    //3
                cmd.Parameters.AddWithValue("@TotalAPagar", f.TotalAPagar);              //4
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Today);                   //5
              //  cmd.Parameters.AddWithValue("@FormaDePago", f.FormaDePago);              //6
               // cmd.Parameters.AddWithValue("@EfectivoRecibido", f.EfectivoRecibido);    //7
             //   cmd.Parameters.AddWithValue("@Devuelta", f.Devuelta);                    //8
                                                                                         // cmd.Parameters.AddWithValue("@CompaniaTarjeta", f.CompaniaTarjeta);       //
                                                                                         // cmd.Parameters.AddWithValue("@UltimosDigitos", f.UltimosDigitos);         //

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
        public int SelectIdFactura()
        {
            int idReserv = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);


            try
            {
                //Select query
                string sql = "SELECT IdFacturaReservacion FROM factura_reservacion ORDER BY IdReservacion DESC LIMIT 1";// creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                return idReserv = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return idReserv;
        }





    }
}
