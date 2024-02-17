namespace etc
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvPersoane = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.afiseazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvPersoane = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Varsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.grafic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGrafic = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoane)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersoane
            // 
            this.dgvPersoane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersoane.Location = new System.Drawing.Point(417, 25);
            this.dgvPersoane.Name = "dgvPersoane";
            this.dgvPersoane.RowHeadersWidth = 51;
            this.dgvPersoane.RowTemplate.Height = 24;
            this.dgvPersoane.Size = new System.Drawing.Size(355, 214);
            this.dgvPersoane.TabIndex = 0;
            this.dgvPersoane.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvPersoane.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afiseazaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // afiseazaToolStripMenuItem
            // 
            this.afiseazaToolStripMenuItem.Name = "afiseazaToolStripMenuItem";
            this.afiseazaToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.afiseazaToolStripMenuItem.Text = "Afiseaza";
            this.afiseazaToolStripMenuItem.Click += new System.EventHandler(this.afiseazaToolStripMenuItem_Click);
            // 
            // lvPersoane
            // 
            this.lvPersoane.CheckBoxes = true;
            this.lvPersoane.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nume,
            this.Varsta});
            this.lvPersoane.GridLines = true;
            this.lvPersoane.HideSelection = false;
            this.lvPersoane.Location = new System.Drawing.Point(417, 255);
            this.lvPersoane.Name = "lvPersoane";
            this.lvPersoane.Size = new System.Drawing.Size(296, 205);
            this.lvPersoane.TabIndex = 2;
            this.lvPersoane.UseCompatibleStateImageBehavior = false;
            this.lvPersoane.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            // 
            // Varsta
            // 
            this.Varsta.Text = "Varsta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "Adaugare listView";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grafic
            // 
            chartArea2.Name = "ChartArea1";
            this.grafic.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafic.Legends.Add(legend2);
            this.grafic.Location = new System.Drawing.Point(36, 31);
            this.grafic.Name = "grafic";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "varsta";
            this.grafic.Series.Add(series2);
            this.grafic.Size = new System.Drawing.Size(319, 219);
            this.grafic.TabIndex = 4;
            this.grafic.Text = "chart1";
            // 
            // btnGrafic
            // 
            this.btnGrafic.Location = new System.Drawing.Point(92, 271);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(142, 47);
            this.btnGrafic.TabIndex = 5;
            this.btnGrafic.Text = "Incarca date";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 472);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.grafic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvPersoane);
            this.Controls.Add(this.dgvPersoane);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersoane)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersoane;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afiseazaToolStripMenuItem;
        private System.Windows.Forms.ListView lvPersoane;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Varsta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafic;
        private System.Windows.Forms.Button btnGrafic;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

