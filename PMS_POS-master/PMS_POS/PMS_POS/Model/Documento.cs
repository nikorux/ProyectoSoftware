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

        public Documento() { }

        public Documento(string pNombreDocumento)

        {
            this.NombreDocumento = pNombreDocumento;
        }

        public DataTable VistaTabla()
        {
            instruccion = "Select NombreDocumento from documento";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion());
            DataTable COnsulta = new DataTable();
            adp.Fill(COnsulta);
            return COnsulta;
        }

    }
}

