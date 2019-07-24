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
        public int IdReservacion { get; set; }
        public int IdHuesped { get; set; }
        public float SubTotal { get; set; }
        public float ITBIS { get; set; }
        public float TotalAPagar { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripción { get; set; }
        public string FormaDePago { get; set; }
        public float EfectivoRecibido { get; set; }
        public float Devuelta { get; set; }


        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public bool Insert(Factura_Reservacion f)
        {
            //bool success = false;


            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "Insert into factura_reservacion (IdReservacion, IdHuesped, SubTotal, TotalAPagar, Fecha, FormaDePago, EfectivoRecibido, Devuelta) VALUES(@IdReservacion, @IdHuesped, @SubTotal, @TotalAPagar, @Fecha, @FormaDePago, @EfectivoRecibido, @Devuelta)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                //cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdReservacion", f.IdReservacion);
                cmd.Parameters.AddWithValue("@IdHuesped", f.IdHuesped);
                cmd.Parameters.AddWithValue("@SubTotal", f.SubTotal);
                cmd.Parameters.AddWithValue("@TotalAPagar", f.TotalAPagar);
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Today);
                cmd.Parameters.AddWithValue("@FormaDePago", f.FormaDePago);
                cmd.Parameters.AddWithValue("@EfectivoRecibido", f.EfectivoRecibido);
                cmd.Parameters.AddWithValue("@Devuelta", f.Devuelta);

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
