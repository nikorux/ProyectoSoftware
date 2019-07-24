using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS_POS.Model;
using PMS_POS.Controller;
using MySql.Data.MySqlClient;
using System.Data;

namespace PMS_POS.Model
{
    class EstadoHabitaciones : ReservacionC
    {
        string instruccion;

        public DataTable VistaTabla()
        {
            instruccion = "Select NumHab as Número, TipoHab as Tipo, Estado from habitacion";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion());
            DataTable COnsulta = new DataTable();
            adp.Fill(COnsulta);
            return COnsulta;
        }
       
    }
}
