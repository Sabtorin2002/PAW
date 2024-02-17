namespace Biciclete
{
    partial class Form2
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
            this.grafic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAfisareGrafic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).BeginInit();
            this.SuspendLayout();
            // 
            // grafic
            // 
            chartArea1.Name = "ChartArea1";
            this.grafic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafic.Legends.Add(legend1);
            this.grafic.Location = new System.Drawing.Point(60, 12);
            this.grafic.Name = "grafic";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "KM";
            this.grafic.Series.Add(series1);
            this.grafic.Size = new System.Drawing.Size(680, 289);
            this.grafic.TabIndex = 0;
            this.grafic.Text = "chart1";
            // 
            // btnAfisareGrafic
            // 
            this.btnAfisareGrafic.Location = new System.Drawing.Point(269, 350);
            this.btnAfisareGrafic.Name = "btnAfisareGrafic";
            this.btnAfisareGrafic.Size = new System.Drawing.Size(196, 55);
            this.btnAfisareGrafic.TabIndex = 1;
            this.btnAfisareGrafic.Text = "Afisare grafic";
            this.btnAfisareGrafic.UseVisualStyleBackColor = true;
            this.btnAfisareGrafic.Click += new System.EventHandler(this.btnAfisareGrafic_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfisareGrafic);
            this.Controls.Add(this.grafic);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafic;
        private System.Windows.Forms.Button btnAfisareGrafic;
    }
}