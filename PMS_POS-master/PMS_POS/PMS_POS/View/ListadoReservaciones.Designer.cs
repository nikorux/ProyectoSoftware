﻿namespace PMS_POS.View
{
    partial class ListadoReservaciones
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
            this.btnCancelar = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvInfoHuesped = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvReservaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nupCantidadNinos = new System.Windows.Forms.NumericUpDown();
            this.nupCantidadAdultos = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Label();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidadNoches = new System.Windows.Forms.TextBox();
            this.txtNombreHuesped = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscarHabitacion = new System.Windows.Forms.TextBox();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.dtpFechaSalidaRegRes = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nudCantidadAdultos = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFechaLlegadaRegRes = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.nudCantidadNinos = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioPorNoche = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCanal = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.grbInfoHuesped = new System.Windows.Forms.GroupBox();
            this.dgvHuesped = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBuscarCoincidencias = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTotalNoche = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoHuesped)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadNinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadNinos)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.grbInfoHuesped.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuesped)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(626, 24);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 20);
            this.btnCancelar.TabIndex = 192;
            this.btnCancelar.Text = "Cancelar reservación";
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvInfoHuesped);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(504, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 259);
            this.groupBox3.TabIndex = 191;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información huésped:";
            // 
            // dgvInfoHuesped
            // 
            this.dgvInfoHuesped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoHuesped.Location = new System.Drawing.Point(6, 20);
            this.dgvInfoHuesped.Name = "dgvInfoHuesped";
            this.dgvInfoHuesped.Size = new System.Drawing.Size(299, 233);
            this.dgvInfoHuesped.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvReservaciones);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 259);
            this.groupBox2.TabIndex = 190;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservaciones registradas:";
            // 
            // dgvReservaciones
            // 
            this.dgvReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservaciones.Location = new System.Drawing.Point(7, 21);
            this.dgvReservaciones.Name = "dgvReservaciones";
            this.dgvReservaciones.Size = new System.Drawing.Size(463, 232);
            this.dgvReservaciones.TabIndex = 0;
            this.dgvReservaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReservaciones_CellClick);
            this.dgvReservaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReservaciones_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.nupCantidadNinos);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.nupCantidadAdultos);
            this.groupBox1.Controls.Add(this.dtpFechaSalida);
            this.groupBox1.Controls.Add(this.dtpFechaLlegada);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 63);
            this.groupBox1.TabIndex = 189;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar reservación";
            // 
            // nupCantidadNinos
            // 
            this.nupCantidadNinos.Location = new System.Drawing.Point(500, 23);
            this.nupCantidadNinos.Name = "nupCantidadNinos";
            this.nupCantidadNinos.Size = new System.Drawing.Size(57, 24);
            this.nupCantidadNinos.TabIndex = 181;
            // 
            // nupCantidadAdultos
            // 
            this.nupCantidadAdultos.Location = new System.Drawing.Point(383, 23);
            this.nupCantidadAdultos.Name = "nupCantidadAdultos";
            this.nupCantidadAdultos.Size = new System.Drawing.Size(57, 24);
            this.nupCantidadAdultos.TabIndex = 180;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(238, 23);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(83, 24);
            this.dtpFechaSalida.TabIndex = 64;
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLlegada.Location = new System.Drawing.Point(88, 23);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.Size = new System.Drawing.Size(82, 24);
            this.dtpFechaLlegada.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(443, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Niños:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(327, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "Adultos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(23, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 59;
            this.label4.Text = "Llegada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(184, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 60;
            this.label8.Text = "Salida:";
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = true;
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(572, 24);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEditar.Size = new System.Drawing.Size(48, 20);
            this.btnEditar.TabIndex = 193;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundoNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNombre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSegundoNombre.Location = new System.Drawing.Point(217, 83);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(175, 20);
            this.txtSegundoNombre.TabIndex = 188;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(40, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(204, 32);
            this.label17.TabIndex = 186;
            this.label17.Text = "Reservaciones";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 13);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitter1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.label17);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.txtSegundoNombre);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(975, 657);
            this.splitContainer1.SplitterDistance = 946;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 657);
            this.splitter1.TabIndex = 192;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNumeroHabitacion);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCantidadNoches);
            this.panel2.Controls.Add(this.txtNombreHuesped);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtPrecioPorNoche);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtCanal);
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtTotalNoche);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.txtComentario);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 637);
            this.panel2.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(550, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 111;
            this.label1.Text = "Cantidad de noches:";
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
            // txtNombreHuesped
            // 
            this.txtNombreHuesped.Enabled = false;
            this.txtNombreHuesped.Location = new System.Drawing.Point(672, 204);
            this.txtNombreHuesped.Name = "txtNombreHuesped";
            this.txtNombreHuesped.Size = new System.Drawing.Size(191, 20);
            this.txtNombreHuesped.TabIndex = 112;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(550, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 111;
            this.label6.Text = "Nombre huésped:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtBuscarHabitacion);
            this.groupBox4.Controls.Add(this.dgvHabitaciones);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(531, 224);
            this.groupBox4.TabIndex = 110;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccionar habitación:";
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
            this.txtBuscarHabitacion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtBuscarHabitacion_MouseClick_1);
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(6, 64);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.Size = new System.Drawing.Size(519, 154);
            this.dgvHabitaciones.TabIndex = 0;
            this.dgvHabitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHabitaciones_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox5.Controls.Add(this.btnGoBack);
            this.groupBox5.Controls.Add(this.dtpFechaSalidaRegRes);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.nudCantidadAdultos);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.dtpFechaLlegadaRegRes);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.nudCantidadNinos);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(909, 78);
            this.groupBox5.TabIndex = 106;
            this.groupBox5.TabStop = false;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(18, 27);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(43, 23);
            this.btnGoBack.TabIndex = 89;
            this.btnGoBack.Text = "<----";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // dtpFechaSalidaRegRes
            // 
            this.dtpFechaSalidaRegRes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalidaRegRes.Location = new System.Drawing.Point(389, 29);
            this.dtpFechaSalidaRegRes.Name = "dtpFechaSalidaRegRes";
            this.dtpFechaSalidaRegRes.Size = new System.Drawing.Size(122, 20);
            this.dtpFechaSalidaRegRes.TabIndex = 64;
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
            // nudCantidadAdultos
            // 
            this.nudCantidadAdultos.Location = new System.Drawing.Point(636, 30);
            this.nudCantidadAdultos.Name = "nudCantidadAdultos";
            this.nudCantidadAdultos.Size = new System.Drawing.Size(46, 20);
            this.nudCantidadAdultos.TabIndex = 86;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(121, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 59;
            this.label13.Text = "Llegada:";
            // 
            // dtpFechaLlegadaRegRes
            // 
            this.dtpFechaLlegadaRegRes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLlegadaRegRes.Location = new System.Drawing.Point(188, 30);
            this.dtpFechaLlegadaRegRes.Name = "dtpFechaLlegadaRegRes";
            this.dtpFechaLlegadaRegRes.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaLlegadaRegRes.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(336, 30);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(551, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 16);
            this.label9.TabIndex = 107;
            this.label9.Text = "Precio por Noche:";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(825, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 108;
            this.label10.Text = "$";
            // 
            // txtCanal
            // 
            this.txtCanal.Location = new System.Drawing.Point(672, 230);
            this.txtCanal.Name = "txtCanal";
            this.txtCanal.Size = new System.Drawing.Size(191, 20);
            this.txtCanal.TabIndex = 106;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox6.Controls.Add(this.grbInfoHuesped);
            this.groupBox6.Controls.Add(this.txtBuscarCoincidencias);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(0, 317);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(534, 275);
            this.groupBox6.TabIndex = 99;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Registro Huésped:";
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
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(550, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 92;
            this.label11.Text = "Comentario:";
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(825, 394);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 15);
            this.label18.TabIndex = 102;
            this.label18.Text = "$";
            // 
            // ListadoReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ListadoReservaciones";
            this.Size = new System.Drawing.Size(954, 789);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoHuesped)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadNinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadAdultos)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadNinos)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.grbInfoHuesped.ResumeLayout(false);
            this.grbInfoHuesped.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHuesped)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label btnCancelar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nupCantidadNinos;
        private System.Windows.Forms.NumericUpDown nupCantidadAdultos;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvInfoHuesped;
        private System.Windows.Forms.DataGridView dgvReservaciones;
        private System.Windows.Forms.Label btnEditar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroHabitacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidadNoches;
        private System.Windows.Forms.TextBox txtNombreHuesped;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscarHabitacion;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpFechaSalidaRegRes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudCantidadAdultos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegadaRegRes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudCantidadNinos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioPorNoche;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCanal;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox grbInfoHuesped;
        private System.Windows.Forms.DataGridView dgvHuesped;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBuscarCoincidencias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTotalNoche;
        private System.Windows.Forms.Label btnGuardar;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnGoBack;
        /*private View.NuevaReservacion NuevaReservacion;*/
    }
}
