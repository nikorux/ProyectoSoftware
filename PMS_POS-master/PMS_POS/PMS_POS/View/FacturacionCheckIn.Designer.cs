namespace PMS_POS.View
{
    partial class FacturacionCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturacionCheckIn));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtITBIS = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnRegistrarCheckIn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPay = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.pnlTarjeta = new System.Windows.Forms.Panel();
            this.txtBoxCompania = new System.Windows.Forms.TextBox();
            this.lblDigitos = new System.Windows.Forms.Label();
            this.lblCompania = new System.Windows.Forms.Label();
            this.txtBoxDigitos = new System.Windows.Forms.TextBox();
            this.chkBoxPago = new System.Windows.Forms.CheckBox();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaActual = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCajero = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBusquedaCliente = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dgvHabitacion = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProviderDigitos = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBoxFactura = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPay.SuspendLayout();
            this.pnlTarjeta.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDigitos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(871, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 206);
            this.panel2.TabIndex = 72;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel5.Controls.Add(this.txtTotalAPagar);
            this.panel5.Controls.Add(this.txtDescuento);
            this.panel5.Controls.Add(this.txtITBIS);
            this.panel5.Controls.Add(this.txtSubtotal);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(17, 18);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(343, 173);
            this.panel5.TabIndex = 91;
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Enabled = false;
            this.txtTotalAPagar.Location = new System.Drawing.Point(125, 126);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Size = new System.Drawing.Size(195, 20);
            this.txtTotalAPagar.TabIndex = 95;
            this.txtTotalAPagar.TextChanged += new System.EventHandler(this.TxtTotalAPagar_TextChanged);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(125, 91);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(195, 20);
            this.txtDescuento.TabIndex = 93;
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescuento_KeyPress);
            this.txtDescuento.Leave += new System.EventHandler(this.TxtDescuento_Leave);
            // 
            // txtITBIS
            // 
            this.txtITBIS.Enabled = false;
            this.txtITBIS.Location = new System.Drawing.Point(125, 57);
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.Size = new System.Drawing.Size(195, 20);
            this.txtITBIS.TabIndex = 94;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(125, 25);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(195, 20);
            this.txtSubtotal.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total a pagar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SubTotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "% ITBIS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "% Descuento:";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(93, 17);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(195, 20);
            this.txtEfectivo.TabIndex = 74;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.TxtEfectivo_TextChanged);
            this.txtEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEfectivo_KeyPress);
            this.txtEfectivo.Leave += new System.EventHandler(this.TxtEfectivo_Leave_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "Efectivo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(33, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 32);
            this.label5.TabIndex = 71;
            this.label5.Text = "Registrar Check-in";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImprimir.CausesValidation = false;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(871, 98);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(192, 27);
            this.btnImprimir.TabIndex = 77;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseCompatibleTextRendering = true;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click_1);
            // 
            // btnRegistrarCheckIn
            // 
            this.btnRegistrarCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarCheckIn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarCheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegistrarCheckIn.CausesValidation = false;
            this.btnRegistrarCheckIn.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCheckIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCheckIn.Location = new System.Drawing.Point(568, 98);
            this.btnRegistrarCheckIn.Name = "btnRegistrarCheckIn";
            this.btnRegistrarCheckIn.Size = new System.Drawing.Size(295, 27);
            this.btnRegistrarCheckIn.TabIndex = 88;
            this.btnRegistrarCheckIn.Text = "Confirmar Check-In";
            this.btnRegistrarCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarCheckIn.UseCompatibleTextRendering = true;
            this.btnRegistrarCheckIn.UseVisualStyleBackColor = false;
            this.btnRegistrarCheckIn.Click += new System.EventHandler(this.BtnRegistrarCheckIn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(39, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(820, 278);
            this.panel4.TabIndex = 89;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.pnlPay);
            this.panel1.Controls.Add(this.chkBoxPago);
            this.panel1.Controls.Add(this.txtNumDocumento);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dtpFechaActual);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txtCajero);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtIdCliente);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(17, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 210);
            this.panel1.TabIndex = 90;
            // 
            // pnlPay
            // 
            this.pnlPay.Controls.Add(this.label13);
            this.pnlPay.Controls.Add(this.cmbFormaPago);
            this.pnlPay.Controls.Add(this.pnlTarjeta);
            this.pnlPay.Location = new System.Drawing.Point(392, 14);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(384, 166);
            this.pnlPay.TabIndex = 111;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Forma de pago:";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cmbFormaPago.Location = new System.Drawing.Point(151, 1);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(194, 21);
            this.cmbFormaPago.TabIndex = 22;
            this.cmbFormaPago.TextChanged += new System.EventHandler(this.CmbFormaPago_TextChanged);
            // 
            // pnlTarjeta
            // 
            this.pnlTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTarjeta.Controls.Add(this.txtBoxCompania);
            this.pnlTarjeta.Controls.Add(this.lblDigitos);
            this.pnlTarjeta.Controls.Add(this.lblCompania);
            this.pnlTarjeta.Controls.Add(this.txtBoxDigitos);
            this.pnlTarjeta.Location = new System.Drawing.Point(22, 34);
            this.pnlTarjeta.Name = "pnlTarjeta";
            this.pnlTarjeta.Size = new System.Drawing.Size(347, 96);
            this.pnlTarjeta.TabIndex = 36;
            this.pnlTarjeta.Visible = false;
            // 
            // txtBoxCompania
            // 
            this.txtBoxCompania.Location = new System.Drawing.Point(137, 59);
            this.txtBoxCompania.Name = "txtBoxCompania";
            this.txtBoxCompania.Size = new System.Drawing.Size(194, 20);
            this.txtBoxCompania.TabIndex = 35;
            // 
            // lblDigitos
            // 
            this.lblDigitos.AutoSize = true;
            this.lblDigitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitos.Location = new System.Drawing.Point(4, 9);
            this.lblDigitos.Name = "lblDigitos";
            this.lblDigitos.Size = new System.Drawing.Size(121, 20);
            this.lblDigitos.TabIndex = 34;
            this.lblDigitos.Text = "Último 4 dígitos:";
            this.lblDigitos.Click += new System.EventHandler(this.LblDigitos_Click);
            // 
            // lblCompania
            // 
            this.lblCompania.AutoSize = true;
            this.lblCompania.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompania.Location = new System.Drawing.Point(4, 57);
            this.lblCompania.Name = "lblCompania";
            this.lblCompania.Size = new System.Drawing.Size(85, 20);
            this.lblCompania.TabIndex = 32;
            this.lblCompania.Text = "Compañía:";
            // 
            // txtBoxDigitos
            // 
            this.txtBoxDigitos.Location = new System.Drawing.Point(137, 11);
            this.txtBoxDigitos.Name = "txtBoxDigitos";
            this.txtBoxDigitos.Size = new System.Drawing.Size(194, 20);
            this.txtBoxDigitos.TabIndex = 33;
            this.txtBoxDigitos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxDigitos_KeyPress);
            // 
            // chkBoxPago
            // 
            this.chkBoxPago.AutoSize = true;
            this.chkBoxPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxPago.Location = new System.Drawing.Point(617, 177);
            this.chkBoxPago.Name = "chkBoxPago";
            this.chkBoxPago.Size = new System.Drawing.Size(159, 24);
            this.chkBoxPago.TabIndex = 96;
            this.chkBoxPago.Text = "Pago en Checkout";
            this.chkBoxPago.UseVisualStyleBackColor = true;
            this.chkBoxPago.CheckedChanged += new System.EventHandler(this.ChkBoxPago_CheckedChanged);
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Enabled = false;
            this.txtNumDocumento.Location = new System.Drawing.Point(171, 111);
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Size = new System.Drawing.Size(194, 20);
            this.txtNumDocumento.TabIndex = 110;
            this.txtNumDocumento.TextChanged += new System.EventHandler(this.TxtNumDocumento_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 20);
            this.label11.TabIndex = 109;
            this.label11.Text = "Núm Documento";
            this.label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // dtpFechaActual
            // 
            this.dtpFechaActual.Enabled = false;
            this.dtpFechaActual.Location = new System.Drawing.Point(171, 177);
            this.dtpFechaActual.Name = "dtpFechaActual";
            this.dtpFechaActual.Size = new System.Drawing.Size(194, 20);
            this.dtpFechaActual.TabIndex = 31;
            this.dtpFechaActual.ValueChanged += new System.EventHandler(this.DtpFechaActual_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(23, 177);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 20);
            this.label21.TabIndex = 30;
            this.label21.Text = "Fecha:";
            this.label21.Click += new System.EventHandler(this.Label21_Click);
            // 
            // txtCajero
            // 
            this.txtCajero.Location = new System.Drawing.Point(171, 141);
            this.txtCajero.Name = "txtCajero";
            this.txtCajero.Size = new System.Drawing.Size(194, 20);
            this.txtCajero.TabIndex = 25;
            this.txtCajero.TextChanged += new System.EventHandler(this.TxtCajero_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(22, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 20);
            this.label19.TabIndex = 24;
            this.label19.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(171, 80);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(194, 20);
            this.txtTelefono.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(171, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(171, 15);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(194, 20);
            this.txtIdCliente.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nombre Cliente:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Atendido por:";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Id Cliente:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(1070, 98);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 27);
            this.btnCancelar.TabIndex = 90;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseCompatibleTextRendering = true;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(871, 352);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(376, 77);
            this.panel6.TabIndex = 91;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel7.Controls.Add(this.txtEfectivo);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(17, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(343, 53);
            this.panel7.TabIndex = 91;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Location = new System.Drawing.Point(871, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 77);
            this.panel3.TabIndex = 92;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel8.Controls.Add(this.txtCambio);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(17, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(343, 53);
            this.panel8.TabIndex = 91;
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Location = new System.Drawing.Point(93, 17);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(195, 20);
            this.txtCambio.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Cambio:";
            // 
            // txtBusquedaCliente
            // 
            this.txtBusquedaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusquedaCliente.Location = new System.Drawing.Point(382, 16);
            this.txtBusquedaCliente.Name = "txtBusquedaCliente";
            this.txtBusquedaCliente.Size = new System.Drawing.Size(173, 13);
            this.txtBusquedaCliente.TabIndex = 35;
            this.txtBusquedaCliente.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(167, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(184, 20);
            this.label23.TabIndex = 34;
            this.label23.Text = "Búsqueda por Id Cliente:";
            this.label23.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel9.Controls.Add(this.pictureBox2);
            this.panel9.Controls.Add(this.txtBusquedaCliente);
            this.panel9.Controls.Add(this.pictureBox1);
            this.panel9.Controls.Add(this.label23);
            this.panel9.Location = new System.Drawing.Point(56, 146);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(790, 46);
            this.panel9.TabIndex = 91;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(355, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 95;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel10.Controls.Add(this.dgvHabitacion);
            this.panel10.Location = new System.Drawing.Point(39, 433);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(820, 137);
            this.panel10.TabIndex = 93;
            // 
            // dgvHabitacion
            // 
            this.dgvHabitacion.AllowUserToAddRows = false;
            this.dgvHabitacion.AllowUserToDeleteRows = false;
            this.dgvHabitacion.AllowUserToResizeColumns = false;
            this.dgvHabitacion.AllowUserToResizeRows = false;
            this.dgvHabitacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHabitacion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitacion.Enabled = false;
            this.dgvHabitacion.Location = new System.Drawing.Point(17, 16);
            this.dgvHabitacion.Name = "dgvHabitacion";
            this.dgvHabitacion.ReadOnly = true;
            this.dgvHabitacion.Size = new System.Drawing.Size(783, 113);
            this.dgvHabitacion.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(62, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 21);
            this.label10.TabIndex = 94;
            this.label10.Text = "Habitación Reservada";
            // 
            // errorProviderDigitos
            // 
            this.errorProviderDigitos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderDigitos.ContainerControl = this;
            // 
            // txtBoxFactura
            // 
            this.txtBoxFactura.Location = new System.Drawing.Point(871, 535);
            this.txtBoxFactura.Name = "txtBoxFactura";
            this.txtBoxFactura.Size = new System.Drawing.Size(398, 139);
            this.txtBoxFactura.TabIndex = 96;
            this.txtBoxFactura.Text = "";
            this.txtBoxFactura.Visible = false;
            // 
            // FacturacionCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.txtBoxFactura);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnRegistrarCheckIn);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Name = "FacturacionCheckIn";
            this.Size = new System.Drawing.Size(1287, 677);
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPay.ResumeLayout(false);
            this.pnlPay.PerformLayout();
            this.pnlTarjeta.ResumeLayout(false);
            this.pnlTarjeta.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDigitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnRegistrarCheckIn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtITBIS;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCajero;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpFechaActual;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtBusquedaCliente;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dgvHabitacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxCompania;
        private System.Windows.Forms.Label lblDigitos;
        private System.Windows.Forms.TextBox txtBoxDigitos;
        private System.Windows.Forms.Label lblCompania;
        private System.Windows.Forms.Panel pnlTarjeta;
        private System.Windows.Forms.ErrorProvider errorProviderDigitos;
        private System.Windows.Forms.TextBox txtNumDocumento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtBoxFactura;
        private System.Windows.Forms.CheckBox chkBoxPago;
        private System.Windows.Forms.Panel pnlPay;
    }
}
