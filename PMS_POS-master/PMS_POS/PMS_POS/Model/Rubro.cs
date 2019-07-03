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
    class Rubro : RubroC
    {
        string instruccion;

        public string NombreRubro { get; set; }

        public Rubro() { }

        public Rubro(string pNombreRubro)

        {
            this.NombreRubro = pNombreRubro;
        }

        public DataTable VistaTabla()
        {
            instruccion = "Select Nombre from rubro";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion());
            DataTable COnsulta = new DataTable();
            adp.Fill(COnsulta);
            return COnsulta;
        }
    }
}
