namespace PMS_POS.View
{
    partial class RecetaProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listProductos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNombreReceta = new System.Windows.Forms.TextBox();
            this.txtDescripcionReceta = new System.Windows.Forms.TextBox();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.txtComentarioReceta = new System.Windows.Forms.TextBox();
            this.nudCantidadEnReceta = new System.Windows.Forms.NumericUpDown();
            this.cbxUnidadMedidaEnReceta = new System.Windows.Forms.ComboBox();
            this.dgvProductosEnReceta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadEnReceta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Receta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unidad de medida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Comentario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre:";
            // 
            // listProductos
            // 
            this.listProductos.FormattingEnabled = true;
            this.listProductos.Location = new System.Drawing.Point(318, 143);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(190, 173);
            this.listProductos.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtNombreReceta
            // 
            this.txtNombreReceta.Location = new System.Drawing.Point(138, 133);
            this.txtNombreReceta.Name = "txtNombreReceta";
            this.txtNombreReceta.Size = new System.Drawing.Size(155, 20);
            this.txtNombreReceta.TabIndex = 10;
            // 
            // txtDescripcionReceta
            // 
            this.txtDescripcionReceta.Location = new System.Drawing.Point(138, 177);
            this.txtDescripcionReceta.Multiline = true;
            this.txtDescripcionReceta.Name = "txtDescripcionReceta";
            this.txtDescripcionReceta.Size = new System.Drawing.Size(155, 42);
            this.txtDescripcionReceta.TabIndex = 11;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(318, 103);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(190, 20);
            this.txtBuscarProducto.TabIndex = 12;
            this.txtBuscarProducto.Text = "Buscar Productos";
            // 
            // txtComentarioReceta
            // 
            this.txtComentarioReceta.Location = new System.Drawing.Point(138, 225);
            this.txtComentarioReceta.Multiline = true;
            this.txtComentarioReceta.Name = "txtComentarioReceta";
            this.txtComentarioReceta.Size = new System.Drawing.Size(155, 42);
            this.txtComentarioReceta.TabIndex = 13;
            // 
            // nudCantidadEnReceta
            // 
            this.nudCantidadEnReceta.Location = new System.Drawing.Point(88, 296);
            this.nudCantidadEnReceta.Name = "nudCantidadEnReceta";
            this.nudCantidadEnReceta.Size = new System.Drawing.Size(47, 20);
            this.nudCantidadEnReceta.TabIndex = 14;
            // 
            // cbxUnidadMedidaEnReceta
            // 
            this.cbxUnidadMedidaEnReceta.FormattingEnabled = true;
            this.cbxUnidadMedidaEnReceta.Location = new System.Drawing.Point(156, 296);
            this.cbxUnidadMedidaEnReceta.Name = "cbxUnidadMedidaEnReceta";
            this.cbxUnidadMedidaEnReceta.Size = new System.Drawing.Size(121, 21);
            this.cbxUnidadMedidaEnReceta.TabIndex = 15;
            // 
            // dgvProductosEnReceta
            // 
            this.dgvProductosEnReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosEnReceta.Location = new System.Drawing.Point(562, 143);
            this.dgvProductosEnReceta.Name = "dgvProductosEnReceta";
            this.dgvProductosEnReceta.Size = new System.Drawing.Size(257, 173);
            this.dgvProductosEnReceta.TabIndex = 16;
            // 
            // RecetaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProductosEnReceta);
            this.Controls.Add(this.cbxUnidadMedidaEnReceta);
            this.Controls.Add(this.nudCantidadEnReceta);
            this.Controls.Add(this.txtComentarioReceta);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.txtDescripcionReceta);
            this.Controls.Add(this.txtNombreReceta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listProductos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RecetaProducto";
            this.Size = new System.Drawing.Size(836, 451);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadEnReceta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEnReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listProductos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNombreReceta;
        private System.Windows.Forms.TextBox txtDescripcionReceta;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.TextBox txtComentarioReceta;
        private System.Windows.Forms.NumericUpDown nudCantidadEnReceta;
        private System.Windows.Forms.ComboBox cbxUnidadMedidaEnReceta;
        private System.Windows.Forms.DataGridView dgvProductosEnReceta;
    }
}
