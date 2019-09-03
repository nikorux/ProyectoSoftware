namespace PMS_POS.View
{
    partial class CheckedIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckedIn));
            this.btnRegistrarCheckOut = new System.Windows.Forms.Button();
            this.txtFiltroo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCheckedIn = new System.Windows.Forms.DataGridView();
            this.btnEliminarReservacion = new System.Windows.Forms.Button();
            this.btnEditarReservacion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckedIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarCheckOut
            // 
            this.btnRegistrarCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarCheckOut.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegistrarCheckOut.CausesValidation = false;
            this.btnRegistrarCheckOut.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCheckOut.Location = new System.Drawing.Point(498, 90);
            this.btnRegistrarCheckOut.Name = "btnRegistrarCheckOut";
            this.btnRegistrarCheckOut.Size = new System.Drawing.Size(223, 27);
            this.btnRegistrarCheckOut.TabIndex = 101;
            this.btnRegistrarCheckOut.Text = "Registrar Check-Out";
            this.btnRegistrarCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarCheckOut.UseCompatibleTextRendering = true;
            this.btnRegistrarCheckOut.UseVisualStyleBackColor = false;
            this.btnRegistrarCheckOut.Click += new System.EventHandler(this.BtnRegistrarCheckOut_Click);
            // 
            // txtFiltroo
            // 
            this.txtFiltroo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFiltroo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiltroo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroo.Location = new System.Drawing.Point(148, 93);
            this.txtFiltroo.Name = "txtFiltroo";
            this.txtFiltroo.Size = new System.Drawing.Size(220, 18);
            this.txtFiltroo.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(120, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 30);
            this.label3.TabIndex = 97;
            this.label3.Text = "Listado de Hospedados";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.dgvCheckedIn);
            this.panel2.Location = new System.Drawing.Point(120, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 438);
            this.panel2.TabIndex = 95;
            // 
            // dgvCheckedIn
            // 
            this.dgvCheckedIn.AllowUserToAddRows = false;
            this.dgvCheckedIn.AllowUserToDeleteRows = false;
            this.dgvCheckedIn.AllowUserToResizeColumns = false;
            this.dgvCheckedIn.AllowUserToResizeRows = false;
            this.dgvCheckedIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckedIn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCheckedIn.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCheckedIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckedIn.Location = new System.Drawing.Point(12, 14);
            this.dgvCheckedIn.MultiSelect = false;
            this.dgvCheckedIn.Name = "dgvCheckedIn";
            this.dgvCheckedIn.ReadOnly = true;
            this.dgvCheckedIn.RowHeadersVisible = false;
            this.dgvCheckedIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckedIn.Size = new System.Drawing.Size(1013, 405);
            this.dgvCheckedIn.TabIndex = 0;
            this.dgvCheckedIn.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCheckedIn_ColumnHeaderMouseClick);
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
            this.btnEliminarReservacion.Location = new System.Drawing.Point(970, 90);
            this.btnEliminarReservacion.Name = "btnEliminarReservacion";
            this.btnEliminarReservacion.Size = new System.Drawing.Size(144, 27);
            this.btnEliminarReservacion.TabIndex = 94;
            this.btnEliminarReservacion.Text = "Eliminar";
            this.btnEliminarReservacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarReservacion.UseCompatibleTextRendering = true;
            this.btnEliminarReservacion.UseVisualStyleBackColor = false;
            this.btnEliminarReservacion.Visible = false;
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
            this.btnEditarReservacion.Location = new System.Drawing.Point(775, 90);
            this.btnEditarReservacion.Name = "btnEditarReservacion";
            this.btnEditarReservacion.Size = new System.Drawing.Size(141, 27);
            this.btnEditarReservacion.TabIndex = 93;
            this.btnEditarReservacion.Text = "Editar";
            this.btnEditarReservacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarReservacion.UseCompatibleTextRendering = true;
            this.btnEditarReservacion.UseVisualStyleBackColor = false;
            this.btnEditarReservacion.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(120, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // CheckedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnRegistrarCheckOut);
            this.Controls.Add(this.txtFiltroo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEliminarReservacion);
            this.Controls.Add(this.btnEditarReservacion);
            this.Name = "CheckedIn";
            this.Size = new System.Drawing.Size(1285, 680);
            this.Load += new System.EventHandler(this.CheckedIn_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckedIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarCheckOut;
        private System.Windows.Forms.TextBox txtFiltroo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCheckedIn;
        private System.Windows.Forms.Button btnEliminarReservacion;
        private System.Windows.Forms.Button btnEditarReservacion;
    }
}
