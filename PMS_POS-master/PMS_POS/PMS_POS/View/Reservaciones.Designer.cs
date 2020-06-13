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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservaciones));
            this.dgvReservaciones = new System.Windows.Forms.DataGridView();
            this.btnEliminarReservacion = new System.Windows.Forms.Button();
            this.btnEditarReservacion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFiltroo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnNoShow = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservaciones
            // 
            this.dgvReservaciones.AllowUserToAddRows = false;
            this.dgvReservaciones.AllowUserToDeleteRows = false;
            this.dgvReservaciones.AllowUserToResizeColumns = false;
            this.dgvReservaciones.AllowUserToResizeRows = false;
            this.dgvReservaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReservaciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservaciones.Location = new System.Drawing.Point(12, 14);
            this.dgvReservaciones.MultiSelect = false;
            this.dgvReservaciones.Name = "dgvReservaciones";
            this.dgvReservaciones.ReadOnly = true;
            this.dgvReservaciones.RowHeadersVisible = false;
            this.dgvReservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservaciones.Size = new System.Drawing.Size(1013, 405);
            this.dgvReservaciones.TabIndex = 0;
            this.dgvReservaciones.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReservaciones_CellContentDoubleClick);
            this.dgvReservaciones.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvReservaciones_ColumnHeaderMouseClick);
            this.dgvReservaciones.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReservaciones_RowEnter);
            this.dgvReservaciones.Enter += new System.EventHandler(this.DgvReservaciones_Enter);
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
            this.btnEliminarReservacion.Location = new System.Drawing.Point(838, 90);
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
            this.btnEditarReservacion.Location = new System.Drawing.Point(656, 91);
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
            this.panel2.Location = new System.Drawing.Point(120, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 438);
            this.panel2.TabIndex = 83;
            // 
            // txtFiltroo
            // 
            this.txtFiltroo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFiltroo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiltroo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroo.Location = new System.Drawing.Point(148, 96);
            this.txtFiltroo.Name = "txtFiltroo";
            this.txtFiltroo.Size = new System.Drawing.Size(220, 18);
            this.txtFiltroo.TabIndex = 85;
            this.txtFiltroo.TextChanged += new System.EventHandler(this.txtFiltroo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(120, 45);
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
            this.btnConfirmar.Location = new System.Drawing.Point(391, 91);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(224, 27);
            this.btnConfirmar.TabIndex = 87;
            this.btnConfirmar.Text = "Registrar Check-In";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseCompatibleTextRendering = true;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // btnNoShow
            // 
            this.btnNoShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoShow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNoShow.CausesValidation = false;
            this.btnNoShow.FlatAppearance.BorderSize = 0;
            this.btnNoShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoShow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoShow.ForeColor = System.Drawing.Color.White;
            this.btnNoShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoShow.Location = new System.Drawing.Point(1023, 90);
            this.btnNoShow.Name = "btnNoShow";
            this.btnNoShow.Size = new System.Drawing.Size(144, 27);
            this.btnNoShow.TabIndex = 92;
            this.btnNoShow.Text = "No Show";
            this.btnNoShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNoShow.UseCompatibleTextRendering = true;
            this.btnNoShow.UseVisualStyleBackColor = false;
            this.btnNoShow.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(120, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // Reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnNoShow);
            this.Controls.Add(this.txtFiltroo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEliminarReservacion);
            this.Controls.Add(this.btnEditarReservacion);
            this.Name = "Reservaciones";
            this.Size = new System.Drawing.Size(1285, 680);
            this.Load += new System.EventHandler(this.Reservaciones_Load);
            this.Enter += new System.EventHandler(this.Reservaciones_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservaciones)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservaciones;
        private System.Windows.Forms.Button btnEliminarReservacion;
        private System.Windows.Forms.Button btnEditarReservacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFiltroo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNoShow;
    }
}
