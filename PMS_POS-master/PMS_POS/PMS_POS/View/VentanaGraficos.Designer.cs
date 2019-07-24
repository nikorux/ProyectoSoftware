namespace PMS_POS.View
{
    partial class VentanaGraficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.HabitacionesPreferidas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.HabitacionesPreferidas)).BeginInit();
            this.SuspendLayout();
            // 
            // HabitacionesPreferidas
            // 
            chartArea1.Name = "ChartArea1";
            this.HabitacionesPreferidas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.HabitacionesPreferidas.Legends.Add(legend1);
            this.HabitacionesPreferidas.Location = new System.Drawing.Point(12, 123);
            this.HabitacionesPreferidas.Name = "HabitacionesPreferidas";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.HabitacionesPreferidas.Series.Add(series1);
            this.HabitacionesPreferidas.Size = new System.Drawing.Size(114, 99);
            this.HabitacionesPreferidas.TabIndex = 0;
            this.HabitacionesPreferidas.Text = "chart1";
            // 
            // VentanaGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1271, 638);
            this.Controls.Add(this.HabitacionesPreferidas);
            this.Name = "VentanaGraficos";
            this.Text = "VentanaGraficos";
            this.Load += new System.EventHandler(this.VentanaGraficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HabitacionesPreferidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart HabitacionesPreferidas;
    }
}