namespace ToataMateria
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
            this.tbAfisareForm2 = new System.Windows.Forms.TextBox();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.grafic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGrafic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAfisareForm2
            // 
            this.tbAfisareForm2.Location = new System.Drawing.Point(575, 282);
            this.tbAfisareForm2.Multiline = true;
            this.tbAfisareForm2.Name = "tbAfisareForm2";
            this.tbAfisareForm2.Size = new System.Drawing.Size(170, 138);
            this.tbAfisareForm2.TabIndex = 0;
            this.tbAfisareForm2.TextChanged += new System.EventHandler(this.tbAfisareForm2_TextChanged);
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(575, 214);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(170, 62);
            this.btnAfisare.TabIndex = 1;
            this.btnAfisare.Text = "Afiseaza lista studenti";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // grafic
            // 
            chartArea1.Name = "ChartArea1";
            this.grafic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafic.Legends.Add(legend1);
            this.grafic.Location = new System.Drawing.Point(39, 28);
            this.grafic.Name = "grafic";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Pret";
            this.grafic.Series.Add(series1);
            this.grafic.Size = new System.Drawing.Size(355, 233);
            this.grafic.TabIndex = 2;
            this.grafic.Text = "chart1";
            // 
            // btnGrafic
            // 
            this.btnGrafic.Location = new System.Drawing.Point(97, 282);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(157, 65);
            this.btnGrafic.TabIndex = 3;
            this.btnGrafic.Text = "Grafic";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.grafic);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.tbAfisareForm2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAfisareForm2;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafic;
        private System.Windows.Forms.Button btnGrafic;
    }
}