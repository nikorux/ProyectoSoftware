﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMS_POS.Controller;
using PMS_POS.Model;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace PMS_POS.View
{
    public partial class UserControlHabitaciones : UserControl
    {
        //ControllerHabitacion cHabitacion = new ControllerHabitacion();
        
        private static UserControlHabitaciones _instance;
        public static UserControlHabitaciones Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlHabitaciones();
                return _instance;
            }
        }
        public UserControlHabitaciones()
        {
            InitializeComponent();
        }

        Habitacion habitacion = new Habitacion();
        RegistrarHab regHab = new RegistrarHab();
 
        static string connString = ConfigurationManager.ConnectionStrings["cString"].ConnectionString;
        private void UserControlHabitaciones_Load(object sender, EventArgs e)
        {
             //Refrescar el data grid view
                 RefreshDgv();
                dgvHab.Columns[0].Visible = false;
        }       

 
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                habitacion.IdHabitacion = Convert.ToInt32(dgvHab.CurrentRow.Cells[0].Value);
                if (habitacion.Delete(habitacion) == true)
                {
                    MessageBox.Show("La habitación ha sido eliminada.");
                    

                }
                else
                {
                    MessageBox.Show("Error al editar los datos.)");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al borrar las habitación. (Error: " + ex + ")");
            }
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
           
            string message = "Quiere editar una habitación?";
            string title = "";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {

                if (dgvHab.SelectedRows.Count > 0)
                {
                    //Si las filas son más de 0 se muestran los valores de la fila y se actualiza el booleano "editar"
                    regHab.RecibirDatos(dgvHab.CurrentRow.Cells[0].Value.ToString(), dgvHab.CurrentRow.Cells[1].Value.ToString(), dgvHab.CurrentRow.Cells[2].Value.ToString(), Convert.ToInt32(dgvHab.CurrentRow.Cells[3].Value), Convert.ToInt32(dgvHab.CurrentRow.Cells[4].Value), Convert.ToInt32(dgvHab.CurrentRow.Cells[5].Value), dgvHab.CurrentRow.Cells[6].Value.ToString(), dgvHab.CurrentRow.Cells[7].Value.ToString(), dgvHab.CurrentRow.Cells[9].Value.ToString());
                    regHab.Show();
                   
                    
                   

                }
                else
                {
                    MessageBox.Show("Seleccione una fila.");
                }
            }
            else
            {
                
            }


        }
      
    

      

        private void Button1_Click(object sender, EventArgs e)
        {
            regHab.Show();
        }
        public void RefreshDgv()
        {
            dgvHab.DataSource = habitacion.Select();
        }

    }
}
