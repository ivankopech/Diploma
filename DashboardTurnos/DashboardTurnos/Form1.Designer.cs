namespace DashboardTurnos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTurnosPorMedicos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chartTurnosPorPaciente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTurnosPorMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTurnosPorPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTurnosPorMedicos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTurnosPorMedicos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTurnosPorMedicos.Legends.Add(legend1);
            this.chartTurnosPorMedicos.Location = new System.Drawing.Point(21, 89);
            this.chartTurnosPorMedicos.Name = "chartTurnosPorMedicos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Grafico Medicos";
            this.chartTurnosPorMedicos.Series.Add(series1);
            this.chartTurnosPorMedicos.Size = new System.Drawing.Size(494, 392);
            this.chartTurnosPorMedicos.TabIndex = 0;
            this.chartTurnosPorMedicos.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de turnos por medico";
            // 
            // chartTurnosPorPaciente
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTurnosPorPaciente.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTurnosPorPaciente.Legends.Add(legend2);
            this.chartTurnosPorPaciente.Location = new System.Drawing.Point(539, 89);
            this.chartTurnosPorPaciente.Name = "chartTurnosPorPaciente";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Grafico Pacientes";
            this.chartTurnosPorPaciente.Series.Add(series2);
            this.chartTurnosPorPaciente.Size = new System.Drawing.Size(498, 392);
            this.chartTurnosPorPaciente.TabIndex = 3;
            this.chartTurnosPorPaciente.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(640, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de turnos por paciente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartTurnosPorPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartTurnosPorMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTurnosPorMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTurnosPorPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTurnosPorMedicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTurnosPorPaciente;
        private System.Windows.Forms.Label label2;
    }
}

