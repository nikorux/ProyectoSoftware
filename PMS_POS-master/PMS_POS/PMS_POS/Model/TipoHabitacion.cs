﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using PMS_POS.Controller;

namespace PMS_POS.Model
{
    class TipoHabitacion : TipoHabitacionC
    {
        string instruccion;

        public string NombreTipoHab { get; set; }

        public TipoHabitacion() { }

        public TipoHabitacion(string pNombreTipoHab)

        {
            this.NombreTipoHab = pNombreTipoHab;
        }

        public DataTable VistaTabla()
        {
            instruccion = "Select NombreTipoHab from tipo_habitacion";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion());
            DataTable COnsulta = new DataTable();
            adp.Fill(COnsulta);
            return COnsulta;
        }
    }
}

