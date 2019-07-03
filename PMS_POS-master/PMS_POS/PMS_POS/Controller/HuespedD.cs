using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using PMS_POS.View;
using PMS_POS.Model;

namespace PMS_POS.Model
{
    class HuespedD
    {
        MySqlConnection conex;
        string cadenaconex;

        public static int Agregar(Huesped pHuesped)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into huesped (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Compañia, NombreCompañia, TipoDocumento, NumDocumento, Sexo, Telefono, Direccion, Ciudad, Provincia, Pais, Correo) values ('{0}','{1}','{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}')",
                pHuesped.PrimerNombre, pHuesped.SegundoNombre, pHuesped.PrimerApellido, pHuesped.SegundoApellido, pHuesped.Compania, pHuesped.NombreCompania, pHuesped.TipoDocumento, pHuesped.NumDocumento, pHuesped.Sexo, pHuesped.Telefono, pHuesped.Direccion, pHuesped.Ciudad, pHuesped.Provincia, pHuesped.Pais, pHuesped.Correo), BDGeneral.ObtenerConexion()); //Conexión abierta

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        /*public static int Actualizar(Huesped pHuesped)
        {
            int retorno = 0;
            MySqlConnection conexion = BDGeneral.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update huesped set PrimerNombre='{0}', SegundoNombre='{1}', PrimerApellido='{2}', SegundoApellido='{3}', Compañia='{4}', NombreCompañia='{5}', TipoDocumento='{6}', NumDocumento='{7}', Sexo='{8}', Telefono='{9}', Direccion='{10}', Ciudad='{11}', Provincia='{12}', Pais='{13}', Correo='{14}' where IdHuesped={15}",
                pHuesped.PrimerNombre, pHuesped.SegundoNombre, pHuesped.PrimerApellido, pHuesped.SegundoApellido, pHuesped.Compania, pHuesped.NombreCompania, pHuesped.TipoDocumento, pHuesped.NumDocumento, pHuesped.Sexo, pHuesped.Telefono, pHuesped.Direccion, pHuesped.Ciudad, pHuesped.Provincia, pHuesped.Pais, pHuesped.Correo, pHuesped.IdHuesped), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }*/

        public MySqlConnection conexion()
        {
            cadenaconex = "server=localhost; database=hostal; Uid=root; pwd=root";
            conex = new MySqlConnection(cadenaconex);
            return conex;
        }

        protected void AbrirConexion()
        {
            conex.Open();
        }

        protected void Cerrarconexion()
        {
            conex.Close();
        }
    }
}
