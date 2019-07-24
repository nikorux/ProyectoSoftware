using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PMS_POS.Controller;


namespace PMS_POS.Model
{
    class Reservacion : ReservacionC
    {
        string instruccion;

        public int IdReservacion { get; set; }
        public int IdHuesped { get; set; }
        public DateTime FechaLlegada { get; set; }
        public DateTime FechaSalida { get; set; }
        public int CantidadNoches { get; set; }
        public int CantidadAdultos { get; set; }
        public int CantidadInfantes { get; set; }
        public string Canal { get; set; }
        public string Comentario { get; set; }
        public float PrecioPorNoche { get; set; }
        public float TotalPorEstadia { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public string EstadoReservacion { get; set; }
        public int IdHabitacion { get; set; }

        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public float calcularTotalNoches(int cantidadDiasEstadia, float precioXnoche)
        {
            float total;

            total = (cantidadDiasEstadia) * precioXnoche;

            return total;
        }

        public int SelectIdReservacion()
        {
            int idReserv = 0;
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);


            try
            {
                //Select query
                string sql = "SELECT IdReservacion FROM reservacion ORDER BY IdReservacion DESC LIMIT 1";// creating cmd using sql and conn
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

        public DataTable SelectHuesped(string idHuesped)
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT * FROM huesped WHERE IdHuesped=@idHuesped";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idHuesped", Convert.ToInt32(idHuesped));
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception /* ex*/)
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
                string sql = "SELECT * FROM reservacion WHERE IsDeleted = 0 ORDER BY IdReservacion DESC;";                // creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool Insert(Reservacion r)
        {
            //bool success = false;


            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO reservacion (IdHuesped,FechaLlegada,FechaSalida,CantNoches,CantAdultos,CantInfantes,Canal,Comentario,PrecioNoche,PrecioTotal,IdHabitacion) VALUES(@IdHuesped,@FechaLlegada,@FechaSalida,@CantNoches,@CantAdultos,@CantInfantes,@Canal,@Comentario,@PrecioNoche,@PrecioTotal,@IdHabitacion)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                //cmd.Prepare();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdHuesped", r.IdHuesped);
                cmd.Parameters.AddWithValue("@FechaLlegada", r.FechaLlegada);
                cmd.Parameters.AddWithValue("@FechaSalida", r.FechaSalida);
                cmd.Parameters.AddWithValue("@CantNoches", r.CantidadNoches);
                cmd.Parameters.AddWithValue("@CantAdultos", r.CantidadAdultos);
                cmd.Parameters.AddWithValue("@CantInfantes", r.CantidadInfantes);
                cmd.Parameters.AddWithValue("@Canal", r.Canal);
                cmd.Parameters.AddWithValue("@Comentario", r.Comentario);
                cmd.Parameters.AddWithValue("@PrecioNoche", r.PrecioPorNoche);
                cmd.Parameters.AddWithValue("@PrecioTotal", r.TotalPorEstadia);
                cmd.Parameters.AddWithValue("@IdHabitacion",r.IdHabitacion);

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

        public bool Insert_reservacion_habitacion(int idReserv, int idHabitacion)
        {
            //bool success = false
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO reservacion_hab (IdReservacion,IdHabitacion) VALUES(@IdReservacion,@IdHabitacion)";

                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdReservacion", idReserv);
                cmd.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
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
        public bool Update_reservacion_habitacion(int idReserv, int idHab)
        {
            //bool success = false
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE reservacion_hab SET IdHabitacion = @IdHabitacion WHERE IdReservacion = @IdReservacion";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdReservacion", idReserv);
                cmd.Parameters.AddWithValue("@IdHabitacion", idHab);
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
        public bool Update(Reservacion r)
        {
            //create a default type and return its default value to false
            //bool success = false;
            //SQL Connection
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {

                //SQL query Update
                string sql = "UPDATE reservacion SET FechaLlegada = @FechaLlegada, FechaSalida = @FechaSalida, CantNoches = @CantNoches, CantAdultos = @CantAdultos, CantInfantes = @CantInfantes, Canal = @Canal, Comentario = @Comentario, PrecioNoche = @PrecioNoche, PrecioTotal = @PrecioTotal, IdHabitacion = @IdHabitacion WHERE IdReservacion=@IdReservacion";

                //Creating SQL Command
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;

     
                cmd.Parameters.AddWithValue("@FechaLlegada", r.FechaLlegada);
                cmd.Parameters.AddWithValue("@FechaSalida", r.FechaSalida);
                cmd.Parameters.AddWithValue("@CantNoches", r.CantidadNoches);
                cmd.Parameters.AddWithValue("@CantAdultos", r.CantidadAdultos);
                cmd.Parameters.AddWithValue("@CantInfantes", r.CantidadInfantes);
                cmd.Parameters.AddWithValue("@Canal", r.Canal);
                cmd.Parameters.AddWithValue("@Comentario", r.Comentario);
                cmd.Parameters.AddWithValue("@PrecioNoche", r.PrecioPorNoche);
                cmd.Parameters.AddWithValue("@PrecioTotal", r.TotalPorEstadia);
                cmd.Parameters.AddWithValue("@IdHabitacion", r.IdHabitacion);
                cmd.Parameters.AddWithValue("@IdReservacion", r.IdReservacion);

        

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
        public bool Delete(Reservacion r)
        {
            //Create a default return value and sets its value to false
            //bool success = false;
            //Create Sql Connection
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                //Sql to delete
                string sql = "UPDATE reservacion SET IsDeleted = 1, DeletedDate=@CurrentDate WHERE IdReservacion = @IdReservacion";
                //Creating Sql Command
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.Parameters.AddWithValue("@IdReservacion", r.IdReservacion);
                cmd.Parameters.AddWithValue("@CurrentDate", DateTime.Now);
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

        public DataTable VistaTabla()
        {
            instruccion = "Select hostal.reservacion.IdReservacion,hostal.reservacion.IdHuesped,hostal.reservacion.IdHabitacion, hostal.reservacion.FechaLlegada,hostal.reservacion.FechaSalida,hostal.reservacion.CantNoches,hostal.reservacion.CantAdultos,hostal.reservacion.CantInfantes,hostal.reservacion.Canal,hostal.reservacion.Comentario,hostal.reservacion.PrecioNoche,hostal.reservacion.PrecioTotal,hostal.reservacion.FechaLlegada as Llegada, hostal.reservacion.FechaSalida as Salida, hostal.habitacion.NumHab as Habitacion, hostal.reservacion.EstadoReservacion as Estado, CONCAT(huesped.PrimerNombre, ' ', huesped.SegundoNombre, ' ', huesped.PrimerApellido,' ', hostal.huesped.SegundoApellido) as Nombre, hostal.huesped.Telefono as Contacto FROM hostal.reservacion INNER JOIN hostal.habitacion ON hostal.reservacion.IdHabitacion = hostal.habitacion.IdHabitacion INNER JOIN hostal.huesped ON hostal.reservacion.IdHuesped = hostal.huesped.IdHuesped WHERE reservacion.IsDeleted = 0 GROUP BY hostal.reservacion.FechaLlegada; ";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion());
            DataTable COnsulta = new DataTable();
            adp.Fill(COnsulta);
            return COnsulta;
        }
        public DataTable reservacion(int idReservacion)
        {
         

            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "Select hostal.reservacion.IdReservacion, hostal.reservacion.IdHuesped, hostal.reservacion.PrecioNoche, CONCAT(huesped.PrimerNombre, ' ',huesped.SegundoNombre, ' ',huesped.PrimerApellido, ' ',hostal.huesped.SegundoApellido) as Nombre, hostal.huesped.Telefono as Contacto, hostal.habitacion.NumHab as Habitación, hostal.habitacion.TipoHab as Tipo, hostal.habitacion.Piso as Piso, hostal.habitacion.Estado as Estado, hostal.habitacion.Plan as Plan, hostal.habitacion.Detalles as Detalles, hostal.habitacion.PrecioPorNoche as Precio_Noche, hostal.reservacion.PrecioTotal as Total FROM hostal.reservacion INNER JOIN hostal.habitacion ON hostal.reservacion.IdHabitacion = hostal.habitacion.IdHabitacion INNER JOIN hostal.huesped ON hostal.reservacion.IdHuesped = hostal.huesped.IdHuesped WHERE(reservacion.IsDeleted = 0 AND reservacion.IdReservacion = @idReservacion);  ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idReservacion", idReservacion);
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
        
    }
