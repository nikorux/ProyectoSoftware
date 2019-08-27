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
    class Mesa
    {
        public int IdMesa { get; set; }
        public string NombreMesa { get; set; }
        public string DescripcionMesa { get; set; }
        public int DisponibleMesa { get; set; }
        public string NombreCaja { get; set; }

        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;

        public int SearchIdMesa(string NombreMesa, string NombreCaja)
        {
            int IdMesa = 0;
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                string sql = "SELECT IdMesa FROM mesa WHERE Nombre=@NombreMesa AND NombreCaja=@NombreCaja";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NombreMesa", NombreMesa);
                cmd.Parameters.AddWithValue("@NombreCaja", NombreCaja);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                return IdMesa = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }
            catch (Exception /* ex*/)
            {

            }
            finally
            {
                conn.Close();
            }
            return IdMesa;
        }

        public bool UpdateHacerTODASMesasNODisponibles(string NombreCaja)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE mesa SET Disponible=@Disponible WHERE NombreCaja=@NombreCaja";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Disponible", 0);
                cmd.Parameters.AddWithValue("@NombreCaja", NombreCaja);
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

        public bool UpdateHacerTODASMesasDisponibles(string NombreCaja)
        {
            using (MySqlConnection mySqlConn = new MySqlConnection(connString))
            {
                string sql = "UPDATE mesa SET Disponible=@Disponible WHERE NombreCaja=@NombreCaja";
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Disponible", 1);
                cmd.Parameters.AddWithValue("@NombreCaja", NombreCaja);
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

        public bool UpdateHacerMesaDisponible(int IdMesa)
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(connString))
                {
                    string sql = "UPDATE mesa SET Disponible=@Disponible WHERE IdMesa=@IdMesa";
                    mySqlConn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@IdMesa", IdMesa);
                    cmd.Parameters.AddWithValue("@Disponible", 1);
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

            public bool UpdateHacerMesaNODisponible(int IdMesa)
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(connString))
                {
                    string sql = "UPDATE mesa SET Disponible=@Disponible WHERE IdMesa=@IdMesa";
                    mySqlConn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@IdMesa", IdMesa);
                    cmd.Parameters.AddWithValue("@Disponible", 0);
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

            public DataTable MesasDisponibles(string NombreCaja)
            {
                MySqlConnection conn = new MySqlConnection(connString);
                DataTable dt = new DataTable();
                try
                {
                    string sql = "SELECT IdMesa, Nombre FROM mesa WHERE IsDeleted=0 AND Disponible=1 AND NombreCaja=@NombreCaja";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@NombreCaja", NombreCaja);
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

            public DataTable MesasNODisponibles(string NombreCaja)
            {
                MySqlConnection conn = new MySqlConnection(connString);
                DataTable dt = new DataTable();
                try
                {
                    string sql = "SELECT IdMesa, Nombre FROM mesa WHERE IsDeleted=0 AND Disponible=0 AND NombreCaja=@NombreCaja";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@NombreCaja", NombreCaja);
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
            public int countMesas()
            {
                int resp = 1;
                //hacer la conexion con sql
                MySqlConnection conn = new MySqlConnection(connString);

                try
                {
                    //Select query
                    string sql = "SELECT count(*) FROM mesa";// creating cmd using sql and conn
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    //Creating data adapter
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    conn.Open();
                    return resp += Convert.ToInt32(cmd.ExecuteScalar());
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

            public DataTable Select(string estado)
            {
                //hacer la conexion con sql
                MySqlConnection conn = new MySqlConnection(connString);
                DataTable dt = new DataTable();
                string sql = null;
                try
                {
                    //Select query
                    switch (estado)
                    {
                        case "Disponible":
                            sql = "SELECT * FROM mesa WHERE IsDeleted=0 AND Disponible=1";
                            break;
                        case "NO Disponible":
                            sql = "SELECT * FROM mesa WHERE IsDeleted=0 AND Disponible=0";
                            break;
                    }
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

            public bool Insert(Mesa x)
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(connString))
                {
                    string sql = "INSERT INTO mesa (Nombre, Descripcion, Disponible, NombreCaja) VALUES (@NombreMesa, @DescripcionMesa, @Disponible, @NombreCaja)";
                    mySqlConn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@NombreMesa", x.NombreMesa);
                    cmd.Parameters.AddWithValue("@DescripcionMesa", x.DescripcionMesa);
                    cmd.Parameters.AddWithValue("@Disponible", x.DisponibleMesa);
                    cmd.Parameters.AddWithValue("@NombreCaja", x.NombreCaja);
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

            public bool Update(Mesa x)
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(connString))
                {
                    string sql = "UPDATE mesa SET Nombre=@Nombre, Descripcion=@Descripcion, Disponible=@Disponible, NombreCaja=@NombreCaja WHERE IdMesa=@IdMesa";
                    mySqlConn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@IdMesa", x.IdMesa);
                    cmd.Parameters.AddWithValue("@Nombre", x.NombreMesa);
                    cmd.Parameters.AddWithValue("@Descripcion", x.DescripcionMesa);
                    cmd.Parameters.AddWithValue("@Disponible", x.DisponibleMesa);
                    cmd.Parameters.AddWithValue("@NombreCaja", x.NombreCaja);
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
            public bool Delete(Mesa x)
            {
                //Create Sql Connection
                using (MySqlConnection mySqlConn = new MySqlConnection(connString))
                {
                    //Sql to delete
                    string sql = "UPDATE mesa SET IsDeleted=@IsDeleted, DeletedDate=@DeletedDated WHERE IdMesa=@IdMesa";
                    //Creating SQL Command
                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@IdMesa", x.IdMesa);
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
