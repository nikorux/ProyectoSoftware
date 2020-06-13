using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace PMS_POS.Model
{
    public class Habitacion
    {

        //getters setters
       
        //fix encapsulación
        public int IdHabitacion { get; set; }
        public int NumHab { get; set; }
        public string TipoHab { get; set; }
        public int CantCamas { get; set; }
        public int MaxPersonas { get; set; }
        public int Piso { get; set; }
        public string Estado { get; set; }
        public string Plan { get; set; }
        public string Detalles { get; set; }
        public float PrecioPorNoche { get; set; }

        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public DataTable Select()
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT IdHabitacion, NumHab, TipoHab, CantCamas, MaxPersonas, Piso, Estado, Plan, Detalles, PrecioPorNoche FROM habitacion WHERE IsDeleted=0";
                // creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Creating data adapter
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable SelectBuscarHabitacion()
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT IdHabitacion, NumHab, TipoHab, CantCamas, MaxPersonas, Piso, Estado, Plan, Detalles, PrecioPorNoche,IsReserved FROM habitacion WHERE IsDeleted=0 ";
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
        public bool Insert(Habitacion h)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "INSERT INTO habitacion (NumHab,TipoHab,CantCamas,MaxPersonas,Piso,Estado,Plan,Detalles,PrecioPorNoche) VALUES(@NumHab,@TipoHab,@CantCamas,@MaxPersonas,@Piso,@Estado,@Plan,@Detalles,@PrecioPorNoche)";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn); 
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NumHab", h.NumHab);
                cmd.Parameters.AddWithValue("@TipoHab", h.TipoHab);
                cmd.Parameters.AddWithValue("@CantCamas", h.CantCamas);
                cmd.Parameters.AddWithValue("@MaxPersonas", h.MaxPersonas);
                cmd.Parameters.AddWithValue("@Piso", h.Piso);
                cmd.Parameters.AddWithValue("@Estado", h.Estado);
                cmd.Parameters.AddWithValue("@Plan", h.Plan);
                cmd.Parameters.AddWithValue("@Detalles", h.Detalles);
                cmd.Parameters.AddWithValue("@PrecioPorNoche", h.PrecioPorNoche);

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
        public bool Update(Habitacion h)
        {
            //SQL Connection
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                
                //SQL query Update
                string sql = "UPDATE habitacion SET NumHab=@NumHab, TipoHab=@TipoHab, CantCamas=@CantCamas, MaxPersonas=@MaxPersonas, Piso=@Piso, Estado=@Estado, Plan=@Plan, Detalles=@Detalles, PrecioPorNoche=@PrecioPorNoche WHERE IdHabitacion=@IdHabitacion";
              
                //Creating SQL Command
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdHabitacion", h.IdHabitacion);
                cmd.Parameters.AddWithValue("@NumHab", h.NumHab); 
                cmd.Parameters.AddWithValue("@TipoHab", h.TipoHab);
                cmd.Parameters.AddWithValue("@CantCamas", h.CantCamas);
                cmd.Parameters.AddWithValue("@MaxPersonas", h.MaxPersonas);
                cmd.Parameters.AddWithValue("@Piso", h.Piso);
                cmd.Parameters.AddWithValue("@Estado", h.Estado);
                cmd.Parameters.AddWithValue("@Plan", h.Plan);
                cmd.Parameters.AddWithValue("@Detalles", h.Detalles);
                cmd.Parameters.AddWithValue("@PrecioPorNoche", h.PrecioPorNoche);
              
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
        public bool Delete(Habitacion h)
        {
            //Create Sql Connection
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                //Sql to delete
                string sql = "UPDATE habitacion SET IsDeleted=@IsDeleted WHERE IdHabitacion=@IdHabitacion";

                //Creating SQL Command
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdHabitacion", h.IdHabitacion);
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
        public DataTable Search(string s)
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT * FROM habitacion WHERE IsDeleted=0 AND (NumHab like '%" + s + "%' OR TipoHab like '%" + s + "%')";
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
        public bool CambiarEstados(int idHabitacion, string estado)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                
                string sql = "UPDATE habitacion SET Estado=@Estado WHERE IdHabitacion=@IdHabitacion";

                //Creating SQL Command
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
                cmd.Parameters.AddWithValue("@Estado", estado);
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
        public DataTable GetHabitacion(int id)
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "SELECT * FROM habitacion where IdHabitacion = @IdHabitacion ";
                // creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdHabitacion", id);
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

        public bool IsReserved(int idHabitacion, Byte reserved)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {

                string sql = "UPDATE habitacion SET IsReserved=@IsReserved WHERE IdHabitacion=@IdHabitacion";

                //Creating SQL Command
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
                cmd.Parameters.AddWithValue("@IsReserved", reserved);
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
        public DataTable ReservationsInRoom(int IdHabitacion)
        {
            //hacer la conexion con sql
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                //Select query
                string sql = "Select IdReservacion, IdHabitacion, FechaLlegada, FechaSalida from reservacion where IsDeleted=0 AND IdHabitacion = @IdHabitacion;";
                // creating cmd using sql and conn
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdHabitacion", IdHabitacion);
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
    }
    
}
