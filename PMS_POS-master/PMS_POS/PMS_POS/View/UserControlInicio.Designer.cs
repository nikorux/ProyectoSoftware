namespace PMS_POS.View
{
    partial class UserControlInicio
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvEstadoHabitaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHabMantenimiento = new System.Windows.Forms.Panel();
            this.lblMantenimiento = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelHabLibres = new System.Windows.Forms.Panel();
            this.lblLibres = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelHabOcupadas = new System.Windows.Forms.Panel();
            this.lblOcupadas = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoHabitaciones)).BeginInit();
            this.panelHabMantenimiento.SuspendLayout();
            this.panelHabLibres.SuspendLayout();
            this.panelHabOcupadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgvEstadoHabitaciones);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(59, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(718, 286);
            this.panel4.TabIndex = 42;
            // 
            // dgvEstadoHabitaciones
            // 
            this.dgvEstadoHabitaciones.AllowUserToAddRows = false;
            this.dgvEstadoHabitaciones.AllowUserToDeleteRows = false;
            this.dgvEstadoHabitaciones.AllowUserToResizeColumns = false;
            this.dgvEstadoHabitaciones.AllowUserToResizeRows = false;
            this.dgvEstadoHabitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstadoHabitaciones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEstadoHabitaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoHabitaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstadoHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoHabitaciones.Location = new System.Drawing.Point(31, 64);
            this.dgvEstadoHabitaciones.Name = "dgvEstadoHabitaciones";
            this.dgvEstadoHabitaciones.ReadOnly = true;
            this.dgvEstadoHabitaciones.Size = new System.Drawing.Size(646, 197);
            this.dgvEstadoHabitaciones.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Estado Actual de las Habitaciones";
            // 
            // panelHabMantenimiento
            // 
            this.panelHabMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelHabMantenimiento.Controls.Add(this.lblMantenimiento);
            this.panelHabMantenimiento.Controls.Add(this.pictureBox7);
            this.panelHabMantenimiento.Controls.Add(this.label17);
            this.panelHabMantenimiento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHabMantenimiento.Location = new System.Drawing.Point(645, 100);
            this.panelHabMantenimiento.Name = "panelHabMantenimiento";
            this.panelHabMantenimiento.Size = new System.Drawing.Size(287, 91);
            this.panelHabMantenimiento.TabIndex = 4;
            // 
            // lblMantenimiento
            // 
            this.lblMantenimiento.AutoSize = true;
            this.lblMantenimiento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantenimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMantenimiento.Location = new System.Drawing.Point(233, 31);
            this.lblMantenimiento.Name = "lblMantenimiento";
            this.lblMantenimiento.Size = new System.Drawing.Size(23, 25);
            this.lblMantenimiento.TabIndex = 48;
            this.lblMantenimiento.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(96, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 23);
            this.label17.TabIndex = 1;
            this.label17.Text = "Mantenimiento";
            // 
            // panelHabLibres
            // 
            this.panelHabLibres.BackColor = System.Drawing.Color.LightGreen;
            this.panelHabLibres.Controls.Add(this.pictureBox1);
            this.panelHabLibres.Controls.Add(this.lblLibres);
            this.panelHabLibres.Controls.Add(this.label9);
            this.panelHabLibres.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHabLibres.Location = new System.Drawing.Point(352, 100);
            this.panelHabLibres.Name = "panelHabLibres";
            this.panelHabLibres.Size = new System.Drawing.Size(287, 91);
            this.panelHabLibres.TabIndex = 22;
            // 
            // lblLibres
            // 
            this.lblLibres.AutoSize = true;
            this.lblLibres.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLibres.Location = new System.Drawing.Point(191, 31);
            this.lblLibres.Name = "lblLibres";
            this.lblLibres.Size = new System.Drawing.Size(23, 25);
            this.lblLibres.TabIndex = 48;
            this.lblLibres.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(109, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Libres";
            // 
            // panelHabOcupadas
            // 
            this.panelHabOcupadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(210)))), ((int)(((byte)(109)))));
            this.panelHabOcupadas.Controls.Add(this.pictureBox2);
            this.panelHabOcupadas.Controls.Add(this.lblOcupadas);
            this.panelHabOcupadas.Controls.Add(this.label12);
            this.panelHabOcupadas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHabOcupadas.Location = new System.Drawing.Point(59, 100);
            this.panelHabOcupadas.Name = "panelHabOcupadas";
            this.panelHabOcupadas.Size = new System.Drawing.Size(287, 91);
            this.panelHabOcupadas.TabIndex = 21;
            // 
            // lblOcupadas
            // 
            this.lblOcupadas.AutoSize = true;
            this.lblOcupadas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupadas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOcupadas.Location = new System.Drawing.Point(221, 31);
            this.lblOcupadas.Name = "lblOcupadas";
            this.lblOcupadas.Size = new System.Drawing.Size(23, 25);
            this.lblOcupadas.TabIndex = 28;
            this.lblOcupadas.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(90, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ocupadas";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHora.Location = new System.Drawing.Point(867, 351);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(290, 91);
            this.lblHora.TabIndex = 46;
            this.lblHora.Text = "lblHora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFecha.Location = new System.Drawing.Point(938, 431);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(126, 46);
            this.lblFecha.TabIndex = 47;
            this.lblFecha.Text = "label7";
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox7.Image = global::PMS_POS.Properties.Resources.habitacion;
            this.pictureBox7.Location = new System.Drawing.Point(15, 11);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(71, 68);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Image = global::PMS_POS.Properties.Resources.habitacion;
            this.pictureBox1.Location = new System.Drawing.Point(14, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PMS_POS.Properties.Resources.habitacion;
            this.pictureBox2.Location = new System.Drawing.Point(13, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // UserControlInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.panelHabMantenimiento);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelHabLibres);
            this.Controls.Add(this.panelHabOcupadas);
            this.Name = "UserControlInicio";
            this.Size = new System.Drawing.Size(1287, 677);
            this.Load += new System.EventHandler(this.UserControlInicio_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoHabitaciones)).EndInit();
            this.panelHabMantenimiento.ResumeLayout(false);
            this.panelHabMantenimiento.PerformLayout();
            this.panelHabLibres.ResumeLayout(false);
            this.panelHabLibres.PerformLayout();
            this.panelHabOcupadas.ResumeLayout(false);
            this.panelHabOcupadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvEstadoHabitaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHabMantenimiento;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panelHabLibres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelHabOcupadas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.Label lblMantenimiento;
        private System.Windows.Forms.Label lblLibres;
        private System.Windows.Forms.Label lblOcupadas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
