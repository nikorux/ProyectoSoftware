namespace PMS_POS.View
{
    partial class Reservaciones
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
            this.dgvReservaciones = new System.Windows.Forms.DataGridView();
            this.btnEliminarReservacion = new System.Windows.Forms.Button();
            this.btnEditarReservacion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFiltroo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReservaciones
            // 
            this.dgvReservaciones.AllowUserToAddRows = false;
            this.dgvReservaciones.AllowUserToDeleteRows = false;
            this.dgvReservaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservaciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservaciones.Location = new System.Drawing.Point(12, 14);
            this.dgvReservaciones.Name = "dgvReservaciones";
            this.dgvReservaciones.ReadOnly = true;
            this.dgvReservaciones.Size = new System.Drawing.Size(1013, 405);
            this.dgvReservaciones.TabIndex = 0;
            // 
            // btnEliminarReservacion
            // 
            this.btnEliminarReservacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarReservacion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminarReservacion.CausesValidation = false;
            this.btnEliminarReservacion.FlatAppearance.BorderSize = 0;
            this.btnEliminarReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarReservacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarReservacion.ForeColor = System.Drawing.Color.White;
            this.btnEliminarReservacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarReservacion.Location = new System.Drawing.Point(953, 87);
            this.btnEliminarReservacion.Name = "btnEliminarReservacion";
            this.btnEliminarReservacion.Size = new System.Drawing.Size(144, 27);
            this.btnEliminarReservacion.TabIndex = 77;
            this.btnEliminarReservacion.Text = "Eliminar";
            this.btnEliminarReservacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarReservacion.UseCompatibleTextRendering = true;
            this.btnEliminarReservacion.UseVisualStyleBackColor = false;
            this.btnEliminarReservacion.Click += new System.EventHandler(this.BtnEliminarReservacion_Click);
            // 
            // btnEditarReservacion
            // 
            this.btnEditarReservacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarReservacion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditarReservacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditarReservacion.CausesValidation = false;
            this.btnEditarReservacion.FlatAppearance.BorderSize = 0;
            this.btnEditarReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarReservacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarReservacion.ForeColor = System.Drawing.Color.White;
            this.btnEditarReservacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarReservacion.Location = new System.Drawing.Point(802, 87);
            this.btnEditarReservacion.Name = "btnEditarReservacion";
            this.btnEditarReservacion.Size = new System.Drawing.Size(141, 27);
            this.btnEditarReservacion.TabIndex = 76;
            this.btnEditarReservacion.Text = "Editar";
            this.btnEditarReservacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarReservacion.UseCompatibleTextRendering = true;
            this.btnEditarReservacion.UseVisualStyleBackColor = false;
            this.btnEditarReservacion.Click += new System.EventHandler(this.BtnEditarReservacion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.dgvReservaciones);
            this.panel2.Location = new System.Drawing.Point(54, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 438);
            this.panel2.TabIndex = 83;
            // 
            // txtFiltroo
            // 
            this.txtFiltroo.Location = new System.Drawing.Point(162, 87);
            this.txtFiltroo.Name = "txtFiltroo";
            this.txtFiltroo.Size = new System.Drawing.Size(177, 20);
            this.txtFiltroo.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(56, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 84;
            this.label1.Text = "Filtrar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(55, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 30);
            this.label3.TabIndex = 86;
            this.label3.Text = "Listado de Reservaciones";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirmar.CausesValidation = false;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(523, 87);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(266, 27);
            this.btnConfirmar.TabIndex = 87;
            this.btnConfirmar.Text = "Registrar Check-In";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseCompatibleTextRendering = true;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // Reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFiltroo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEliminarReservacion);
            this.Controls.Add(this.btnEditarReservacion);
            this.Name = "Reservaciones";
            this.Size = new System.Drawing.Size(1285, 680);
            this.Load += new System.EventHandler(this.Reservaciones_Load);
            this.Enter += new System.EventHandler(this.Reservaciones_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservaciones;
        private System.Windows.Forms.Button btnEliminarReservacion;
        private System.Windows.Forms.Button btnEditarReservacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFiltroo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmar;
    }
}
