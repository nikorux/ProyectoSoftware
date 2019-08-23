namespace PMS_POS.View
{
    partial class ConfigurarTipoHabitacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurarTipoHabitacion));
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoHabitacion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvTipoHabitacion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txtIdTipoHab = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoHabitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo Habitación:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTipoHabitacion
            // 
            this.txtTipoHabitacion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTipoHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoHabitacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTipoHabitacion.Location = new System.Drawing.Point(105, 234);
            this.txtTipoHabitacion.Name = "txtTipoHabitacion";
            this.txtTipoHabitacion.Size = new System.Drawing.Size(231, 13);
            this.txtTipoHabitacion.TabIndex = 12;
            this.txtTipoHabitacion.TextChanged += new System.EventHandler(this.TxtTipoHabitacion_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(158, 386);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(168, 35);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBorrar.Location = new System.Drawing.Point(553, 386);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(168, 35);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(354, 386);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(168, 35);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // dgvTipoHabitacion
            // 
            this.dgvTipoHabitacion.AllowUserToAddRows = false;
            this.dgvTipoHabitacion.AllowUserToDeleteRows = false;
            this.dgvTipoHabitacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoHabitacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTipoHabitacion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTipoHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTipoHabitacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoHabitacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipoHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipoHabitacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTipoHabitacion.Location = new System.Drawing.Point(356, 157);
            this.dgvTipoHabitacion.Name = "dgvTipoHabitacion";
            this.dgvTipoHabitacion.ReadOnly = true;
            this.dgvTipoHabitacion.RowHeadersVisible = false;
            this.dgvTipoHabitacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoHabitacion.Size = new System.Drawing.Size(334, 193);
            this.dgvTipoHabitacion.TabIndex = 8;
            this.dgvTipoHabitacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTipoHabitacion_CellClick);
            this.dgvTipoHabitacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTipoHabitacion_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(121, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Configuración Tipo de Habitación";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PMS_POS.Properties.Resources.settings__1_;
            this.pictureBox1.Location = new System.Drawing.Point(66, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(105, 248);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(231, 10);
            this.pictureBox8.TabIndex = 207;
            this.pictureBox8.TabStop = false;
            // 
            // txtIdTipoHab
            // 
            this.txtIdTipoHab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtIdTipoHab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdTipoHab.Enabled = false;
            this.txtIdTipoHab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIdTipoHab.Location = new System.Drawing.Point(105, 126);
            this.txtIdTipoHab.Name = "txtIdTipoHab";
            this.txtIdTipoHab.Size = new System.Drawing.Size(231, 13);
            this.txtIdTipoHab.TabIndex = 208;
            this.txtIdTipoHab.Visible = false;
            // 
            // ConfigurarTipoHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.txtIdTipoHab);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTipoHabitacion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvTipoHabitacion);
            this.Name = "ConfigurarTipoHabitacion";
            this.Size = new System.Drawing.Size(1304, 633);
            this.Load += new System.EventHandler(this.ConfigurarTipoHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoHabitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipoHabitacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvTipoHabitacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtIdTipoHab;
    }
}
