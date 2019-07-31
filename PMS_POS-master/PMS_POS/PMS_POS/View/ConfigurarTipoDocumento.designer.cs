namespace PMS_POS.View
{
    partial class ConfigurarTipoDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurarTipoDocumento));
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvTipoDocumento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.txtNombreTipoDocumento = new System.Windows.Forms.TextBox();
            this.txtIdTipoDocumento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo Documento:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregar.Location = new System.Drawing.Point(75, 400);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(168, 35);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBorrar.Location = new System.Drawing.Point(447, 400);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(168, 35);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditar.Location = new System.Drawing.Point(260, 400);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(168, 35);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // dgvTipoDocumento
            // 
            this.dgvTipoDocumento.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTipoDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoDocumento.Location = new System.Drawing.Point(398, 145);
            this.dgvTipoDocumento.Name = "dgvTipoDocumento";
            this.dgvTipoDocumento.Size = new System.Drawing.Size(174, 193);
            this.dgvTipoDocumento.TabIndex = 8;
            this.dgvTipoDocumento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTipoDocumento_CellClick);
            this.dgvTipoDocumento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTipoDocumento_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(123, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Configuración Tipo de Documento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PMS_POS.Properties.Resources.settings__1_;
            this.pictureBox1.Location = new System.Drawing.Point(75, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(74, 196);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(231, 10);
            this.pictureBox8.TabIndex = 208;
            this.pictureBox8.TabStop = false;
            // 
            // txtNombreTipoDocumento
            // 
            this.txtNombreTipoDocumento.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNombreTipoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreTipoDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombreTipoDocumento.Location = new System.Drawing.Point(74, 179);
            this.txtNombreTipoDocumento.Name = "txtNombreTipoDocumento";
            this.txtNombreTipoDocumento.Size = new System.Drawing.Size(231, 22);
            this.txtNombreTipoDocumento.TabIndex = 12;
            this.txtNombreTipoDocumento.TextChanged += new System.EventHandler(this.TxtNombreTipoDocumento_TextChanged);
            // 
            // txtIdTipoDocumento
            // 
            this.txtIdTipoDocumento.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtIdTipoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdTipoDocumento.Enabled = false;
            this.txtIdTipoDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIdTipoDocumento.Location = new System.Drawing.Point(108, 114);
            this.txtIdTipoDocumento.Name = "txtIdTipoDocumento";
            this.txtIdTipoDocumento.Size = new System.Drawing.Size(231, 13);
            this.txtIdTipoDocumento.TabIndex = 209;
            this.txtIdTipoDocumento.Visible = false;
            // 
            // ConfigurarTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.txtIdTipoDocumento);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreTipoDocumento);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvTipoDocumento);
            this.Name = "ConfigurarTipoDocumento";
            this.Size = new System.Drawing.Size(1304, 633);
            this.Load += new System.EventHandler(this.ConfigurarTipoDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvTipoDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtNombreTipoDocumento;
        private System.Windows.Forms.TextBox txtIdTipoDocumento;
    }
}
