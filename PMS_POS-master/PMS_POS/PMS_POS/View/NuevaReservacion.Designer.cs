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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.txtBoxTipoHabitacion = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarHabitacion = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtBoxDocumento = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxCanal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numAdultos = new System.Windows.Forms.NumericUpDown();
            this.numInfantes = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxComentarios = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.txtBoxNoches = new System.Windows.Forms.TextBox();
            this.dateTimePickerSalida = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLlegada = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInfantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo Habitación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número Habitación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio:";
            // 
            // txtBoxNumeroHabitacion
            // 
            this.txtBoxNumeroHabitacion.Enabled = false;
            this.txtBoxNumeroHabitacion.Location = new System.Drawing.Point(174, 39);
            this.txtBoxNumeroHabitacion.Name = "txtBoxNumeroHabitacion";
            this.txtBoxNumeroHabitacion.Size = new System.Drawing.Size(187, 24);
            this.txtBoxNumeroHabitacion.TabIndex = 4;
            // 
            // txtBoxTipoHabitacion
            // 
            this.txtBoxTipoHabitacion.Enabled = false;
            this.txtBoxTipoHabitacion.Location = new System.Drawing.Point(174, 65);
            this.txtBoxTipoHabitacion.Name = "txtBoxTipoHabitacion";
            this.txtBoxTipoHabitacion.Size = new System.Drawing.Size(187, 24);
            this.txtBoxTipoHabitacion.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Enabled = false;
            this.txtBoxPrecio.Location = new System.Drawing.Point(174, 92);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(187, 24);
            this.txtBoxPrecio.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.btnBuscarHabitacion);
            this.groupBox1.Controls.Add(this.txtBoxPrecio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxTipoHabitacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxNumeroHabitacion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(77, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habitación";
            // 
            // btnBuscarHabitacion
            // 
            this.btnBuscarHabitacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHabitacion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarHabitacion.Location = new System.Drawing.Point(389, 39);
            this.btnBuscarHabitacion.Name = "btnBuscarHabitacion";
            this.btnBuscarHabitacion.Size = new System.Drawing.Size(135, 73);
            this.btnBuscarHabitacion.TabIndex = 11;
            this.btnBuscarHabitacion.Text = "Buscar Habitación";
            this.btnBuscarHabitacion.UseVisualStyleBackColor = false;
            this.btnBuscarHabitacion.Click += new System.EventHandler(this.BtnBuscarHabitacion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.txtBoxDocumento);
            this.groupBox2.Controls.Add(this.txtBoxNombre);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(649, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarCliente.Location = new System.Drawing.Point(390, 37);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(135, 73);
            this.btnBuscarCliente.TabIndex = 12;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // txtBoxDocumento
            // 
            this.txtBoxDocumento.Enabled = false;
            this.txtBoxDocumento.Location = new System.Drawing.Point(142, 77);
            this.txtBoxDocumento.Name = "txtBoxDocumento";
            this.txtBoxDocumento.Size = new System.Drawing.Size(187, 24);
            this.txtBoxDocumento.TabIndex = 10;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Enabled = false;
            this.txtBoxNombre.Location = new System.Drawing.Point(142, 51);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(187, 24);
            this.txtBoxNombre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtBoxCanal);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.numAdultos);
            this.groupBox3.Controls.Add(this.numInfantes);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtBoxComentarios);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtBoxTotal);
            this.groupBox3.Controls.Add(this.txtBoxNoches);
            this.groupBox3.Controls.Add(this.dateTimePickerSalida);
            this.groupBox3.Controls.Add(this.dateTimePickerLlegada);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(77, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1116, 276);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reservación";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(945, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 73);
            this.button1.TabIndex = 25;
            this.button1.Text = "Registrar Reservación";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtBoxCanal
            // 
            this.txtBoxCanal.Location = new System.Drawing.Point(150, 213);
            this.txtBoxCanal.Name = "txtBoxCanal";
            this.txtBoxCanal.Size = new System.Drawing.Size(218, 24);
            this.txtBoxCanal.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(95, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Canal:";
            // 
            // numAdultos
            // 
            this.numAdultos.Location = new System.Drawing.Point(152, 142);
            this.numAdultos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAdultos.Name = "numAdultos";
            this.numAdultos.ReadOnly = true;
            this.numAdultos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numAdultos.Size = new System.Drawing.Size(81, 24);
            this.numAdultos.TabIndex = 22;
            this.numAdultos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numInfantes
            // 
            this.numInfantes.Location = new System.Drawing.Point(300, 142);
            this.numInfantes.Name = "numInfantes";
            this.numInfantes.ReadOnly = true;
            this.numInfantes.Size = new System.Drawing.Size(67, 24);
            this.numInfantes.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(239, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Niños:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(84, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Adultos:";
            // 
            // txtBoxComentarios
            // 
            this.txtBoxComentarios.Location = new System.Drawing.Point(496, 48);
            this.txtBoxComentarios.Multiline = true;
            this.txtBoxComentarios.Name = "txtBoxComentarios";
            this.txtBoxComentarios.Size = new System.Drawing.Size(411, 182);
            this.txtBoxComentarios.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(420, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Detalles:";
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Enabled = false;
            this.txtBoxTotal.Location = new System.Drawing.Point(151, 174);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(88, 24);
            this.txtBoxTotal.TabIndex = 15;
            // 
            // txtBoxNoches
            // 
            this.txtBoxNoches.Enabled = false;
            this.txtBoxNoches.Location = new System.Drawing.Point(153, 111);
            this.txtBoxNoches.Name = "txtBoxNoches";
            this.txtBoxNoches.Size = new System.Drawing.Size(86, 24);
            this.txtBoxNoches.TabIndex = 9;
            this.txtBoxNoches.TextChanged += new System.EventHandler(this.TxtBoxNoches_TextChanged);
            // 
            // dateTimePickerSalida
            // 
            this.dateTimePickerSalida.Location = new System.Drawing.Point(153, 80);
            this.dateTimePickerSalida.Name = "dateTimePickerSalida";
            this.dateTimePickerSalida.Size = new System.Drawing.Size(261, 24);
            this.dateTimePickerSalida.TabIndex = 14;
            this.dateTimePickerSalida.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            this.dateTimePickerSalida.Leave += new System.EventHandler(this.DateTimePickerSalida_Leave);
            // 
            // dateTimePickerLlegada
            // 
            this.dateTimePickerLlegada.Location = new System.Drawing.Point(155, 48);
            this.dateTimePickerLlegada.Name = "dateTimePickerLlegada";
            this.dateTimePickerLlegada.Size = new System.Drawing.Size(259, 24);
            this.dateTimePickerLlegada.TabIndex = 13;
            this.dateTimePickerLlegada.Value = new System.DateTime(2019, 7, 8, 9, 58, 28, 0);
            this.dateTimePickerLlegada.ValueChanged += new System.EventHandler(this.DateTimePickerLlegada_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(20, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total por noches:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(84, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Noches:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(47, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha salida:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(37, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha llegada:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(72, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(296, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "Registro de Reservaciones";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NuevaReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevaReservacion";
            this.Size = new System.Drawing.Size(1285, 680);
            this.Load += new System.EventHandler(this.NuevaReservacion_Load);
            this.LocationChanged += new System.EventHandler(this.NuevaReservacion_LocationChanged);
            this.VisibleChanged += new System.EventHandler(this.NuevaReservacion_VisibleChanged);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.NuevaReservacion_ControlAdded);
            this.Enter += new System.EventHandler(this.NuevaReservacion_Enter);
            this.Leave += new System.EventHandler(this.NuevaReservacion_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInfantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNumeroHabitacion;
        private System.Windows.Forms.TextBox txtBoxTipoHabitacion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxDocumento;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarHabitacion;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerLlegada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxCanal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numAdultos;
        private System.Windows.Forms.NumericUpDown numInfantes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxComentarios;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.TextBox txtBoxNoches;
        private System.Windows.Forms.DateTimePicker dateTimePickerSalida;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
