namespace Dashboard
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
            this.chartMedicosxEspecialidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMedicosxEspecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMedicosxEspecialidad
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMedicosxEspecialidad.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMedicosxEspecialidad.Legends.Add(legend1);
            this.chartMedicosxEspecialidad.Location = new System.Drawing.Point(132, 108);
            this.chartMedicosxEspecialidad.Name = "chartMedicosxEspecialidad";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMedicosxEspecialidad.Series.Add(series1);
            this.chartMedicosxEspecialidad.Size = new System.Drawing.Size(734, 346);
            this.chartMedicosxEspecialidad.TabIndex = 0;
            this.chartMedicosxEspecialidad.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de medicos segun especialidades";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartMedicosxEspecialidad);
            this.Name = "Form1";
            this.Text = "frmGRAFICO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMedicosxEspecialidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMedicosxEspecialidad;
        private System.Windows.Forms.Label label1;
    }
}

