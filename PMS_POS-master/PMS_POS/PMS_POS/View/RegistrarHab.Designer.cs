﻿namespace PMS_POS.View
{
    partial class RegistrarHab
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtBoxPrecioPorNoche = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoHab = new System.Windows.Forms.ComboBox();
            this.txtBoxNumHab = new System.Windows.Forms.TextBox();
            this.numCantCamas = new System.Windows.Forms.NumericUpDown();
            this.txtBoxDetalles = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numMaxPersonas = new System.Windows.Forms.NumericUpDown();
            this.txtBoxId = new System.Windows.Forms.MaskedTextBox();
            this.numPiso = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantCamas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPiso)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
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
            this.panel1.Controls.Add(this.txtBoxId);
            this.panel1.Controls.Add(this.numPiso);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 329);
            this.panel1.TabIndex = 38;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(606, 262);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 27);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Location = new System.Drawing.Point(435, 262);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(81, 27);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            // txtBoxId
            // 
            this.txtBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBoxId.Location = new System.Drawing.Point(30, 44);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.ReadOnly = true;
            this.txtBoxId.RejectInputOnFirstFailure = true;
            this.txtBoxId.Size = new System.Drawing.Size(128, 13);
            this.txtBoxId.TabIndex = 23;
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
            // 
            // RegistrarHab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrarHab";
            this.Text = "RegistrarHabitación";
            this.Load += new System.EventHandler(this.RegistrarHabitación_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantCamas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPiso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtBoxPrecioPorNoche;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoHab;
        private System.Windows.Forms.TextBox txtBoxNumHab;
        private System.Windows.Forms.NumericUpDown numCantCamas;
        private System.Windows.Forms.RichTextBox txtBoxDetalles;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numMaxPersonas;
        private System.Windows.Forms.MaskedTextBox txtBoxId;
        private System.Windows.Forms.NumericUpDown numPiso;
        private System.Windows.Forms.Button btnCancelar;
    }
}