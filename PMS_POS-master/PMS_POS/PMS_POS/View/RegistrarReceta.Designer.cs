namespace PMS_POS.View
{
    partial class RegistrarReceta
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
            this.btnGuardarReceta = new System.Windows.Forms.Button();
            this.pnlMedidaEnReceta = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMedidaMedida = new System.Windows.Forms.Button();
            this.btnAceptarMedida = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAgregarReceta = new System.Windows.Forms.Button();
            this.btnRemoverDeReceta = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dgvProductosEnReceta = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductosEnInventario = new System.Windows.Forms.DataGridView();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlMedidaEnReceta.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnReceta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnGuardarReceta);
            this.panel1.Controls.Add(this.pnlMedidaEnReceta);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnAgregarReceta);
            this.panel1.Controls.Add(this.btnRemoverDeReceta);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.dgvProductosEnReceta);
            this.panel1.Controls.Add(this.dgvProductosEnInventario);
            this.panel1.Controls.Add(this.txtComentario);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 544);
            this.panel1.TabIndex = 0;
            // 
            // btnGuardarReceta
            // 
            this.btnGuardarReceta.BackColor = System.Drawing.Color.Navy;
            this.btnGuardarReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarReceta.ForeColor = System.Drawing.Color.White;
            this.btnGuardarReceta.Location = new System.Drawing.Point(315, 495);
            this.btnGuardarReceta.Name = "btnGuardarReceta";
            this.btnGuardarReceta.Size = new System.Drawing.Size(446, 44);
            this.btnGuardarReceta.TabIndex = 34;
            this.btnGuardarReceta.Text = "Guardar";
            this.btnGuardarReceta.UseVisualStyleBackColor = false;
            this.btnGuardarReceta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnGuardarReceta_MouseClick);
            // 
            // pnlMedidaEnReceta
            // 
            this.pnlMedidaEnReceta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(81)))), ((int)(((byte)(193)))));
            this.pnlMedidaEnReceta.Controls.Add(this.label1);
            this.pnlMedidaEnReceta.Controls.Add(this.panel3);
            this.pnlMedidaEnReceta.Location = new System.Drawing.Point(395, 137);
            this.pnlMedidaEnReceta.Name = "pnlMedidaEnReceta";
            this.pnlMedidaEnReceta.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlMedidaEnReceta.Size = new System.Drawing.Size(396, 246);
            this.pnlMedidaEnReceta.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medida en receta";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cbxUnidadMedida);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnMedidaMedida);
            this.panel3.Controls.Add(this.btnAceptarMedida);
            this.panel3.Controls.Add(this.nudCantidad);
            this.panel3.Location = new System.Drawing.Point(3, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 210);
            this.panel3.TabIndex = 0;
            // 
            // cbxUnidadMedida
            // 
            this.cbxUnidadMedida.AutoCompleteCustomSource.AddRange(new string[] {
            "Cuchara de té",
            "Cuchara de madera",
            "Onza fluida",
            "Taza",
            "Medio litro",
            "Cuarto de galón",
            "Galón",
            "Barril",
            "Mililitros",
            "Litros"});
            this.cbxUnidadMedida.BackColor = System.Drawing.SystemColors.Menu;
            this.cbxUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnidadMedida.FormattingEnabled = true;
            this.cbxUnidadMedida.Location = new System.Drawing.Point(113, 80);
            this.cbxUnidadMedida.Name = "cbxUnidadMedida";
            this.cbxUnidadMedida.Size = new System.Drawing.Size(264, 24);
            this.cbxUnidadMedida.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad:";
            // 
            // btnMedidaMedida
            // 
            this.btnMedidaMedida.BackColor = System.Drawing.Color.Navy;
            this.btnMedidaMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedidaMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedidaMedida.ForeColor = System.Drawing.Color.White;
            this.btnMedidaMedida.Location = new System.Drawing.Point(202, 128);
            this.btnMedidaMedida.Name = "btnMedidaMedida";
            this.btnMedidaMedida.Size = new System.Drawing.Size(175, 75);
            this.btnMedidaMedida.TabIndex = 2;
            this.btnMedidaMedida.Text = "Cancelar";
            this.btnMedidaMedida.UseVisualStyleBackColor = false;
            this.btnMedidaMedida.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnMedidaMedida_MouseClick);
            // 
            // btnAceptarMedida
            // 
            this.btnAceptarMedida.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAceptarMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarMedida.ForeColor = System.Drawing.Color.White;
            this.btnAceptarMedida.Location = new System.Drawing.Point(13, 128);
            this.btnAceptarMedida.Name = "btnAceptarMedida";
            this.btnAceptarMedida.Size = new System.Drawing.Size(183, 75);
            this.btnAceptarMedida.TabIndex = 1;
            this.btnAceptarMedida.Text = "Aceptar";
            this.btnAceptarMedida.UseVisualStyleBackColor = false;
            this.btnAceptarMedida.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAceptarMedida_MouseClick);
            // 
            // nudCantidad
            // 
            this.nudCantidad.DecimalPlaces = 2;
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(113, 26);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(264, 26);
            this.nudCantidad.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(12, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 26);
            this.textBox2.TabIndex = 30;
            this.textBox2.Text = "Buscar Producto";
            // 
            // btnAgregarReceta
            // 
            this.btnAgregarReceta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarReceta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarReceta.Location = new System.Drawing.Point(315, 389);
            this.btnAgregarReceta.Name = "btnAgregarReceta";
            this.btnAgregarReceta.Size = new System.Drawing.Size(220, 102);
            this.btnAgregarReceta.TabIndex = 28;
            this.btnAgregarReceta.Text = "Agregar a Receta";
            this.btnAgregarReceta.UseVisualStyleBackColor = false;
            this.btnAgregarReceta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAgregarReceta_MouseClick);
            // 
            // btnRemoverDeReceta
            // 
            this.btnRemoverDeReceta.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRemoverDeReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverDeReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverDeReceta.ForeColor = System.Drawing.Color.White;
            this.btnRemoverDeReceta.Location = new System.Drawing.Point(541, 389);
            this.btnRemoverDeReceta.Name = "btnRemoverDeReceta";
            this.btnRemoverDeReceta.Size = new System.Drawing.Size(220, 102);
            this.btnRemoverDeReceta.TabIndex = 27;
            this.btnRemoverDeReceta.Text = "Remover de Receta";
            this.btnRemoverDeReceta.UseVisualStyleBackColor = false;
            this.btnRemoverDeReceta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnRemoverDeReceta_MouseClick);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(81)))), ((int)(((byte)(193)))));
            this.label21.Location = new System.Drawing.Point(801, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(239, 25);
            this.label21.TabIndex = 26;
            this.label21.Text = "Productos en Receta:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(81)))), ((int)(((byte)(193)))));
            this.label23.Location = new System.Drawing.Point(24, 7);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(262, 25);
            this.label23.TabIndex = 25;
            this.label23.Text = "Productos en Inventario";
            // 
            // dgvProductosEnReceta
            // 
            this.dgvProductosEnReceta.AllowUserToAddRows = false;
            this.dgvProductosEnReceta.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvProductosEnReceta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosEnReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosEnReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvProductosEnReceta.Location = new System.Drawing.Point(777, 31);
            this.dgvProductosEnReceta.Name = "dgvProductosEnReceta";
            this.dgvProductosEnReceta.ReadOnly = true;
            this.dgvProductosEnReceta.Size = new System.Drawing.Size(360, 513);
            this.dgvProductosEnReceta.TabIndex = 24;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 69;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 74;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Unidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 66;
            // 
            // dgvProductosEnInventario
            // 
            this.dgvProductosEnInventario.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvProductosEnInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosEnInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosEnInventario.Location = new System.Drawing.Point(3, 66);
            this.dgvProductosEnInventario.Name = "dgvProductosEnInventario";
            this.dgvProductosEnInventario.Size = new System.Drawing.Size(293, 466);
            this.dgvProductosEnInventario.TabIndex = 23;
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Location = new System.Drawing.Point(446, 258);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(315, 129);
            this.txtComentario.TabIndex = 22;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(445, 91);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(316, 156);
            this.txtDescripcion.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(445, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(316, 26);
            this.txtNombre.TabIndex = 20;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(310, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 18);
            this.label22.TabIndex = 19;
            this.label22.Text = "Descripción:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(309, 252);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 18);
            this.label20.TabIndex = 18;
            this.label20.Text = "Comentario:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(309, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 18);
            this.label19.TabIndex = 17;
            this.label19.Text = "Nombre:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(81)))), ((int)(((byte)(193)))));
            this.label18.Location = new System.Drawing.Point(512, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 25);
            this.label18.TabIndex = 16;
            this.label18.Text = "Receta";
            // 
            // RegistrarReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 544);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "RegistrarReceta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RECETA";
            this.Load += new System.EventHandler(this.RegistrarReceta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMedidaEnReceta.ResumeLayout(false);
            this.pnlMedidaEnReceta.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnReceta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAgregarReceta;
        private System.Windows.Forms.Button btnRemoverDeReceta;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dgvProductosEnReceta;
        private System.Windows.Forms.DataGridView dgvProductosEnInventario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnlMedidaEnReceta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMedidaMedida;
        private System.Windows.Forms.Button btnAceptarMedida;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cbxUnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnGuardarReceta;
    }
}