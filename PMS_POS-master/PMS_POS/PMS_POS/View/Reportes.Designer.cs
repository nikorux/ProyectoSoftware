﻿namespace PMS_POS.View
{
    partial class Reportes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBuscarProductoAjustesInventario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAjustes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBuscarInventario = new System.Windows.Forms.TextBox();
            this.cbxCategoriaInventario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtBuscarRecepcion = new System.Windows.Forms.TextBox();
            this.cbxRecepcion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvRecepcion = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chxPagadas = new System.Windows.Forms.CheckBox();
            this.cbxFormaPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarFacturas = new System.Windows.Forms.TextBox();
            this.cbxFacturasTipoPago = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAjustes)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepcion)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1159, 590);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1151, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ajustes de inventario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.label8.Location = new System.Drawing.Point(35, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ajustes de Inventario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.txtBuscarProductoAjustesInventario);
            this.panel2.Location = new System.Drawing.Point(287, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 50);
            this.panel2.TabIndex = 14;
            // 
            // txtBuscarProductoAjustesInventario
            // 
            this.txtBuscarProductoAjustesInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProductoAjustesInventario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarProductoAjustesInventario.Location = new System.Drawing.Point(7, 13);
            this.txtBuscarProductoAjustesInventario.Name = "txtBuscarProductoAjustesInventario";
            this.txtBuscarProductoAjustesInventario.Size = new System.Drawing.Size(827, 22);
            this.txtBuscarProductoAjustesInventario.TabIndex = 6;
            this.txtBuscarProductoAjustesInventario.Text = "Buscar Producto";
            this.txtBuscarProductoAjustesInventario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtBuscarProducto_MouseClick);
            this.txtBuscarProductoAjustesInventario.TextChanged += new System.EventHandler(this.TxtBuscarProducto_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.dgvAjustes);
            this.panel1.Location = new System.Drawing.Point(6, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 525);
            this.panel1.TabIndex = 12;
            // 
            // dgvAjustes
            // 
            this.dgvAjustes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAjustes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvAjustes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.dgvAjustes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAjustes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAjustes.Location = new System.Drawing.Point(19, 13);
            this.dgvAjustes.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.dgvAjustes.Name = "dgvAjustes";
            this.dgvAjustes.Size = new System.Drawing.Size(1096, 471);
            this.dgvAjustes.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1151, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(35, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Reportes de Inventario";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.panel3.Controls.Add(this.txtBuscarInventario);
            this.panel3.Controls.Add(this.cbxCategoriaInventario);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(287, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(850, 50);
            this.panel3.TabIndex = 16;
            // 
            // txtBuscarInventario
            // 
            this.txtBuscarInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarInventario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarInventario.Location = new System.Drawing.Point(7, 13);
            this.txtBuscarInventario.Name = "txtBuscarInventario";
            this.txtBuscarInventario.Size = new System.Drawing.Size(448, 22);
            this.txtBuscarInventario.TabIndex = 6;
            this.txtBuscarInventario.Text = "Buscar Producto";
            // 
            // cbxCategoriaInventario
            // 
            this.cbxCategoriaInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoriaInventario.FormattingEnabled = true;
            this.cbxCategoriaInventario.Items.AddRange(new object[] {
            "Todas"});
            this.cbxCategoriaInventario.Location = new System.Drawing.Point(565, 13);
            this.cbxCategoriaInventario.Name = "cbxCategoriaInventario";
            this.cbxCategoriaInventario.Size = new System.Drawing.Size(268, 24);
            this.cbxCategoriaInventario.TabIndex = 4;
            this.cbxCategoriaInventario.SelectedIndexChanged += new System.EventHandler(this.CbxCategoria_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(479, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoría:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.panel4.Controls.Add(this.dgvInventario);
            this.panel4.Location = new System.Drawing.Point(6, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1131, 525);
            this.panel4.TabIndex = 15;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(18, 14);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(1096, 471);
            this.dgvInventario.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1151, 564);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Recepción de POS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(21, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Recepción de productos";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.panel5.Controls.Add(this.txtBuscarRecepcion);
            this.panel5.Controls.Add(this.cbxRecepcion);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(287, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(850, 50);
            this.panel5.TabIndex = 16;
            // 
            // txtBuscarRecepcion
            // 
            this.txtBuscarRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarRecepcion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarRecepcion.Location = new System.Drawing.Point(7, 13);
            this.txtBuscarRecepcion.Name = "txtBuscarRecepcion";
            this.txtBuscarRecepcion.Size = new System.Drawing.Size(448, 22);
            this.txtBuscarRecepcion.TabIndex = 6;
            this.txtBuscarRecepcion.Text = "Buscar Producto";
            this.txtBuscarRecepcion.TextChanged += new System.EventHandler(this.TxtBuscarRecepcion_TextChanged);
            // 
            // cbxRecepcion
            // 
            this.cbxRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRecepcion.FormattingEnabled = true;
            this.cbxRecepcion.Items.AddRange(new object[] {
            "Todas"});
            this.cbxRecepcion.Location = new System.Drawing.Point(565, 13);
            this.cbxRecepcion.Name = "cbxRecepcion";
            this.cbxRecepcion.Size = new System.Drawing.Size(268, 24);
            this.cbxRecepcion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(479, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Categoría:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.panel6.Controls.Add(this.dgvRecepcion);
            this.panel6.Location = new System.Drawing.Point(6, 62);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1131, 525);
            this.panel6.TabIndex = 15;
            // 
            // dgvRecepcion
            // 
            this.dgvRecepcion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRecepcion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvRecepcion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.dgvRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecepcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepcion.Location = new System.Drawing.Point(19, 13);
            this.dgvRecepcion.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.dgvRecepcion.Name = "dgvRecepcion";
            this.dgvRecepcion.Size = new System.Drawing.Size(1096, 471);
            this.dgvRecepcion.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.tabPage7.Controls.Add(this.label10);
            this.tabPage7.Controls.Add(this.panel7);
            this.tabPage7.Controls.Add(this.panel8);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1151, 564);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Facturas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.label10.Location = new System.Drawing.Point(35, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Reportes de facturas";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.panel7.Controls.Add(this.chxPagadas);
            this.panel7.Controls.Add(this.cbxFormaPago);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.txtBuscarFacturas);
            this.panel7.Controls.Add(this.cbxFacturasTipoPago);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(287, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(850, 50);
            this.panel7.TabIndex = 16;
            // 
            // chxPagadas
            // 
            this.chxPagadas.AutoSize = true;
            this.chxPagadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxPagadas.ForeColor = System.Drawing.Color.White;
            this.chxPagadas.Location = new System.Drawing.Point(756, 17);
            this.chxPagadas.Name = "chxPagadas";
            this.chxPagadas.Size = new System.Drawing.Size(90, 20);
            this.chxPagadas.TabIndex = 9;
            this.chxPagadas.Text = "Pagadas";
            this.chxPagadas.UseVisualStyleBackColor = true;
            this.chxPagadas.CheckedChanged += new System.EventHandler(this.ChxPagadas_CheckedChanged);
            // 
            // cbxFormaPago
            // 
            this.cbxFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFormaPago.FormattingEnabled = true;
            this.cbxFormaPago.Items.AddRange(new object[] {
            "Todas"});
            this.cbxFormaPago.Location = new System.Drawing.Point(598, 13);
            this.cbxFormaPago.Name = "cbxFormaPago";
            this.cbxFormaPago.Size = new System.Drawing.Size(152, 24);
            this.cbxFormaPago.TabIndex = 7;
            this.cbxFormaPago.SelectedIndexChanged += new System.EventHandler(this.CbxFormaPago_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(500, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Forma Pago:";
            // 
            // txtBuscarFacturas
            // 
            this.txtBuscarFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarFacturas.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarFacturas.Location = new System.Drawing.Point(7, 13);
            this.txtBuscarFacturas.Name = "txtBuscarFacturas";
            this.txtBuscarFacturas.Size = new System.Drawing.Size(237, 22);
            this.txtBuscarFacturas.TabIndex = 6;
            this.txtBuscarFacturas.Text = "Buscar Producto";
            this.txtBuscarFacturas.TextChanged += new System.EventHandler(this.TxtBuscarFacturas_TextChanged);
            // 
            // cbxFacturasTipoPago
            // 
            this.cbxFacturasTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFacturasTipoPago.FormattingEnabled = true;
            this.cbxFacturasTipoPago.Items.AddRange(new object[] {
            "Todas"});
            this.cbxFacturasTipoPago.Location = new System.Drawing.Point(342, 13);
            this.cbxFacturasTipoPago.Name = "cbxFacturasTipoPago";
            this.cbxFacturasTipoPago.Size = new System.Drawing.Size(152, 24);
            this.cbxFacturasTipoPago.TabIndex = 4;
            this.cbxFacturasTipoPago.SelectedIndexChanged += new System.EventHandler(this.CbxFacturasTipoPago_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(251, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo Pago:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.panel8.Controls.Add(this.dgvFacturas);
            this.panel8.Location = new System.Drawing.Point(6, 62);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1131, 525);
            this.panel8.TabIndex = 15;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.dgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(19, 13);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(1096, 495);
            this.dgvFacturas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(39)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(524, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reportes";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1151, 564);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "Historial Ventas";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1151, 564);
            this.tabPage5.TabIndex = 8;
            this.tabPage5.Text = "Historial Ordenes";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Reportes";
            this.Size = new System.Drawing.Size(1162, 638);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAjustes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepcion)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBuscarProductoAjustesInventario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAjustes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBuscarInventario;
        private System.Windows.Forms.ComboBox cbxCategoriaInventario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtBuscarRecepcion;
        private System.Windows.Forms.ComboBox cbxRecepcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvRecepcion;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtBuscarFacturas;
        private System.Windows.Forms.ComboBox cbxFacturasTipoPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxFormaPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chxPagadas;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}
