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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvEstadoHabitaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHabMantenimiento = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panelHabLibres = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelHabOcupadas = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvHabitacionesProximas = new System.Windows.Forms.DataGridView();
            this.btnVerDetallesProximas = new System.Windows.Forms.Button();
            this.btnRegistrarCheckOut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvHabitacionesReservadas = new System.Windows.Forms.DataGridView();
            this.btnVerDetallesReservadas = new System.Windows.Forms.Button();
            this.btnRegistrarCheckIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoHabitaciones)).BeginInit();
            this.panelHabMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panelHabLibres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelHabOcupadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacionesProximas)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacionesReservadas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dgvEstadoHabitaciones);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panelHabMantenimiento);
            this.panel4.Controls.Add(this.panelHabLibres);
            this.panel4.Controls.Add(this.panelHabOcupadas);
            this.panel4.Location = new System.Drawing.Point(56, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(559, 250);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoHabitaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstadoHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoHabitaciones.Location = new System.Drawing.Point(17, 108);
            this.dgvEstadoHabitaciones.Name = "dgvEstadoHabitaciones";
            this.dgvEstadoHabitaciones.ReadOnly = true;
            this.dgvEstadoHabitaciones.Size = new System.Drawing.Size(519, 114);
            this.dgvEstadoHabitaciones.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Estado Actual de las Habitaciones";
            // 
            // panelHabMantenimiento
            // 
            this.panelHabMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelHabMantenimiento.Controls.Add(this.pictureBox7);
            this.panelHabMantenimiento.Controls.Add(this.label17);
            this.panelHabMantenimiento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHabMantenimiento.Location = new System.Drawing.Point(360, 49);
            this.panelHabMantenimiento.Name = "panelHabMantenimiento";
            this.panelHabMantenimiento.Size = new System.Drawing.Size(176, 39);
            this.panelHabMantenimiento.TabIndex = 4;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::PMS_POS.Properties.Resources.habitacion;
            this.pictureBox7.Location = new System.Drawing.Point(6, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(52, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Mantenimiento";
            // 
            // panelHabLibres
            // 
            this.panelHabLibres.BackColor = System.Drawing.Color.LightGreen;
            this.panelHabLibres.Controls.Add(this.pictureBox3);
            this.panelHabLibres.Controls.Add(this.label9);
            this.panelHabLibres.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHabLibres.Location = new System.Drawing.Point(187, 49);
            this.panelHabLibres.Name = "panelHabLibres";
            this.panelHabLibres.Size = new System.Drawing.Size(162, 39);
            this.panelHabLibres.TabIndex = 22;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PMS_POS.Properties.Resources.habitacion;
            this.pictureBox3.Location = new System.Drawing.Point(6, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(52, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Libres";
            // 
            // panelHabOcupadas
            // 
            this.panelHabOcupadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(210)))), ((int)(((byte)(109)))));
            this.panelHabOcupadas.Controls.Add(this.pictureBox4);
            this.panelHabOcupadas.Controls.Add(this.label12);
            this.panelHabOcupadas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHabOcupadas.Location = new System.Drawing.Point(17, 49);
            this.panelHabOcupadas.Name = "panelHabOcupadas";
            this.panelHabOcupadas.Size = new System.Drawing.Size(159, 39);
            this.panelHabOcupadas.TabIndex = 21;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PMS_POS.Properties.Resources.habitacion;
            this.pictureBox4.Location = new System.Drawing.Point(6, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(52, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ocupadas";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.dgvHabitacionesProximas);
            this.panel7.Controls.Add(this.btnVerDetallesProximas);
            this.panel7.Controls.Add(this.btnRegistrarCheckOut);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.dateTimePicker2);
            this.panel7.Location = new System.Drawing.Point(645, 333);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(580, 253);
            this.panel7.TabIndex = 44;
            // 
            // dgvHabitacionesProximas
            // 
            this.dgvHabitacionesProximas.AllowUserToAddRows = false;
            this.dgvHabitacionesProximas.AllowUserToDeleteRows = false;
            this.dgvHabitacionesProximas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHabitacionesProximas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitacionesProximas.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHabitacionesProximas.Location = new System.Drawing.Point(23, 95);
            this.dgvHabitacionesProximas.Name = "dgvHabitacionesProximas";
            this.dgvHabitacionesProximas.ReadOnly = true;
            this.dgvHabitacionesProximas.Size = new System.Drawing.Size(532, 106);
            this.dgvHabitacionesProximas.TabIndex = 45;
            // 
            // btnVerDetallesProximas
            // 
            this.btnVerDetallesProximas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVerDetallesProximas.CausesValidation = false;
            this.btnVerDetallesProximas.FlatAppearance.BorderSize = 0;
            this.btnVerDetallesProximas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetallesProximas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetallesProximas.ForeColor = System.Drawing.Color.White;
            this.btnVerDetallesProximas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerDetallesProximas.Location = new System.Drawing.Point(150, 212);
            this.btnVerDetallesProximas.Name = "btnVerDetallesProximas";
            this.btnVerDetallesProximas.Size = new System.Drawing.Size(139, 27);
            this.btnVerDetallesProximas.TabIndex = 48;
            this.btnVerDetallesProximas.Text = "Ver detalles";
            this.btnVerDetallesProximas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerDetallesProximas.UseCompatibleTextRendering = true;
            this.btnVerDetallesProximas.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarCheckOut
            // 
            this.btnRegistrarCheckOut.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarCheckOut.CausesValidation = false;
            this.btnRegistrarCheckOut.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCheckOut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCheckOut.Location = new System.Drawing.Point(295, 212);
            this.btnRegistrarCheckOut.Name = "btnRegistrarCheckOut";
            this.btnRegistrarCheckOut.Size = new System.Drawing.Size(139, 27);
            this.btnRegistrarCheckOut.TabIndex = 47;
            this.btnRegistrarCheckOut.Text = "Registrar Check-Out";
            this.btnRegistrarCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarCheckOut.UseCompatibleTextRendering = true;
            this.btnRegistrarCheckOut.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(22, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "Habitaciones Próximas a Desocuparse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Fecha de salida";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(124, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(268, 25);
            this.dateTimePicker2.TabIndex = 42;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dgvHabitacionesReservadas);
            this.panel6.Controls.Add(this.btnVerDetallesReservadas);
            this.panel6.Controls.Add(this.btnRegistrarCheckIn);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Location = new System.Drawing.Point(57, 333);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(559, 253);
            this.panel6.TabIndex = 45;
            // 
            // dgvHabitacionesReservadas
            // 
            this.dgvHabitacionesReservadas.AllowUserToAddRows = false;
            this.dgvHabitacionesReservadas.AllowUserToDeleteRows = false;
            this.dgvHabitacionesReservadas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHabitacionesReservadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitacionesReservadas.Location = new System.Drawing.Point(29, 87);
            this.dgvHabitacionesReservadas.Name = "dgvHabitacionesReservadas";
            this.dgvHabitacionesReservadas.ReadOnly = true;
            this.dgvHabitacionesReservadas.Size = new System.Drawing.Size(501, 114);
            this.dgvHabitacionesReservadas.TabIndex = 45;
            // 
            // btnVerDetallesReservadas
            // 
            this.btnVerDetallesReservadas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVerDetallesReservadas.CausesValidation = false;
            this.btnVerDetallesReservadas.FlatAppearance.BorderSize = 0;
            this.btnVerDetallesReservadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetallesReservadas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetallesReservadas.ForeColor = System.Drawing.Color.White;
            this.btnVerDetallesReservadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerDetallesReservadas.Location = new System.Drawing.Point(147, 212);
            this.btnVerDetallesReservadas.Name = "btnVerDetallesReservadas";
            this.btnVerDetallesReservadas.Size = new System.Drawing.Size(139, 27);
            this.btnVerDetallesReservadas.TabIndex = 46;
            this.btnVerDetallesReservadas.Text = "Ver detalles";
            this.btnVerDetallesReservadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerDetallesReservadas.UseCompatibleTextRendering = true;
            this.btnVerDetallesReservadas.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarCheckIn
            // 
            this.btnRegistrarCheckIn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarCheckIn.CausesValidation = false;
            this.btnRegistrarCheckIn.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCheckIn.Location = new System.Drawing.Point(297, 212);
            this.btnRegistrarCheckIn.Name = "btnRegistrarCheckIn";
            this.btnRegistrarCheckIn.Size = new System.Drawing.Size(139, 27);
            this.btnRegistrarCheckIn.TabIndex = 45;
            this.btnRegistrarCheckIn.Text = "Registrar Check-In";
            this.btnRegistrarCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarCheckIn.UseCompatibleTextRendering = true;
            this.btnRegistrarCheckIn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Habitaciones Reservadas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Fecha de entrada";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 25);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHora.Location = new System.Drawing.Point(732, 110);
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
            this.lblFecha.Location = new System.Drawing.Point(803, 190);
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
            // UserControlInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Name = "UserControlInicio";
            this.Size = new System.Drawing.Size(1287, 677);
            this.Load += new System.EventHandler(this.UserControlInicio_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoHabitaciones)).EndInit();
            this.panelHabMantenimiento.ResumeLayout(false);
            this.panelHabMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panelHabLibres.ResumeLayout(false);
            this.panelHabLibres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelHabOcupadas.ResumeLayout(false);
            this.panelHabOcupadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacionesProximas)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacionesReservadas)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelHabOcupadas;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvHabitacionesProximas;
        private System.Windows.Forms.Button btnVerDetallesProximas;
        private System.Windows.Forms.Button btnRegistrarCheckOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvHabitacionesReservadas;
        private System.Windows.Forms.Button btnVerDetallesReservadas;
        private System.Windows.Forms.Button btnRegistrarCheckIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer HoraFecha;
    }
}
