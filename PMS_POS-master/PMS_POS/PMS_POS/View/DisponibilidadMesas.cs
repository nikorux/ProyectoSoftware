using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PMS_POS.Model;

namespace PMS_POS.View
{
    public partial class DisponibilidadMesas : Form
    {
        Mesa mesa = new Mesa();
        static public string Caja = null;
        public DisponibilidadMesas(string NombreCaja)
        {
            InitializeComponent();
            Caja = NombreCaja;
            dgvMesasDisponibles.DataSource = mesa.MesasDisponibles(NombreCaja);
            dgvMesasNODisponibles.DataSource = mesa.MesasNODisponibles(NombreCaja);
        }

        private void TxtMesasNODisponibles_TextChanged(object sender, EventArgs e)
        {
            dgvMesasNODisponibles.AllowUserToAddRows = false;

            if (txtMesasNODisponibles.Text != "" && txtMesasNODisponibles.Text != "Buscar")
            {

                dgvMesasNODisponibles.CurrentCell = null;
                foreach (DataGridViewRow n in dgvMesasNODisponibles.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvMesasNODisponibles.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtMesasNODisponibles.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvMesasNODisponibles.DataSource = mesa.MesasNODisponibles(Caja);
            }
        }

        private void TxtMesasDisponibles_TextChanged(object sender, EventArgs e)
        {
            dgvMesasDisponibles.AllowUserToAddRows = false;

            if (txtMesasDisponibles.Text != "" && txtMesasDisponibles.Text != "Buscar")
            {

                dgvMesasDisponibles.CurrentCell = null;
                foreach (DataGridViewRow n in dgvMesasDisponibles.Rows)
                {
                    n.Visible = false;
                }
                foreach (DataGridViewRow n in dgvMesasDisponibles.Rows)
                {
                    foreach (DataGridViewCell m in n.Cells)
                    {
                        if ((m.Value.ToString().ToUpper().IndexOf(txtMesasDisponibles.Text.ToUpper()) == 0))
                        {
                            n.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvMesasDisponibles.DataSource = mesa.MesasDisponibles(Caja);
            }
        }

        private void BtnRemoverItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvMesasNODisponibles.SelectedRows.Count > 0)
            {
                int IdMesa = Convert.ToInt32(dgvMesasNODisponibles.CurrentRow.Cells[0].Value);

                if (mesa.UpdateHacerMesaDisponible(IdMesa) == true)
                {

                }
                else
                {
                    MessageBox.Show("Error al cambiar el estado de mesa " + IdMesa + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvMesasDisponibles.DataSource = mesa.MesasDisponibles(Caja);
            dgvMesasNODisponibles.DataSource = mesa.MesasNODisponibles(Caja);
        }

        private void BtnAgregarItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvMesasDisponibles.SelectedRows.Count > 0)
            {
                int IdMesa = Convert.ToInt32(dgvMesasDisponibles.CurrentRow.Cells[0].Value);

                if (mesa.UpdateHacerMesaNODisponible(IdMesa) == true)
                {

                }
                else
                {
                    MessageBox.Show("Error al cambiar el estado de mesa" + IdMesa + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvMesasDisponibles.DataSource = mesa.MesasDisponibles(Caja);
            dgvMesasNODisponibles.DataSource = mesa.MesasNODisponibles(Caja);
        }
        private void DisponibilidadMesas_MouseClick(object sender, MouseEventArgs e)
        {
            txtMesasDisponibles.Text = "Buscar Mesa";
            txtMesasNODisponibles.Text = "Buscar Mesa";
        }

        private void LblMno_MouseClick(object sender, MouseEventArgs e)
        {
            txtMesasDisponibles.Text = "Buscar Mesa";
            txtMesasNODisponibles.Text = "Buscar Mesa";
        }

        private void Label1_MouseClick(object sender, MouseEventArgs e)
        {
            txtMesasDisponibles.Text = "Buscar Mesa";
            txtMesasNODisponibles.Text = "Buscar Mesa";
        }
    }
}
