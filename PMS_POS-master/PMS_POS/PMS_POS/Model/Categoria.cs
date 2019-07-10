using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using PMS_POS.Controller;

namespace PMS_POS.Model
{
    class Categoria : CategoriaP
    {
        string instruccion;

        public string NombreCategoria { get; set; }

        public Categoria() { }

        public Categoria(string NombreCategoria)

        {
            this.NombreCategoria = NombreCategoria;
        }

        public DataTable VistaTabla()
        {
            //
            instruccion = "Select NombreCategoria from categoria";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion());
            DataTable COnsulta = new DataTable();
            adp.Fill(COnsulta);
            return COnsulta;
        }
    }
}
