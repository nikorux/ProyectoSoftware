namespace PMS_POS.View
{
    partial class VentasHOY
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCajaSeleccionada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAMPM = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBuscarFactura = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxFormaDePago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMostrarArticulos = new System.Windows.Forms.Button();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvVentas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.Location = new System.Drawing.Point(25, 137);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVentas.RowTemplate.Height = 35;
            this.dgvVentas.Size = new System.Drawing.Size(859, 404);
            this.dgvVentas.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtCajaSeleccionada);
            this.panel1.Controls.Add(this.picRefresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAMPM);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 52);
            this.panel1.TabIndex = 18;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseClick);
            // 
            // txtCajaSeleccionada
            // 
            this.txtCajaSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCajaSeleccionada.ForeColor = System.Drawing.Color.DarkRed;
            this.txtCajaSeleccionada.Location = new System.Drawing.Point(334, 10);
            this.txtCajaSeleccionada.Name = "txtCajaSeleccionada";
            this.txtCajaSeleccionada.ReadOnly = true;
            this.txtCajaSeleccionada.Size = new System.Drawing.Size(222, 31);
            this.txtCajaSeleccionada.TabIndex = 4;
            this.txtCajaSeleccionada.Text = "Seleccionar";
            this.txtCajaSeleccionada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(271, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Caja:";
            // 
            // lblAMPM
            // 
            this.lblAMPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMPM.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAMPM.Location = new System.Drawing.Point(784, 28);
            this.lblAMPM.Name = "lblAMPM";
            this.lblAMPM.Size = new System.Drawing.Size(55, 22);
            this.lblAMPM.TabIndex = 13;
            this.lblAMPM.Text = "XX";
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHora.Location = new System.Drawing.Point(709, 21);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(110, 29);
            this.lblHora.TabIndex = 15;
            this.lblHora.Text = "22:22";
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFecha.Location = new System.Drawing.Point(724, 1);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(115, 23);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "00/00/0000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // txtBuscarFactura
            // 
            this.txtBuscarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarFactura.Location = new System.Drawing.Point(25, 100);
            this.txtBuscarFactura.Name = "txtBuscarFactura";
            this.txtBuscarFactura.Size = new System.Drawing.Size(360, 24);
            this.txtBuscarFactura.TabIndex = 19;
            this.txtBuscarFactura.Text = "Buscar";
            this.txtBuscarFactura.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtBuscarFactura_MouseClick);
            this.txtBuscarFactura.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.DarkRed;
            this.txtBalance.Location = new System.Drawing.Point(603, 553);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(222, 31);
            this.txtBalance.TabIndex = 17;
            this.txtBalance.Text = "- - - ";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(528, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(831, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "DOP";
            // 
            // cbxFormaDePago
            // 
            this.cbxFormaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFormaDePago.FormattingEnabled = true;
            this.cbxFormaDePago.Items.AddRange(new object[] {
            "Todas",
            "Efectivo",
            "Tarjeta"});
            this.cbxFormaDePago.Location = new System.Drawing.Point(528, 100);
            this.cbxFormaDePago.Name = "cbxFormaDePago";
            this.cbxFormaDePago.Size = new System.Drawing.Size(172, 26);
            this.cbxFormaDePago.TabIndex = 21;
            this.cbxFormaDePago.SelectedIndexChanged += new System.EventHandler(this.CbxCategoria_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(400, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Forma de Pago:";
            // 
            // btnMostrarArticulos
            // 
            this.btnMostrarArticulos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMostrarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarArticulos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarArticulos.Location = new System.Drawing.Point(706, 99);
            this.btnMostrarArticulos.Name = "btnMostrarArticulos";
            this.btnMostrarArticulos.Size = new System.Drawing.Size(178, 27);
            this.btnMostrarArticulos.TabIndex = 23;
            this.btnMostrarArticulos.Text = "Mostrar artículo(s)";
            this.btnMostrarArticulos.UseVisualStyleBackColor = false;
            this.btnMostrarArticulos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnMostrarArticulos_MouseClick);
            // 
            // picRefresh
            // 
            this.picRefresh.Image = global::PMS_POS.Properties.Resources.refresh1;
            this.picRefresh.Location = new System.Drawing.Point(97, 7);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(39, 37);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 16;
            this.picRefresh.TabStop = false;
            this.picRefresh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicRefresh_MouseClick);
            // 
            // VentasHOY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 605);
            this.Controls.Add(this.btnMostrarArticulos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxFormaDePago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarFactura);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvVentas);
            this.Name = "VentasHOY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentasHOY";
            this.Load += new System.EventHandler(this.VentasHOY_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VentasHOY_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCajaSeleccionada;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAMPM;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtBuscarFactura;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxFormaDePago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMostrarArticulos;
    }
}