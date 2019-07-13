namespace PMS_POS.View
{
    partial class UserControlHabitaciones
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
            System.Windows.Forms.Button button1;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxNumHab = new System.Windows.Forms.TextBox();
            this.txtBoxPrecioPorNoche = new System.Windows.Forms.TextBox();
            this.txtBoxDetalles = new System.Windows.Forms.RichTextBox();
            this.numMaxPersonas = new System.Windows.Forms.NumericUpDown();
            this.numPiso = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgvHab = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.numCantCamas = new System.Windows.Forms.NumericUpDown();
            this.cmbTipoHab = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpBoxBuscarHab = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantCamas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpBoxBuscarHab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.RoyalBlue;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(458, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(158, 28);
            button1.TabIndex = 36;
            button1.Text = "Registrar nueva habitación";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(90, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de habitaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de habitacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de habitacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Num de personas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Piso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(531, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(531, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio por noche:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Detalles:";
            // 
            // txtBoxNumHab
            // 
            this.txtBoxNumHab.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxNumHab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNumHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumHab.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxNumHab.Location = new System.Drawing.Point(327, 47);
            this.txtBoxNumHab.Name = "txtBoxNumHab";
            this.txtBoxNumHab.Size = new System.Drawing.Size(128, 13);
            this.txtBoxNumHab.TabIndex = 8;
            // 
            // txtBoxPrecioPorNoche
            // 
            this.txtBoxPrecioPorNoche.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBoxPrecioPorNoche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPrecioPorNoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrecioPorNoche.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxPrecioPorNoche.Location = new System.Drawing.Point(534, 49);
            this.txtBoxPrecioPorNoche.Name = "txtBoxPrecioPorNoche";
            this.txtBoxPrecioPorNoche.Size = new System.Drawing.Size(128, 13);
            this.txtBoxPrecioPorNoche.TabIndex = 11;
            // 
            // txtBoxDetalles
            // 
            this.txtBoxDetalles.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtBoxDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDetalles.Location = new System.Drawing.Point(30, 207);
            this.txtBoxDetalles.Name = "txtBoxDetalles";
            this.txtBoxDetalles.Size = new System.Drawing.Size(250, 82);
            this.txtBoxDetalles.TabIndex = 12;
            this.txtBoxDetalles.Text = "";
            // 
            // numMaxPersonas
            // 
            this.numMaxPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numMaxPersonas.Location = new System.Drawing.Point(30, 151);
            this.numMaxPersonas.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numMaxPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxPersonas.Name = "numMaxPersonas";
            this.numMaxPersonas.Size = new System.Drawing.Size(128, 16);
            this.numMaxPersonas.TabIndex = 13;
            this.numMaxPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPiso
            // 
            this.numPiso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPiso.Location = new System.Drawing.Point(327, 151);
            this.numPiso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPiso.Name = "numPiso";
            this.numPiso.Size = new System.Drawing.Size(128, 16);
            this.numPiso.TabIndex = 14;
            this.numPiso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(650, 262);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(81, 27);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
        
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(709, 12);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(81, 27);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // dgvHab
            // 
            this.dgvHab.AllowUserToAddRows = false;
            this.dgvHab.AllowUserToDeleteRows = false;
            this.dgvHab.BackgroundColor = System.Drawing.Color.White;
            this.dgvHab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHab.Location = new System.Drawing.Point(15, 19);
            this.dgvHab.Name = "dgvHab";
            this.dgvHab.ReadOnly = true;
            this.dgvHab.Size = new System.Drawing.Size(771, 291);
            this.dgvHab.TabIndex = 19;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maskedTextBox2.Location = new System.Drawing.Point(30, 44);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            this.maskedTextBox2.RejectInputOnFirstFailure = true;
            this.maskedTextBox2.Size = new System.Drawing.Size(128, 13);
            this.maskedTextBox2.TabIndex = 23;
            // 
            // numCantCamas
            // 
            this.numCantCamas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCantCamas.Location = new System.Drawing.Point(327, 97);
            this.numCantCamas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCantCamas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantCamas.Name = "numCantCamas";
            this.numCantCamas.Size = new System.Drawing.Size(128, 16);
            this.numCantCamas.TabIndex = 25;
            this.numCantCamas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbTipoHab
            // 
            this.cmbTipoHab.DisplayMember = "wd";
            this.cmbTipoHab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoHab.FormattingEnabled = true;
            this.cmbTipoHab.Location = new System.Drawing.Point(30, 97);
            this.cmbTipoHab.Name = "cmbTipoHab";
            this.cmbTipoHab.Size = new System.Drawing.Size(128, 21);
            this.cmbTipoHab.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "IdHabitacion:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DisplayMember = "wd";
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Disponible",
            "Ocupada",
            "Bloqueada"});
            this.cmbEstado.Location = new System.Drawing.Point(534, 97);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(128, 21);
            this.cmbEstado.TabIndex = 30;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(622, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 27);
            this.btnEditar.TabIndex = 31;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(324, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Cantidad de camas:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.txtBoxPrecioPorNoche);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbTipoHab);
            this.panel1.Controls.Add(this.txtBoxNumHab);
            this.panel1.Controls.Add(this.numCantCamas);
            this.panel1.Controls.Add(this.txtBoxDetalles);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.numMaxPersonas);
            this.panel1.Controls.Add(this.maskedTextBox2);
            this.panel1.Controls.Add(this.numPiso);
            this.panel1.Location = new System.Drawing.Point(29, 505);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 85);
            this.panel1.TabIndex = 37;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PMS_POS.Properties.Resources.line2;
            this.pictureBox3.Location = new System.Drawing.Point(534, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PMS_POS.Properties.Resources.line2;
            this.pictureBox2.Location = new System.Drawing.Point(327, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // grpBoxBuscarHab
            // 
            this.grpBoxBuscarHab.Controls.Add(button1);
            this.grpBoxBuscarHab.Controls.Add(this.btnEditar);
            this.grpBoxBuscarHab.Controls.Add(this.btnBorrar);
            this.grpBoxBuscarHab.Location = new System.Drawing.Point(56, 59);
            this.grpBoxBuscarHab.Name = "grpBoxBuscarHab";
            this.grpBoxBuscarHab.Size = new System.Drawing.Size(796, 46);
            this.grpBoxBuscarHab.TabIndex = 38;
            this.grpBoxBuscarHab.TabStop = false;
            this.grpBoxBuscarHab.Text = "Filtrar Habitación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHab);
            this.groupBox1.Location = new System.Drawing.Point(56, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 316);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habitaciones creadas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PMS_POS.Properties.Resources.room_key;
            this.pictureBox1.Location = new System.Drawing.Point(56, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpBoxBuscarHab);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserControlHabitaciones";
            this.Size = new System.Drawing.Size(1143, 655);
            this.Load += new System.EventHandler(this.UserControlHabitaciones_Load);

            ((System.ComponentModel.ISupportInitialize)(this.numMaxPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantCamas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpBoxBuscarHab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxNumHab;
        private System.Windows.Forms.TextBox txtBoxPrecioPorNoche;
        private System.Windows.Forms.RichTextBox txtBoxDetalles;
        private System.Windows.Forms.NumericUpDown numMaxPersonas;
        private System.Windows.Forms.NumericUpDown numPiso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridView dgvHab;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.NumericUpDown numCantCamas;
        private System.Windows.Forms.ComboBox cmbTipoHab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpBoxBuscarHab;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
