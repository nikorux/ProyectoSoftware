﻿namespace PMS_POS.View
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnVerMenuActual = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.dgvProductosEnMenu = new System.Windows.Forms.DataGridView();
            this.dgvProductosDisponibles = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosDisponibles)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnVerMenuActual);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.btnRemoverItem);
            this.panel1.Controls.Add(this.btnAgregarItem);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 470);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.txtBuscarProducto);
            this.panel2.Controls.Add(this.cbxCategoria);
            this.panel2.Location = new System.Drawing.Point(12, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 59);
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
            this.btnVerMenuActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerMenuActual.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVerMenuActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMenuActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMenuActual.ForeColor = System.Drawing.Color.White;
            this.btnVerMenuActual.Location = new System.Drawing.Point(368, 34);
            this.btnVerMenuActual.Name = "btnVerMenuActual";
            this.btnVerMenuActual.Size = new System.Drawing.Size(319, 36);
            this.btnVerMenuActual.TabIndex = 29;
            this.btnVerMenuActual.Text = "Ver Menu Actual";
            this.btnVerMenuActual.UseVisualStyleBackColor = false;
            this.btnVerMenuActual.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnVerMenuActual_MouseClick);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(81)))), ((int)(((byte)(193)))));
            this.lblCategoria.Location = new System.Drawing.Point(487, 73);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(81, 18);
            this.lblCategoria.TabIndex = 28;
            this.lblCategoria.Text = "Categoria";
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoverItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRemoverItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoverItem.Location = new System.Drawing.Point(290, 268);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(75, 29);
            this.btnRemoverItem.TabIndex = 24;
            this.btnRemoverItem.Text = "<<";
            this.btnRemoverItem.UseVisualStyleBackColor = false;
            this.btnRemoverItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnRemoverItem_MouseClick);
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItem.ForeColor = System.Drawing.Color.White;
            this.btnAgregarItem.Location = new System.Drawing.Point(290, 232);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(75, 30);
            this.btnAgregarItem.TabIndex = 23;
            this.btnAgregarItem.Text = ">>";
            this.btnAgregarItem.UseVisualStyleBackColor = false;
            this.btnAgregarItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAgregarItem_MouseClick);
            // 
            // dgvProductosEnMenu
            // 
            this.dgvProductosEnMenu.AllowUserToAddRows = false;
            this.dgvProductosEnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductosEnMenu.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvProductosEnMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosEnMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosEnMenu.Location = new System.Drawing.Point(3, 3);
            this.dgvProductosEnMenu.Name = "dgvProductosEnMenu";
            this.dgvProductosEnMenu.Size = new System.Drawing.Size(314, 367);
            this.dgvProductosEnMenu.TabIndex = 21;
            // 
            // dgvProductosDisponibles
            // 
            this.dgvProductosDisponibles.AllowUserToAddRows = false;
            this.dgvProductosDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProductosDisponibles.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvProductosDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosDisponibles.Location = new System.Drawing.Point(3, 3);
            this.dgvProductosDisponibles.Name = "dgvProductosDisponibles";
            this.dgvProductosDisponibles.Size = new System.Drawing.Size(271, 370);
            this.dgvProductosDisponibles.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(287, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 29);
            this.label14.TabIndex = 19;
            this.label14.Text = "Menu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.dgvProductosEnMenu);
            this.panel3.Location = new System.Drawing.Point(366, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 373);
            this.panel3.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.dgvProductosDisponibles);
            this.panel4.Location = new System.Drawing.Point(12, 91);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 376);
            this.panel4.TabIndex = 32;
            // 
            // MenuConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 470);
            this.Controls.Add(this.panel1);
            this.Name = "MenuConfigurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIGURACION DE MENU";
            this.Load += new System.EventHandler(this.MenuConfigurar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosDisponibles)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVerMenuActual;
        private System.Windows.Forms.Label lblCategoria;
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
    }
}