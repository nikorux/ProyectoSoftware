namespace PMS_POS.View
{
    partial class LiquidarServiciosAdquiridos
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
            this.btnRegistrarCheckIn = new System.Windows.Forms.Button();
            this.dgvServiciosAdquiridos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiciosAdquiridos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarCheckIn
            // 
            this.btnRegistrarCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarCheckIn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegistrarCheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegistrarCheckIn.CausesValidation = false;
            this.btnRegistrarCheckIn.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCheckIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCheckIn.Location = new System.Drawing.Point(-1, 418);
            this.btnRegistrarCheckIn.Name = "btnRegistrarCheckIn";
            this.btnRegistrarCheckIn.Size = new System.Drawing.Size(801, 32);
            this.btnRegistrarCheckIn.TabIndex = 99;
            this.btnRegistrarCheckIn.Text = "Liquidar servicios adquiridos";
            this.btnRegistrarCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarCheckIn.UseCompatibleTextRendering = true;
            this.btnRegistrarCheckIn.UseVisualStyleBackColor = false;
            // 
            // dgvServiciosAdquiridos
            // 
            this.dgvServiciosAdquiridos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvServiciosAdquiridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiciosAdquiridos.Location = new System.Drawing.Point(12, 28);
            this.dgvServiciosAdquiridos.Name = "dgvServiciosAdquiridos";
            this.dgvServiciosAdquiridos.Size = new System.Drawing.Size(776, 150);
            this.dgvServiciosAdquiridos.TabIndex = 100;
            // 
            // LiquidarServiciosAdquiridos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvServiciosAdquiridos);
            this.Controls.Add(this.btnRegistrarCheckIn);
            this.Name = "LiquidarServiciosAdquiridos";
            this.Text = "Detalle Recargo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LiquidarServiciosAdquiridos_FormClosed);
            this.Load += new System.EventHandler(this.LiquidarServiciosAdquiridos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiciosAdquiridos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarCheckIn;
        private System.Windows.Forms.DataGridView dgvServiciosAdquiridos;
    }
}