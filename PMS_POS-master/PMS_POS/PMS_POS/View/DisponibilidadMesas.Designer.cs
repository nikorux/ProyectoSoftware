namespace PMS_POS.View
{
    partial class DisponibilidadMesas
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
            this.dgvMesasDisponibles = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMesasNODisponibles = new System.Windows.Forms.DataGridView();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.lblMno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNODisponiblesTodos = new System.Windows.Forms.Button();
            this.btnDisponiblesTodos = new System.Windows.Forms.Button();
            this.txtMesasDisponibles = new System.Windows.Forms.TextBox();
            this.txtMesasNODisponibles = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasDisponibles)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasNODisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.dgvMesasDisponibles);
            this.panel4.Location = new System.Drawing.Point(12, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 300);
            this.panel4.TabIndex = 36;
            // 
            // dgvMesasDisponibles
            // 
            this.dgvMesasDisponibles.AllowUserToAddRows = false;
            this.dgvMesasDisponibles.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvMesasDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMesasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesasDisponibles.Location = new System.Drawing.Point(3, 3);
            this.dgvMesasDisponibles.Name = "dgvMesasDisponibles";
            this.dgvMesasDisponibles.Size = new System.Drawing.Size(191, 294);
            this.dgvMesasDisponibles.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.dgvMesasNODisponibles);
            this.panel3.Location = new System.Drawing.Point(296, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 300);
            this.panel3.TabIndex = 35;
            // 
            // dgvMesasNODisponibles
            // 
            this.dgvMesasNODisponibles.AllowUserToAddRows = false;
            this.dgvMesasNODisponibles.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvMesasNODisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMesasNODisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesasNODisponibles.Location = new System.Drawing.Point(3, 3);
            this.dgvMesasNODisponibles.Name = "dgvMesasNODisponibles";
            this.dgvMesasNODisponibles.Size = new System.Drawing.Size(191, 294);
            this.dgvMesasNODisponibles.TabIndex = 21;
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRemoverItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoverItem.Location = new System.Drawing.Point(215, 186);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverItem.TabIndex = 34;
            this.btnRemoverItem.Text = "<<";
            this.btnRemoverItem.UseVisualStyleBackColor = false;
            this.btnRemoverItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnRemoverItem_MouseClick);
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItem.ForeColor = System.Drawing.Color.White;
            this.btnAgregarItem.Location = new System.Drawing.Point(215, 162);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarItem.TabIndex = 33;
            this.btnAgregarItem.Text = ">>";
            this.btnAgregarItem.UseVisualStyleBackColor = false;
            this.btnAgregarItem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAgregarItem_MouseClick);
            // 
            // lblMno
            // 
            this.lblMno.AutoSize = true;
            this.lblMno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(81)))), ((int)(((byte)(193)))));
            this.lblMno.Location = new System.Drawing.Point(306, 12);
            this.lblMno.Name = "lblMno";
            this.lblMno.Size = new System.Drawing.Size(181, 18);
            this.lblMno.TabIndex = 37;
            this.lblMno.Text = "Mesas NO Disponibles";
            this.lblMno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblMno_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(81)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(35, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mesas Disponibles";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseClick);
            // 
            // btnNODisponiblesTodos
            // 
            this.btnNODisponiblesTodos.BackColor = System.Drawing.Color.Blue;
            this.btnNODisponiblesTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNODisponiblesTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNODisponiblesTodos.ForeColor = System.Drawing.Color.White;
            this.btnNODisponiblesTodos.Location = new System.Drawing.Point(215, 126);
            this.btnNODisponiblesTodos.Name = "btnNODisponiblesTodos";
            this.btnNODisponiblesTodos.Size = new System.Drawing.Size(75, 23);
            this.btnNODisponiblesTodos.TabIndex = 39;
            this.btnNODisponiblesTodos.Text = ">>>";
            this.btnNODisponiblesTodos.UseVisualStyleBackColor = false;
            this.btnNODisponiblesTodos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnNODisponiblesTodos_MouseClick);
            // 
            // btnDisponiblesTodos
            // 
            this.btnDisponiblesTodos.BackColor = System.Drawing.Color.Blue;
            this.btnDisponiblesTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponiblesTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisponiblesTodos.ForeColor = System.Drawing.Color.White;
            this.btnDisponiblesTodos.Location = new System.Drawing.Point(215, 225);
            this.btnDisponiblesTodos.Name = "btnDisponiblesTodos";
            this.btnDisponiblesTodos.Size = new System.Drawing.Size(75, 23);
            this.btnDisponiblesTodos.TabIndex = 40;
            this.btnDisponiblesTodos.Text = "<<<";
            this.btnDisponiblesTodos.UseVisualStyleBackColor = false;
            this.btnDisponiblesTodos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnDisponiblesTodos_MouseClick);
            // 
            // txtMesasDisponibles
            // 
            this.txtMesasDisponibles.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMesasDisponibles.Location = new System.Drawing.Point(24, 30);
            this.txtMesasDisponibles.Name = "txtMesasDisponibles";
            this.txtMesasDisponibles.Size = new System.Drawing.Size(172, 20);
            this.txtMesasDisponibles.TabIndex = 41;
            this.txtMesasDisponibles.Text = "Buscar Mesa";
            this.txtMesasDisponibles.TextChanged += new System.EventHandler(this.TxtMesasDisponibles_TextChanged);
            // 
            // txtMesasNODisponibles
            // 
            this.txtMesasNODisponibles.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMesasNODisponibles.Location = new System.Drawing.Point(309, 30);
            this.txtMesasNODisponibles.Name = "txtMesasNODisponibles";
            this.txtMesasNODisponibles.Size = new System.Drawing.Size(172, 20);
            this.txtMesasNODisponibles.TabIndex = 42;
            this.txtMesasNODisponibles.Text = "Buscar Mesa";
            this.txtMesasNODisponibles.TextChanged += new System.EventHandler(this.TxtMesasNODisponibles_TextChanged);
            // 
            // DisponibilidadMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 365);
            this.Controls.Add(this.txtMesasNODisponibles);
            this.Controls.Add(this.txtMesasDisponibles);
            this.Controls.Add(this.btnDisponiblesTodos);
            this.Controls.Add(this.btnNODisponiblesTodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMno);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnRemoverItem);
            this.Controls.Add(this.btnAgregarItem);
            this.Name = "DisponibilidadMesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisponibilidadMesas";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DisponibilidadMesas_MouseClick);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasDisponibles)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesasNODisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvMesasDisponibles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvMesasNODisponibles;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Label lblMno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNODisponiblesTodos;
        private System.Windows.Forms.Button btnDisponiblesTodos;
        private System.Windows.Forms.TextBox txtMesasDisponibles;
        private System.Windows.Forms.TextBox txtMesasNODisponibles;
    }
}