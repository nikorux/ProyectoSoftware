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

namespace PMS_POS.Controller
{
    class EmpleadoC
    {
        MySqlConnection conex;
        string cadenaconex;

        public static int Agregar(Empleado pEmpleado)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into empleado (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Rol, TipoDocumento, NumDocumento, Sexo, Telefono, Direccion, Ciudad, Provincia, Pais, Correo, Usuario, Contraseña) values ('{0}','{1}','{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}')",
                pEmpleado.PrimerNombre, pEmpleado.SegundoNombre, pEmpleado.PrimerApellido, pEmpleado.SegundoApellido, pEmpleado.RolEmpleado, pEmpleado.TipoDocumento, pEmpleado.NumDocumento, pEmpleado.Sexo, pEmpleado.Telefono, pEmpleado.Direccion, pEmpleado.Ciudad, pEmpleado.Provincia, pEmpleado.Pais, pEmpleado.Correo, pEmpleado.Usuario, pEmpleado.Contraseña), BDGeneral.ObtenerConexion()); //Conexión abierta

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

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
