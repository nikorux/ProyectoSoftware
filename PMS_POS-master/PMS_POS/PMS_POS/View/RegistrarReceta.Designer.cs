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
            this.dgvProductosEnInventario = new System.Windows.Forms.DataGridView();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.chkProductoLiquido = new System.Windows.Forms.CheckBox();
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
            // pnlMedidaEnReceta
            // 
            this.pnlMedidaEnReceta.BackColor = System.Drawing.Color.MediumBlue;
            this.pnlMedidaEnReceta.Controls.Add(this.label1);
            this.pnlMedidaEnReceta.Controls.Add(this.panel3);
            this.pnlMedidaEnReceta.Location = new System.Drawing.Point(415, 137);
            this.pnlMedidaEnReceta.Name = "pnlMedidaEnReceta";
            this.pnlMedidaEnReceta.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnlMedidaEnReceta.Size = new System.Drawing.Size(396, 246);
            this.pnlMedidaEnReceta.TabIndex = 33;
            this.pnlMedidaEnReceta.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMedidaEnReceta_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medida en receta";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.chkProductoLiquido);
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
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
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
            this.cbxUnidadMedida.SelectedIndexChanged += new System.EventHandler(this.CbxUnidadMedida_SelectedIndexChanged);
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
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btnMedidaMedida
            // 
            this.btnMedidaMedida.BackColor = System.Drawing.Color.Teal;
            this.btnMedidaMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedidaMedida.ForeColor = System.Drawing.Color.White;
            this.btnMedidaMedida.Location = new System.Drawing.Point(202, 128);
            this.btnMedidaMedida.Name = "btnMedidaMedida";
            this.btnMedidaMedida.Size = new System.Drawing.Size(175, 75);
            this.btnMedidaMedida.TabIndex = 2;
            this.btnMedidaMedida.Text = "Cancelar";
            this.btnMedidaMedida.UseVisualStyleBackColor = false;
            this.btnMedidaMedida.Click += new System.EventHandler(this.BtnMedidaMedida_Click);
            this.btnMedidaMedida.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnMedidaMedida_MouseClick);
            // 
            // btnAceptarMedida
            // 
            this.btnAceptarMedida.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAceptarMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarMedida.ForeColor = System.Drawing.Color.White;
            this.btnAceptarMedida.Location = new System.Drawing.Point(13, 128);
            this.btnAceptarMedida.Name = "btnAceptarMedida";
            this.btnAceptarMedida.Size = new System.Drawing.Size(183, 75);
            this.btnAceptarMedida.TabIndex = 1;
            this.btnAceptarMedida.Text = "Aceptar";
            this.btnAceptarMedida.UseVisualStyleBackColor = false;
            this.btnAceptarMedida.Click += new System.EventHandler(this.BtnAceptarMedida_Click);
            this.btnAceptarMedida.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAceptarMedida_MouseClick);
            // 
            // nudCantidad
            // 
            this.nudCantidad.DecimalPlaces = 2;
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(113, 14);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(264, 26);
            this.nudCantidad.TabIndex = 0;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.NudCantidad_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 26);
            this.textBox2.TabIndex = 30;
            this.textBox2.Text = "Buscar Producto";
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // btnAgregarReceta
            // 
            this.btnAgregarReceta.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAgregarReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarReceta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarReceta.Location = new System.Drawing.Point(315, 389);
            this.btnAgregarReceta.Name = "btnAgregarReceta";
            this.btnAgregarReceta.Size = new System.Drawing.Size(220, 143);
            this.btnAgregarReceta.TabIndex = 28;
            this.btnAgregarReceta.Text = "Agregar a Receta";
            this.btnAgregarReceta.UseVisualStyleBackColor = false;
            this.btnAgregarReceta.Click += new System.EventHandler(this.BtnAgregarReceta_Click);
            this.btnAgregarReceta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAgregarReceta_MouseClick);
            // 
            // btnRemoverDeReceta
            // 
            this.btnRemoverDeReceta.BackColor = System.Drawing.Color.Teal;
            this.btnRemoverDeReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverDeReceta.ForeColor = System.Drawing.Color.White;
            this.btnRemoverDeReceta.Location = new System.Drawing.Point(541, 389);
            this.btnRemoverDeReceta.Name = "btnRemoverDeReceta";
            this.btnRemoverDeReceta.Size = new System.Drawing.Size(220, 143);
            this.btnRemoverDeReceta.TabIndex = 27;
            this.btnRemoverDeReceta.Text = "Remover de Receta";
            this.btnRemoverDeReceta.UseVisualStyleBackColor = false;
            this.btnRemoverDeReceta.Click += new System.EventHandler(this.BtnRemoverDeReceta_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label21.ForeColor = System.Drawing.Color.MediumBlue;
            this.label21.Location = new System.Drawing.Point(852, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(231, 25);
            this.label21.TabIndex = 26;
            this.label21.Text = "Productos en Receta:";
            this.label21.Click += new System.EventHandler(this.Label21_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("SansSerif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label23.ForeColor = System.Drawing.Color.MediumBlue;
            this.label23.Location = new System.Drawing.Point(24, 7);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(256, 25);
            this.label23.TabIndex = 25;
            this.label23.Text = "Productos en Inventario";
            this.label23.Click += new System.EventHandler(this.Label23_Click);
            // 
            // dgvProductosEnReceta
            // 
            this.dgvProductosEnReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosEnReceta.Location = new System.Drawing.Point(780, 31);
            this.dgvProductosEnReceta.Name = "dgvProductosEnReceta";
            this.dgvProductosEnReceta.Size = new System.Drawing.Size(360, 513);
            this.dgvProductosEnReceta.TabIndex = 24;
            this.dgvProductosEnReceta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductosEnReceta_CellContentClick);
            // 
            // dgvProductosEnInventario
            // 
            this.dgvProductosEnInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosEnInventario.Location = new System.Drawing.Point(0, 66);
            this.dgvProductosEnInventario.Name = "dgvProductosEnInventario";
            this.dgvProductosEnInventario.Size = new System.Drawing.Size(293, 478);
            this.dgvProductosEnInventario.TabIndex = 23;
            this.dgvProductosEnInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductosEnInventario_CellContentClick);
            // 
            // txtComentario
            // 
            this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Location = new System.Drawing.Point(446, 258);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(315, 129);
            this.txtComentario.TabIndex = 22;
            this.txtComentario.TextChanged += new System.EventHandler(this.TxtComentario_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(445, 91);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(316, 156);
            this.txtDescripcion.TabIndex = 21;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.TxtDescripcion_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(445, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(316, 26);
            this.txtNombre.TabIndex = 20;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(310, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(131, 25);
            this.label22.TabIndex = 19;
            this.label22.Text = "Descripción:";
            this.label22.Click += new System.EventHandler(this.Label22_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(309, 252);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 25);
            this.label20.TabIndex = 18;
            this.label20.Text = "Comentario:";
            this.label20.Click += new System.EventHandler(this.Label20_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(309, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 25);
            this.label19.TabIndex = 17;
            this.label19.Text = "Nombre:";
            this.label19.Click += new System.EventHandler(this.Label19_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("SansSerif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label18.ForeColor = System.Drawing.Color.MediumBlue;
            this.label18.Location = new System.Drawing.Point(512, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 33);
            this.label18.TabIndex = 16;
            this.label18.Text = "Receta";
            this.label18.Click += new System.EventHandler(this.Label18_Click);
            // 
            // chkProductoLiquido
            // 
            this.chkProductoLiquido.AutoSize = true;
            this.chkProductoLiquido.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProductoLiquido.ForeColor = System.Drawing.Color.Black;
            this.chkProductoLiquido.Location = new System.Drawing.Point(275, 59);
            this.chkProductoLiquido.Name = "chkProductoLiquido";
            this.chkProductoLiquido.Size = new System.Drawing.Size(102, 18);
            this.chkProductoLiquido.TabIndex = 89;
            this.chkProductoLiquido.Text = "Producto líquido";
            this.chkProductoLiquido.UseVisualStyleBackColor = true;
            this.chkProductoLiquido.CheckedChanged += new System.EventHandler(this.ChkProductoLiquido_CheckedChanged);
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
        private System.Windows.Forms.CheckBox chkProductoLiquido;
    }
}