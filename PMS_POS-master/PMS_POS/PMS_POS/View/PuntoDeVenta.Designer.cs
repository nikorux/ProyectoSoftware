namespace PMS_POS.View
{
    partial class PuntoDeVenta
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
            this.panelBasePOS = new System.Windows.Forms.Panel();
            this.panelBotonesPOS = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.panelBotonesPOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBasePOS
            // 
            this.panelBasePOS.Location = new System.Drawing.Point(0, 62);
            this.panelBasePOS.Name = "panelBasePOS";
            this.panelBasePOS.Size = new System.Drawing.Size(985, 424);
            this.panelBasePOS.TabIndex = 0;
            // 
            // panelBotonesPOS
            // 
            this.panelBotonesPOS.Controls.Add(this.btnConfiguracion);
            this.panelBotonesPOS.Controls.Add(this.btnRegresar);
            this.panelBotonesPOS.Location = new System.Drawing.Point(0, 0);
            this.panelBotonesPOS.Name = "panelBotonesPOS";
            this.panelBotonesPOS.Size = new System.Drawing.Size(985, 65);
            this.panelBotonesPOS.TabIndex = 1;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Location = new System.Drawing.Point(0, 0);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(494, 62);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "RegresarDefault";
            this.btnRegresar.UseVisualStyleBackColor = false;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfiguracion.Location = new System.Drawing.Point(491, 0);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(494, 62);
            this.btnConfiguracion.TabIndex = 1;
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            // 
            // PuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBasePOS);
            this.Controls.Add(this.panelBotonesPOS);
            this.Name = "PuntoDeVenta";
            this.Size = new System.Drawing.Size(985, 486);
            this.panelBotonesPOS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBasePOS;
        private System.Windows.Forms.Panel panelBotonesPOS;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnRegresar;
    }
}
