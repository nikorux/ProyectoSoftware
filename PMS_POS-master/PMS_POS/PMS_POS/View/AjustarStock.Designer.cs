namespace PMS_POS.View
{
    partial class AjustarStock
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelarAjuste = new System.Windows.Forms.Button();
            this.btnGuardarAjuste = new System.Windows.Forms.Button();
            this.lblProductoAjustar = new System.Windows.Forms.Label();
            this.lblNombreProductoAjustar = new System.Windows.Forms.Label();
            this.cbxUnidadMedidaAjustar = new System.Windows.Forms.ComboBox();
            this.cbxAccionAjuste = new System.Windows.Forms.ComboBox();
            this.nudCantidadAjustar = new System.Windows.Forms.NumericUpDown();
            this.lblUnidadMedidaActual = new System.Windows.Forms.Label();
            this.lblCantidadAntesAjustar = new System.Windows.Forms.Label();
            this.lblCantidadActual = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAjustar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 33);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(259, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajustar Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unidad de medida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Acción:";
            // 
            // btnCancelarAjuste
            // 
            this.btnCancelarAjuste.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCancelarAjuste.Location = new System.Drawing.Point(338, 361);
            this.btnCancelarAjuste.Name = "btnCancelarAjuste";
            this.btnCancelarAjuste.Size = new System.Drawing.Size(128, 35);
            this.btnCancelarAjuste.TabIndex = 7;
            this.btnCancelarAjuste.Text = "Cancelar";
            this.btnCancelarAjuste.UseVisualStyleBackColor = true;
            this.btnCancelarAjuste.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGuardarAjuste
            // 
            this.btnGuardarAjuste.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnGuardarAjuste.Location = new System.Drawing.Point(148, 361);
            this.btnGuardarAjuste.Name = "btnGuardarAjuste";
            this.btnGuardarAjuste.Size = new System.Drawing.Size(127, 35);
            this.btnGuardarAjuste.TabIndex = 8;
            this.btnGuardarAjuste.Text = "Guardar";
            this.btnGuardarAjuste.UseVisualStyleBackColor = true;
            this.btnGuardarAjuste.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblProductoAjustar
            // 
            this.lblProductoAjustar.AutoSize = true;
            this.lblProductoAjustar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoAjustar.Location = new System.Drawing.Point(40, 71);
            this.lblProductoAjustar.Name = "lblProductoAjustar";
            this.lblProductoAjustar.Size = new System.Drawing.Size(132, 25);
            this.lblProductoAjustar.TabIndex = 10;
            this.lblProductoAjustar.Text = "PRODUCTO:";
            // 
            // lblNombreProductoAjustar
            // 
            this.lblNombreProductoAjustar.AutoSize = true;
            this.lblNombreProductoAjustar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblNombreProductoAjustar.Location = new System.Drawing.Point(259, 71);
            this.lblNombreProductoAjustar.Name = "lblNombreProductoAjustar";
            this.lblNombreProductoAjustar.Size = new System.Drawing.Size(120, 24);
            this.lblNombreProductoAjustar.TabIndex = 11;
            this.lblNombreProductoAjustar.Text = "-producto-";
            // 
            // cbxUnidadMedidaAjustar
            // 
            this.cbxUnidadMedidaAjustar.BackColor = System.Drawing.SystemColors.Menu;
            this.cbxUnidadMedidaAjustar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnidadMedidaAjustar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUnidadMedidaAjustar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnidadMedidaAjustar.FormattingEnabled = true;
            this.cbxUnidadMedidaAjustar.Items.AddRange(new object[] {
            "Kilogramo",
            "Grano",
            "Onza",
            "Libra",
            "Miligramo",
            "Gramo",
            "Cuchara de madera",
            "Onza fluida",
            "Taza",
            "Medio litro",
            "Cuarto de galón",
            "Galón",
            "Barril",
            "Milímetro cb",
            "Mililitros",
            "Litros"});
            this.cbxUnidadMedidaAjustar.Location = new System.Drawing.Point(369, 291);
            this.cbxUnidadMedidaAjustar.Name = "cbxUnidadMedidaAjustar";
            this.cbxUnidadMedidaAjustar.Size = new System.Drawing.Size(202, 32);
            this.cbxUnidadMedidaAjustar.TabIndex = 56;
            // 
            // cbxAccionAjuste
            // 
            this.cbxAccionAjuste.BackColor = System.Drawing.SystemColors.Menu;
            this.cbxAccionAjuste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAccionAjuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAccionAjuste.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAccionAjuste.FormattingEnabled = true;
            this.cbxAccionAjuste.Items.AddRange(new object[] {
            "Aumentar",
            "Disminuir"});
            this.cbxAccionAjuste.Location = new System.Drawing.Point(263, 125);
            this.cbxAccionAjuste.Name = "cbxAccionAjuste";
            this.cbxAccionAjuste.Size = new System.Drawing.Size(159, 32);
            this.cbxAccionAjuste.TabIndex = 57;
            // 
            // nudCantidadAjustar
            // 
            this.nudCantidadAjustar.BackColor = System.Drawing.SystemColors.Menu;
            this.nudCantidadAjustar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCantidadAjustar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nudCantidadAjustar.Location = new System.Drawing.Point(369, 210);
            this.nudCantidadAjustar.Name = "nudCantidadAjustar";
            this.nudCantidadAjustar.Size = new System.Drawing.Size(151, 25);
            this.nudCantidadAjustar.TabIndex = 64;
            // 
            // lblUnidadMedidaActual
            // 
            this.lblUnidadMedidaActual.AutoSize = true;
            this.lblUnidadMedidaActual.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedidaActual.Location = new System.Drawing.Point(49, 74);
            this.lblUnidadMedidaActual.Name = "lblUnidadMedidaActual";
            this.lblUnidadMedidaActual.Size = new System.Drawing.Size(94, 21);
            this.lblUnidadMedidaActual.TabIndex = 66;
            this.lblUnidadMedidaActual.Text = "-producto-";
            // 
            // lblCantidadAntesAjustar
            // 
            this.lblCantidadAntesAjustar.AutoSize = true;
            this.lblCantidadAntesAjustar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAntesAjustar.Location = new System.Drawing.Point(26, 17);
            this.lblCantidadAntesAjustar.Name = "lblCantidadAntesAjustar";
            this.lblCantidadAntesAjustar.Size = new System.Drawing.Size(141, 19);
            this.lblCantidadAntesAjustar.TabIndex = 65;
            this.lblCantidadAntesAjustar.Text = "Cantidad actual:";
            // 
            // lblCantidadActual
            // 
            this.lblCantidadActual.AutoSize = true;
            this.lblCantidadActual.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadActual.Location = new System.Drawing.Point(49, 44);
            this.lblCantidadActual.Name = "lblCantidadActual";
            this.lblCantidadActual.Size = new System.Drawing.Size(94, 21);
            this.lblCantidadActual.TabIndex = 68;
            this.lblCantidadActual.Text = "-producto-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCantidadActual);
            this.groupBox1.Controls.Add(this.lblCantidadAntesAjustar);
            this.groupBox1.Controls.Add(this.lblUnidadMedidaActual);
            this.groupBox1.Location = new System.Drawing.Point(57, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 113);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // AjustarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudCantidadAjustar);
            this.Controls.Add(this.cbxAccionAjuste);
            this.Controls.Add(this.cbxUnidadMedidaAjustar);
            this.Controls.Add(this.lblNombreProductoAjustar);
            this.Controls.Add(this.lblProductoAjustar);
            this.Controls.Add(this.btnGuardarAjuste);
            this.Controls.Add(this.btnCancelarAjuste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AjustarStock";
            this.Size = new System.Drawing.Size(626, 415);
            this.Load += new System.EventHandler(this.AjustarStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAjustar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelarAjuste;
        private System.Windows.Forms.Button btnGuardarAjuste;
        private System.Windows.Forms.Label lblProductoAjustar;
        private System.Windows.Forms.Label lblNombreProductoAjustar;
        private System.Windows.Forms.ComboBox cbxUnidadMedidaAjustar;
        private System.Windows.Forms.ComboBox cbxAccionAjuste;
        private System.Windows.Forms.NumericUpDown nudCantidadAjustar;
        private System.Windows.Forms.Label lblUnidadMedidaActual;
        private System.Windows.Forms.Label lblCantidadAntesAjustar;
        private System.Windows.Forms.Label lblCantidadActual;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
