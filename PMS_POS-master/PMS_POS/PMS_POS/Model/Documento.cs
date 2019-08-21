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
    class Documento : DocumentoC
    {
        string instruccion;

        public string NombreDocumento { get; set; }
        public string IdTipoDocumento { get; set; }


        public Documento() { }

        public Documento(string pNombreDocumento, string pIdTipoDocumento)

        {
            this.NombreDocumento = pNombreDocumento;
            this.IdTipoDocumento = pIdTipoDocumento;
        }

        public DataTable VistaTabla()
        {
            instruccion = "Select IdTipoDocumento, NombreDocumento from documento WHERE IsDeleted = 0 ORDER BY IdTipoDocumento ASC";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion());
            DataTable COnsulta = new DataTable();
            adp.Fill(COnsulta);
            return COnsulta;
        }

    }
}

