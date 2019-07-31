using System;
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
        public string IdTipoHab { get; set; }
        public string IsDeleted { get; set; }
        public string DeletedDate { get; set; }



        public TipoHabitacion() { }

        public TipoHabitacion(string pNombreTipoHab, string pIdTipoHab, string pIsDeleted, string pDeletedDate)

        {
            this.NombreTipoHab = pNombreTipoHab;
            this.IdTipoHab = pIdTipoHab;
            this.IsDeleted = pIsDeleted;
            this.DeletedDate = pDeletedDate;
        }

        public DataTable VistaTabla()
        {
            instruccion = "Select IdTipoHab, NombreTipoHab from tipo_habitacion where IsDeleted = 0";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion());
            DataTable COnsulta = new DataTable();
            adp.Fill(COnsulta);
            return COnsulta;
        }
    }
}

