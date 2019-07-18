namespace PMS_POS.View
{
    partial class PosForm
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
            this.panelPOS = new System.Windows.Forms.Panel();
            this.panelBasePOS = new System.Windows.Forms.Panel();
            this.panelBotonesPOS = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMostrador = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panelUIseleccionada = new System.Windows.Forms.Panel();
            this.lblestadoUI = new System.Windows.Forms.Label();
            this.panelPOS.SuspendLayout();
            this.panelBasePOS.SuspendLayout();
            this.panelBotonesPOS.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPOS
            // 
            this.panelPOS.Controls.Add(this.panelBasePOS);
            this.panelPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPOS.Location = new System.Drawing.Point(0, 0);
            this.panelPOS.Name = "panelPOS";
            this.panelPOS.Size = new System.Drawing.Size(1187, 686);
            this.panelPOS.TabIndex = 0;
            // 
            // panelBasePOS
            // 
            this.panelBasePOS.BackColor = System.Drawing.Color.SteelBlue;
            this.panelBasePOS.Controls.Add(this.panelBotonesPOS);
            this.panelBasePOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBasePOS.Location = new System.Drawing.Point(0, 0);
            this.panelBasePOS.Name = "panelBasePOS";
            this.panelBasePOS.Size = new System.Drawing.Size(1187, 686);
            this.panelBasePOS.TabIndex = 1;
            // 
            // panelBotonesPOS
            // 
            this.panelBotonesPOS.AutoSize = true;
            this.panelBotonesPOS.BackColor = System.Drawing.Color.White;
            this.panelBotonesPOS.Controls.Add(this.panel1);
            this.panelBotonesPOS.Controls.Add(this.btnRegresar);
            this.panelBotonesPOS.Controls.Add(this.panelUIseleccionada);
            this.panelBotonesPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotonesPOS.Location = new System.Drawing.Point(0, 0);
            this.panelBotonesPOS.Name = "panelBotonesPOS";
            this.panelBotonesPOS.Size = new System.Drawing.Size(1187, 689);
            this.panelBotonesPOS.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnMostrador);
            this.panel1.Controls.Add(this.btnInventario);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.btnProveedores);
            this.panel1.Controls.Add(this.btnOrdenes);
            this.panel1.Location = new System.Drawing.Point(843, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 644);
            this.panel1.TabIndex = 10;
            // 
            // btnMostrador
            // 
            this.btnMostrador.BackColor = System.Drawing.Color.MediumBlue;
            this.btnMostrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrador.ForeColor = System.Drawing.Color.White;
            this.btnMostrador.Location = new System.Drawing.Point(55, 370);
            this.btnMostrador.Name = "btnMostrador";
            this.btnMostrador.Size = new System.Drawing.Size(248, 179);
            this.btnMostrador.TabIndex = 9;
            this.btnMostrador.Text = "Ir al Mostrador";
            this.btnMostrador.UseVisualStyleBackColor = false;
            this.btnMostrador.Click += new System.EventHandler(this.BtnMostrador_Click);
            this.btnMostrador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnMostrador_MouseClick);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.MediumBlue;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Location = new System.Drawing.Point(55, 84);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(248, 84);
            this.btnInventario.TabIndex = 7;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnInventario_MouseClick);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.MediumBlue;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(55, 174);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(108, 84);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnMenu_MouseClick);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.MediumBlue;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(55, 264);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(108, 84);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnReportes_MouseClick);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.MediumBlue;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Location = new System.Drawing.Point(195, 174);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(108, 84);
            this.btnProveedores.TabIndex = 6;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnProveedores_MouseClick);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.MediumBlue;
            this.btnOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenes.ForeColor = System.Drawing.Color.White;
            this.btnOrdenes.Location = new System.Drawing.Point(195, 264);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(108, 84);
            this.btnOrdenes.TabIndex = 8;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnOrdenes_MouseClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRegresar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(0, 0);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(1187, 43);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Inicio";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnRegresar_MouseClick);
            // 
            // panelUIseleccionada
            // 
            this.panelUIseleccionada.Location = new System.Drawing.Point(0, 39);
            this.panelUIseleccionada.Name = "panelUIseleccionada";
            this.panelUIseleccionada.Size = new System.Drawing.Size(1187, 647);
            this.panelUIseleccionada.TabIndex = 11;
            // 
            // lblestadoUI
            // 
            this.lblestadoUI.AutoSize = true;
            this.lblestadoUI.Location = new System.Drawing.Point(31, 90);
            this.lblestadoUI.Name = "lblestadoUI";
            this.lblestadoUI.Size = new System.Drawing.Size(35, 13);
            this.lblestadoUI.TabIndex = 0;
            this.lblestadoUI.Text = "label1";
            this.lblestadoUI.Visible = false;
            this.lblestadoUI.TextChanged += new System.EventHandler(this.LblestadoUI_TextChanged);
            // 
            // PosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1187, 686);
            this.Controls.Add(this.panelPOS);
            this.MaximizeBox = false;
            this.Name = "PosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PosForm";
            this.panelPOS.ResumeLayout(false);
            this.panelBasePOS.ResumeLayout(false);
            this.panelBasePOS.PerformLayout();
            this.panelBotonesPOS.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPOS;
        private System.Windows.Forms.Panel panelBasePOS;
        private System.Windows.Forms.Panel panelBotonesPOS;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnMostrador;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblestadoUI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelUIseleccionada;
    }
}