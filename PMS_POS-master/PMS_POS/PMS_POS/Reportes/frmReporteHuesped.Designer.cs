namespace PMS_POS.Reportes
{
    partial class frmReporteHuesped
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportesDataSetEmpleado = new PMS_POS.Reportes.ReportesDataSetEmpleado();
            this.huespedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportesDataSet = new PMS_POS.Reportes.ReportesDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.rptHuesped = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataSetEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huespedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "empleado";
            this.empleadoBindingSource.DataSource = this.ReportesDataSetEmpleado;
            // 
            // ReportesDataSetEmpleado
            // 
            this.ReportesDataSetEmpleado.DataSetName = "ReportesDataSetEmpleado";
            this.ReportesDataSetEmpleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // huespedBindingSource
            // 
            this.huespedBindingSource.DataMember = "huesped";
            this.huespedBindingSource.DataSource = this.ReportesDataSet;
            // 
            // ReportesDataSet
            // 
            this.ReportesDataSet.DataSetName = "ReportesDataSet";
            this.ReportesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnEmpleados);
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(1112, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 602);
            this.panel1.TabIndex = 0;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmpleados.Location = new System.Drawing.Point(13, 195);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(160, 82);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Listado de Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReporte.Location = new System.Drawing.Point(13, 94);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(160, 85);
            this.btnReporte.TabIndex = 0;
            this.btnReporte.Text = "Listado de Clientes";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // rptHuesped
            // 
            this.rptHuesped.DocumentMapWidth = 1;
            reportDataSource1.Name = "empleado";
            reportDataSource1.Value = this.empleadoBindingSource;
            this.rptHuesped.LocalReport.DataSources.Add(reportDataSource1);
            this.rptHuesped.LocalReport.ReportEmbeddedResource = "PMS_POS.Reportes.reporteEmpleados.rdlc";
            this.rptHuesped.Location = new System.Drawing.Point(0, 0);
            this.rptHuesped.Name = "rptHuesped";
            this.rptHuesped.ServerReport.BearerToken = null;
            this.rptHuesped.Size = new System.Drawing.Size(1119, 570);
            this.rptHuesped.TabIndex = 1;
            // 
            // frmReporteHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 594);
            this.Controls.Add(this.rptHuesped);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteHuesped";
            this.Text = "frmReporteHuesped";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmReporteHuesped_FormClosed);
            this.Load += new System.EventHandler(this.FrmReporteHuesped_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataSetEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huespedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReporte;
        private Microsoft.Reporting.WinForms.ReportViewer rptHuesped;
        private System.Windows.Forms.BindingSource huespedBindingSource;
        private ReportesDataSet ReportesDataSet;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private ReportesDataSetEmpleado ReportesDataSetEmpleado;
    }
}