namespace PMS_POS.View
{
    partial class RegistrarNuevaCompra
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
            this.dgvProductosComprados = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spnCantComprada = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProductosRegistrados = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIdInsumo = new System.Windows.Forms.TextBox();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.txtCantDisp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosComprados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantComprada)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosRegistrados)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductosComprados
            // 
            this.dgvProductosComprados.AllowUserToAddRows = false;
            this.dgvProductosComprados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosComprados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosComprados.Location = new System.Drawing.Point(16, 19);
            this.dgvProductosComprados.Name = "dgvProductosComprados";
            this.dgvProductosComprados.ReadOnly = true;
            this.dgvProductosComprados.Size = new System.Drawing.Size(728, 150);
            this.dgvProductosComprados.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.Location = new System.Drawing.Point(579, 319);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 32);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar a Inventario";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscar.Location = new System.Drawing.Point(44, 294);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(301, 20);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.Text = "Buscar Producto";
            this.txtBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtBuscar_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(92, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registrar nueva compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cantidad Comprada:";
            // 
            // spnCantComprada
            // 
            this.spnCantComprada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.spnCantComprada.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnCantComprada.ForeColor = System.Drawing.Color.RoyalBlue;
            this.spnCantComprada.Location = new System.Drawing.Point(280, 160);
            this.spnCantComprada.Name = "spnCantComprada";
            this.spnCantComprada.Size = new System.Drawing.Size(120, 27);
            this.spnCantComprada.TabIndex = 7;
            this.spnCantComprada.ValueChanged += new System.EventHandler(this.spnCantComprada_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProductosComprados);
            this.groupBox1.Location = new System.Drawing.Point(117, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 180);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos comprados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProductosRegistrados);
            this.groupBox2.Location = new System.Drawing.Point(44, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 180);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos registrados";
            // 
            // dgvProductosRegistrados
            // 
            this.dgvProductosRegistrados.AllowUserToAddRows = false;
            this.dgvProductosRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosRegistrados.Location = new System.Drawing.Point(7, 19);
            this.dgvProductosRegistrados.Name = "dgvProductosRegistrados";
            this.dgvProductosRegistrados.ReadOnly = true;
            this.dgvProductosRegistrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosRegistrados.Size = new System.Drawing.Size(457, 150);
            this.dgvProductosRegistrados.TabIndex = 1;
            this.dgvProductosRegistrados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosRegistrados_CellClick);
            this.dgvProductosRegistrados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosRegistrados_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(789, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total compra:";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Location = new System.Drawing.Point(861, 326);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(116, 20);
            this.txtTotalCompra.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(980, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre Producto:";
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNombreProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProd.ForeColor = System.Drawing.Color.Tomato;
            this.txtNombreProd.Location = new System.Drawing.Point(14, 75);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(170, 24);
            this.txtNombreProd.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIdInsumo);
            this.groupBox3.Controls.Add(this.txtIdProveedor);
            this.groupBox3.Controls.Add(this.txtCantDisp);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.txtPrecioProd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtNombreProd);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.spnCantComprada);
            this.groupBox3.Location = new System.Drawing.Point(565, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 199);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Producto Seleccionado:";
            // 
            // txtIdInsumo
            // 
            this.txtIdInsumo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtIdInsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdInsumo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdInsumo.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtIdInsumo.Location = new System.Drawing.Point(324, 117);
            this.txtIdInsumo.Name = "txtIdInsumo";
            this.txtIdInsumo.Size = new System.Drawing.Size(40, 24);
            this.txtIdInsumo.TabIndex = 22;
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.BackColor = System.Drawing.SystemColors.Menu;
            this.txtIdProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProveedor.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtIdProveedor.Location = new System.Drawing.Point(380, 117);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(40, 24);
            this.txtIdProveedor.TabIndex = 19;
            // 
            // txtCantDisp
            // 
            this.txtCantDisp.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCantDisp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantDisp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantDisp.ForeColor = System.Drawing.Color.Tomato;
            this.txtCantDisp.Location = new System.Drawing.Point(14, 162);
            this.txtCantDisp.Name = "txtCantDisp";
            this.txtCantDisp.Size = new System.Drawing.Size(146, 24);
            this.txtCantDisp.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cantidad Disponible:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Menu;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtId.Location = new System.Drawing.Point(380, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 24);
            this.txtId.TabIndex = 18;
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPrecioProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioProd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProd.ForeColor = System.Drawing.Color.Tomato;
            this.txtPrecioProd.Location = new System.Drawing.Point(254, 75);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(146, 24);
            this.txtPrecioProd.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Precio Producto:";
            // 
            // RegistrarNuevaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "RegistrarNuevaCompra";
            this.Size = new System.Drawing.Size(1044, 644);
            this.Load += new System.EventHandler(this.RegistrarNuevaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosComprados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantComprada)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosRegistrados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProductosComprados;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spnCantComprada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProductosRegistrados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantDisp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.TextBox txtIdInsumo;
    }
}
