namespace PMS_POS.View
{
    partial class NuevaReservacion
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
            this.txtTotalNoche = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbInfoHuesped = new System.Windows.Forms.GroupBox();
            this.dgvHuesped = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBuscarCoincidencias = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nudCantidadNinos = new System.Windows.Forms.NumericUpDown();
            this.nudCantidadAdultos = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscarHabitacion = new System.Windows.Forms.TextBox();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadNoches = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioPorNoche = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCanal = new System.Windows.Forms.TextBox();
            this.txtNombreHuesped = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.grbInfoHuesped.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuesped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadNinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAdultos)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotalNoche
            // 
            this.txtTotalNoche.Enabled = false;
            this.txtTotalNoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNoche.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTotalNoche.Location = new System.Drawing.Point(673, 389);
            this.txtTotalNoche.Multiline = true;
            this.txtTotalNoche.Name = "txtTotalNoche";
            this.txtTotalNoche.Size = new System.Drawing.Size(146, 26);
            this.txtTotalNoche.TabIndex = 105;
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtComentario.Location = new System.Drawing.Point(672, 256);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(239, 74);
            this.txtComentario.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(825, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 102;
            this.label1.Text = "$";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGuardar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(770, 473);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 20);
            this.btnGuardar.TabIndex = 94;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(550, 231);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 16);
            this.label19.TabIndex = 96;
            this.label19.Text = "Canal:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.grbInfoHuesped);
            this.groupBox2.Controls.Add(this.txtBuscarCoincidencias);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 275);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro Huésped:";
            // 
            // grbInfoHuesped
            // 
            this.grbInfoHuesped.Controls.Add(this.dgvHuesped);
            this.grbInfoHuesped.Controls.Add(this.label12);
            this.grbInfoHuesped.Location = new System.Drawing.Point(10, 49);
            this.grbInfoHuesped.Name = "grbInfoHuesped";
            this.grbInfoHuesped.Size = new System.Drawing.Size(518, 218);
            this.grbInfoHuesped.TabIndex = 106;
            this.grbInfoHuesped.TabStop = false;
            this.grbInfoHuesped.Text = "Información Huésped";
            // 
            // dgvHuesped
            // 
            this.dgvHuesped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHuesped.Location = new System.Drawing.Point(14, 45);
            this.dgvHuesped.Name = "dgvHuesped";
            this.dgvHuesped.Size = new System.Drawing.Size(498, 167);
            this.dgvHuesped.TabIndex = 59;
            this.dgvHuesped.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHuesped_CellClick);
            this.dgvHuesped.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHuesped_CellContentClick);
            this.dgvHuesped.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvHuesped_RowHeaderMouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(11, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 58;
            this.label12.Text = "Huésped:";
            // 
            // txtBuscarCoincidencias
            // 
            this.txtBuscarCoincidencias.BackColor = System.Drawing.Color.White;
            this.txtBuscarCoincidencias.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarCoincidencias.Location = new System.Drawing.Point(24, 23);
            this.txtBuscarCoincidencias.Name = "txtBuscarCoincidencias";
            this.txtBuscarCoincidencias.Size = new System.Drawing.Size(471, 20);
            this.txtBuscarCoincidencias.TabIndex = 60;
            this.txtBuscarCoincidencias.Text = "Buscar huésped";
            this.txtBuscarCoincidencias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtBuscarCoincidencias_MouseClick);
            this.txtBuscarCoincidencias.TextChanged += new System.EventHandler(this.TxtBuscarCoincidencias_TextChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl.Location = new System.Drawing.Point(551, 394);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(113, 15);
            this.lbl.TabIndex = 95;
            this.lbl.Text = "Total por Noche:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(550, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 92;
            this.label10.Text = "Comentario:";
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLlegada.Location = new System.Drawing.Point(85, 31);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaLlegada.TabIndex = 63;
            this.dtpFechaLlegada.ValueChanged += new System.EventHandler(this.DtpFechaLlegada_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(718, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 16);
            this.label16.TabIndex = 62;
            this.label16.Text = "Niños";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(577, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 16);
            this.label15.TabIndex = 61;
            this.label15.Text = "Adultos";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(286, 30);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(122, 20);
            this.dtpFechaSalida.TabIndex = 64;
            this.dtpFechaSalida.ValueChanged += new System.EventHandler(this.DtpFechaSalida_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(18, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 59;
            this.label13.Text = "Llegada:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(233, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 16);
            this.label14.TabIndex = 60;
            this.label14.Text = "Salida:";
            // 
            // nudCantidadNinos
            // 
            this.nudCantidadNinos.Location = new System.Drawing.Point(767, 30);
            this.nudCantidadNinos.Name = "nudCantidadNinos";
            this.nudCantidadNinos.Size = new System.Drawing.Size(42, 20);
            this.nudCantidadNinos.TabIndex = 88;
            // 
            // nudCantidadAdultos
            // 
            this.nudCantidadAdultos.Location = new System.Drawing.Point(636, 30);
            this.nudCantidadAdultos.Name = "nudCantidadAdultos";
            this.nudCantidadAdultos.Size = new System.Drawing.Size(46, 20);
            this.nudCantidadAdultos.TabIndex = 86;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.SteelBlue;
            this.label17.Location = new System.Drawing.Point(55, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(192, 24);
            this.label17.TabIndex = 97;
            this.label17.Text = "Nueva Reservación";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNumeroHabitacion);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCantidadNoches);
            this.panel2.Controls.Add(this.txtNombreHuesped);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtPrecioPorNoche);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCanal);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtTotalNoche);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.txtComentario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(25, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 598);
            this.panel2.TabIndex = 107;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBuscarHabitacion);
            this.groupBox3.Controls.Add(this.dgvHabitaciones);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 224);
            this.groupBox3.TabIndex = 110;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar habitación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(17, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 61;
            this.label7.Text = "Habitación:";
            // 
            // txtBuscarHabitacion
            // 
            this.txtBuscarHabitacion.BackColor = System.Drawing.Color.White;
            this.txtBuscarHabitacion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarHabitacion.Location = new System.Drawing.Point(6, 19);
            this.txtBuscarHabitacion.Name = "txtBuscarHabitacion";
            this.txtBuscarHabitacion.Size = new System.Drawing.Size(374, 20);
            this.txtBuscarHabitacion.TabIndex = 107;
            this.txtBuscarHabitacion.Text = "Buscar habitación";
            this.txtBuscarHabitacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtBuscarHabitacion_MouseClick);
            this.txtBuscarHabitacion.TextChanged += new System.EventHandler(this.TxtBuscarHabitacion_TextChanged);
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(6, 64);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.Size = new System.Drawing.Size(519, 154);
            this.dgvHabitaciones.TabIndex = 0;
            this.dgvHabitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHabitaciones_CellClick);
            this.dgvHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHabitaciones_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.dtpFechaSalida);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.nudCantidadAdultos);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dtpFechaLlegada);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.nudCantidadNinos);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(909, 78);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(550, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 111;
            this.label2.Text = "Cantidad de noches:";
            // 
            // txtCantidadNoches
            // 
            this.txtCantidadNoches.Enabled = false;
            this.txtCantidadNoches.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadNoches.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCantidadNoches.Location = new System.Drawing.Point(699, 151);
            this.txtCantidadNoches.Multiline = true;
            this.txtCantidadNoches.Name = "txtCantidadNoches";
            this.txtCantidadNoches.Size = new System.Drawing.Size(164, 21);
            this.txtCantidadNoches.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(551, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 107;
            this.label4.Text = "Precio por Noche:";
            // 
            // txtPrecioPorNoche
            // 
            this.txtPrecioPorNoche.Enabled = false;
            this.txtPrecioPorNoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioPorNoche.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPrecioPorNoche.Location = new System.Drawing.Point(673, 346);
            this.txtPrecioPorNoche.Multiline = true;
            this.txtPrecioPorNoche.Name = "txtPrecioPorNoche";
            this.txtPrecioPorNoche.Size = new System.Drawing.Size(146, 26);
            this.txtPrecioPorNoche.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(825, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 108;
            this.label6.Text = "$";
            // 
            // txtCanal
            // 
            this.txtCanal.Location = new System.Drawing.Point(672, 230);
            this.txtCanal.Name = "txtCanal";
            this.txtCanal.Size = new System.Drawing.Size(191, 20);
            this.txtCanal.TabIndex = 106;
            // 
            // txtNombreHuesped
            // 
            this.txtNombreHuesped.Enabled = false;
            this.txtNombreHuesped.Location = new System.Drawing.Point(672, 204);
            this.txtNombreHuesped.Name = "txtNombreHuesped";
            this.txtNombreHuesped.Size = new System.Drawing.Size(191, 20);
            this.txtNombreHuesped.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(550, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 111;
            this.label3.Text = "Nombre huésped:";
            // 
            // txtNumeroHabitacion
            // 
            this.txtNumeroHabitacion.Enabled = false;
            this.txtNumeroHabitacion.Location = new System.Drawing.Point(699, 178);
            this.txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            this.txtNumeroHabitacion.Size = new System.Drawing.Size(164, 20);
            this.txtNumeroHabitacion.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(550, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 113;
            this.label5.Text = "Número de habitación:";
            // 
            // NuevaReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel2);
            this.Name = "NuevaReservacion";
            this.Size = new System.Drawing.Size(948, 674);
            this.Load += new System.EventHandler(this.NuevaReservacion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbInfoHuesped.ResumeLayout(false);
            this.grbInfoHuesped.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuesped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadNinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAdultos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTotalNoche;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnGuardar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscarCoincidencias;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grbInfoHuesped;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegada;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudCantidadNinos;
        private System.Windows.Forms.NumericUpDown nudCantidadAdultos;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCanal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioPorNoche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvHuesped;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscarHabitacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadNoches;
        private System.Windows.Forms.TextBox txtNumeroHabitacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreHuesped;
        private System.Windows.Forms.Label label3;
    }
}
