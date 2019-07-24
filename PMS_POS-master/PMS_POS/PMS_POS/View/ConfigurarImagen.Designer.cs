namespace PMS_POS.View
{
    partial class ConfigurarImagen
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
            this.btnBuscarImagen = new System.Windows.Forms.Button();
            this.btnGuardarImagen = new System.Windows.Forms.Button();
            this.picturebImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.Location = new System.Drawing.Point(301, 182);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(124, 31);
            this.btnBuscarImagen.TabIndex = 1;
            this.btnBuscarImagen.Text = "Buscar Imagen";
            this.btnBuscarImagen.UseVisualStyleBackColor = true;
            this.btnBuscarImagen.Click += new System.EventHandler(this.BtnBuscarImagen_Click);
            // 
            // btnGuardarImagen
            // 
            this.btnGuardarImagen.Location = new System.Drawing.Point(301, 271);
            this.btnGuardarImagen.Name = "btnGuardarImagen";
            this.btnGuardarImagen.Size = new System.Drawing.Size(124, 31);
            this.btnGuardarImagen.TabIndex = 2;
            this.btnGuardarImagen.Text = "Guardar Imagen";
            this.btnGuardarImagen.UseVisualStyleBackColor = true;
            this.btnGuardarImagen.Click += new System.EventHandler(this.BtnGuardarImagen_Click);
            // 
            // picturebImagen
            // 
            this.picturebImagen.Location = new System.Drawing.Point(241, 70);
            this.picturebImagen.Name = "picturebImagen";
            this.picturebImagen.Size = new System.Drawing.Size(233, 96);
            this.picturebImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebImagen.TabIndex = 0;
            this.picturebImagen.TabStop = false;
            // 
            // ConfigurarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1269, 579);
            this.Controls.Add(this.btnGuardarImagen);
            this.Controls.Add(this.btnBuscarImagen);
            this.Controls.Add(this.picturebImagen);
            this.Name = "ConfigurarImagen";
            this.Text = "ConfigurarImagen";
            ((System.ComponentModel.ISupportInitialize)(this.picturebImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebImagen;
        private System.Windows.Forms.Button btnBuscarImagen;
        private System.Windows.Forms.Button btnGuardarImagen;
    }
}