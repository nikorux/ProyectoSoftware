namespace PMS_POS.View
{
    partial class UserControlClientes
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
            this.btnEliminarClientes = new System.Windows.Forms.Button();
            this.btnEditarClientes = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarClientes
            // 
            this.btnEliminarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarClientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminarClientes.CausesValidation = false;
            this.btnEliminarClientes.FlatAppearance.BorderSize = 0;
            this.btnEliminarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarClientes.ForeColor = System.Drawing.Color.White;
            this.btnEliminarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarClientes.Location = new System.Drawing.Point(968, 78);
            this.btnEliminarClientes.Name = "btnEliminarClientes";
            this.btnEliminarClientes.Size = new System.Drawing.Size(120, 27);
            this.btnEliminarClientes.TabIndex = 74;
            this.btnEliminarClientes.Text = "Eliminar";
            this.btnEliminarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarClientes.UseCompatibleTextRendering = true;
            this.btnEliminarClientes.UseVisualStyleBackColor = false;
            // 
            // btnEditarClientes
            // 
            this.btnEditarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarClientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditarClientes.CausesValidation = false;
            this.btnEditarClientes.FlatAppearance.BorderSize = 0;
            this.btnEditarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarClientes.ForeColor = System.Drawing.Color.White;
            this.btnEditarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarClientes.Location = new System.Drawing.Point(842, 78);
            this.btnEditarClientes.Name = "btnEditarClientes";
            this.btnEditarClientes.Size = new System.Drawing.Size(120, 27);
            this.btnEditarClientes.TabIndex = 73;
            this.btnEditarClientes.Text = "Editar";
            this.btnEditarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarClientes.UseCompatibleTextRendering = true;
            this.btnEditarClientes.UseVisualStyleBackColor = false;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoCliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevoCliente.CausesValidation = false;
            this.btnNuevoCliente.FlatAppearance.BorderSize = 0;
            this.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoCliente.Location = new System.Drawing.Point(653, 78);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(183, 27);
            this.btnNuevoCliente.TabIndex = 72;
            this.btnNuevoCliente.Text = "+ Registrar nuevo empleado";
            this.btnNuevoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoCliente.UseCompatibleTextRendering = true;
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(26, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 30);
            this.label3.TabIndex = 70;
            this.label3.Text = "Registro de Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(31, 130);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(1057, 314);
            this.dgvClientes.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(52, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 79;
            this.label1.Text = "Filtrar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFiltroo
            // 
            this.txtFiltroo.Location = new System.Drawing.Point(158, 83);
            this.txtFiltroo.Name = "txtFiltroo";
            this.txtFiltroo.Size = new System.Drawing.Size(177, 20);
            this.txtFiltroo.TabIndex = 80;
            this.txtFiltroo.TextChanged += new System.EventHandler(this.TxtFiltroo_TextChanged);
            // 
            // UserControlClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFiltroo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnEliminarClientes);
            this.Controls.Add(this.btnEditarClientes);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.label3);
            this.Name = "UserControlClientes";
            this.Size = new System.Drawing.Size(1114, 567);
            this.Load += new System.EventHandler(this.UserControlClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarClientes;
        private System.Windows.Forms.Button btnEditarClientes;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltroo;
    }
}
