namespace PMS_POS.View
{
    partial class MenuConfigurar
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvProductosDisponibles = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvProductosEnMenu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnVerMenuActual = new System.Windows.Forms.Button();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCajaSeleccionada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosDisponibles)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.dgvProductosDisponibles);
            this.panel4.Location = new System.Drawing.Point(29, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 411);
            this.panel4.TabIndex = 32;
            // 
            // dgvProductosDisponibles
            // 
            this.dgvProductosDisponibles.AllowUserToAddRows = false;
            this.dgvProductosDisponibles.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvProductosDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosDisponibles.Location = new System.Drawing.Point(3, 3);
            this.dgvProductosDisponibles.Name = "dgvProductosDisponibles";
            this.dgvProductosDisponibles.Size = new System.Drawing.Size(271, 405);
            this.dgvProductosDisponibles.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.dgvProductosEnMenu);
            this.panel3.Location = new System.Drawing.Point(383, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 411);
            this.panel3.TabIndex = 31;
            // 
            // dgvProductosEnMenu
            // 
            this.dgvProductosEnMenu.AllowUserToAddRows = false;
            this.dgvProductosEnMenu.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvProductosEnMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosEnMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosEnMenu.Location = new System.Drawing.Point(4, 3);
            this.dgvProductosEnMenu.Name = "dgvProductosEnMenu";
            this.dgvProductosEnMenu.Size = new System.Drawing.Size(314, 405);
            this.dgvProductosEnMenu.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.txtBuscarProducto);
            this.panel2.Controls.Add(this.cbxCategoria);
            this.panel2.Location = new System.Drawing.Point(29, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 59);
            this.panel2.TabIndex = 30;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscarProducto.Location = new System.Drawing.Point(3, 32);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(263, 20);
            this.txtBuscarProducto.TabIndex = 26;
            this.txtBuscarProducto.Text = "Buscar Producto";
            this.txtBuscarProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtBuscarProducto_MouseClick);
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.TxtBuscarProducto_TextChanged);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Todas"});
            this.cbxCategoria.Location = new System.Drawing.Point(3, 5);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(201, 21);
            this.cbxCategoria.TabIndex = 27;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.CbxCategoria_SelectedIndexChanged);
            // 
            // btnVerMenuActual
            // 
            this.btnVerMenuActual.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVerMenuActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMenuActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMenuActual.ForeColor = System.Drawing.Color.White;
            this.btnVerMenuActual.Location = new System.Drawing.Point(382, 53);
            this.btnVerMenuActual.Name = "btnVerMenuActual";
            this.btnVerMenuActual.Size = new System.Drawing.Size(319, 36);
            this.btnVerMenuActual.TabIndex = 29;
            this.btnVerMenuActual.Text = "Ver Menu Actual";
            this.btnVerMenuActual.UseVisualStyleBackColor = false;
            this.btnVerMenuActual.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnVerMenuActual_MouseClick);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRemoverItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoverItem.Location = new System.Drawing.Point(306, 304);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(75, 29);
            this.btnRemoverItem.TabIndex = 24;
            this.btnRemoverItem.Text = "<<";
            this.btnRemoverItem.UseVisualStyleBackColor = false;
            this.btnRemoverItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnRemoverItem_MouseClick);
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItem.ForeColor = System.Drawing.Color.White;
            this.btnAgregarItem.Location = new System.Drawing.Point(306, 268);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(75, 30);
            this.btnAgregarItem.TabIndex = 23;
            this.btnAgregarItem.Text = ">>";
            this.btnAgregarItem.UseVisualStyleBackColor = false;
            this.btnAgregarItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAgregarItem_MouseClick);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(80, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 33);
            this.label14.TabIndex = 19;
            this.label14.Text = "Menu";
            // 
            // txtCajaSeleccionada
            // 
            this.txtCajaSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCajaSeleccionada.ForeColor = System.Drawing.Color.DarkRed;
            this.txtCajaSeleccionada.Location = new System.Drawing.Point(456, 12);
            this.txtCajaSeleccionada.Name = "txtCajaSeleccionada";
            this.txtCajaSeleccionada.ReadOnly = true;
            this.txtCajaSeleccionada.Size = new System.Drawing.Size(222, 31);
            this.txtCajaSeleccionada.TabIndex = 33;
            this.txtCajaSeleccionada.Text = "Seleccionar";
            this.txtCajaSeleccionada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(381, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Caja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(389, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "En Mostrador:";
            // 
            // MenuConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCajaSeleccionada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnVerMenuActual);
            this.Controls.Add(this.btnAgregarItem);
            this.Controls.Add(this.btnRemoverItem);
            this.Name = "MenuConfigurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIGURACION DE MENU";
            this.Load += new System.EventHandler(this.MenuConfigurar_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosDisponibles)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVerMenuActual;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvProductosEnMenu;
        private System.Windows.Forms.DataGridView dgvProductosDisponibles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCajaSeleccionada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}