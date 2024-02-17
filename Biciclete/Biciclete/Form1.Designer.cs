namespace Biciclete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCodBicicleta = new System.Windows.Forms.TextBox();
            this.tbStatieParcare = new System.Windows.Forms.TextBox();
            this.tbKM = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbCodUtilizator = new System.Windows.Forms.TextBox();
            this.tbDurata = new System.Windows.Forms.TextBox();
            this.tbAfisareTot = new System.Windows.Forms.TextBox();
            this.btnAdaugaBiciclete = new System.Windows.Forms.Button();
            this.btnAdaugaUtilizator = new System.Windows.Forms.Button();
            this.lvBiciclete = new System.Windows.Forms.ListView();
            this.Cod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Statie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvUtilizatori = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodUtilizator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Durata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPreluarelvB = new System.Windows.Forms.Button();
            this.btnPreluarelvU = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnAfisareBicicleteSiUtilizatoriTB = new System.Windows.Forms.Button();
            this.btnCalculareSuma = new System.Windows.Forms.Button();
            this.tbCalculTarif = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicicleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicicleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizatoriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tvBiciclete = new System.Windows.Forms.TreeView();
            this.btnAdaugaTv = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Statie parcare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "KM ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nume";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cod";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Durata utilizare";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Bicicleta";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Utilizator";
            // 
            // tbCodBicicleta
            // 
            this.tbCodBicicleta.Location = new System.Drawing.Point(125, 43);
            this.tbCodBicicleta.Name = "tbCodBicicleta";
            this.tbCodBicicleta.Size = new System.Drawing.Size(100, 22);
            this.tbCodBicicleta.TabIndex = 8;
            // 
            // tbStatieParcare
            // 
            this.tbStatieParcare.Location = new System.Drawing.Point(133, 75);
            this.tbStatieParcare.Name = "tbStatieParcare";
            this.tbStatieParcare.Size = new System.Drawing.Size(100, 22);
            this.tbStatieParcare.TabIndex = 9;
            // 
            // tbKM
            // 
            this.tbKM.Location = new System.Drawing.Point(85, 121);
            this.tbKM.Name = "tbKM";
            this.tbKM.Size = new System.Drawing.Size(100, 22);
            this.tbKM.TabIndex = 10;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(343, 43);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 22);
            this.tbNume.TabIndex = 11;
            // 
            // tbCodUtilizator
            // 
            this.tbCodUtilizator.Location = new System.Drawing.Point(343, 82);
            this.tbCodUtilizator.Name = "tbCodUtilizator";
            this.tbCodUtilizator.Size = new System.Drawing.Size(100, 22);
            this.tbCodUtilizator.TabIndex = 12;
            // 
            // tbDurata
            // 
            this.tbDurata.Location = new System.Drawing.Point(378, 121);
            this.tbDurata.Name = "tbDurata";
            this.tbDurata.Size = new System.Drawing.Size(100, 22);
            this.tbDurata.TabIndex = 13;
            // 
            // tbAfisareTot
            // 
            this.tbAfisareTot.Location = new System.Drawing.Point(504, 24);
            this.tbAfisareTot.Multiline = true;
            this.tbAfisareTot.Name = "tbAfisareTot";
            this.tbAfisareTot.Size = new System.Drawing.Size(284, 119);
            this.tbAfisareTot.TabIndex = 14;
            // 
            // btnAdaugaBiciclete
            // 
            this.btnAdaugaBiciclete.Location = new System.Drawing.Point(38, 161);
            this.btnAdaugaBiciclete.Name = "btnAdaugaBiciclete";
            this.btnAdaugaBiciclete.Size = new System.Drawing.Size(155, 39);
            this.btnAdaugaBiciclete.TabIndex = 15;
            this.btnAdaugaBiciclete.Text = "Adauga bicicleta";
            this.btnAdaugaBiciclete.UseVisualStyleBackColor = true;
            this.btnAdaugaBiciclete.Click += new System.EventHandler(this.btnAdaugaBiciclete_Click);
            // 
            // btnAdaugaUtilizator
            // 
            this.btnAdaugaUtilizator.Location = new System.Drawing.Point(259, 161);
            this.btnAdaugaUtilizator.Name = "btnAdaugaUtilizator";
            this.btnAdaugaUtilizator.Size = new System.Drawing.Size(155, 40);
            this.btnAdaugaUtilizator.TabIndex = 16;
            this.btnAdaugaUtilizator.Text = "Adauga Utilizator";
            this.btnAdaugaUtilizator.UseVisualStyleBackColor = true;
            this.btnAdaugaUtilizator.Click += new System.EventHandler(this.btnAdaugaUtilizator_Click);
            // 
            // lvBiciclete
            // 
            this.lvBiciclete.CheckBoxes = true;
            this.lvBiciclete.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cod,
            this.Statie,
            this.KM});
            this.lvBiciclete.GridLines = true;
            this.lvBiciclete.HideSelection = false;
            this.lvBiciclete.Location = new System.Drawing.Point(12, 225);
            this.lvBiciclete.Name = "lvBiciclete";
            this.lvBiciclete.Size = new System.Drawing.Size(181, 213);
            this.lvBiciclete.TabIndex = 17;
            this.lvBiciclete.UseCompatibleStateImageBehavior = false;
            this.lvBiciclete.View = System.Windows.Forms.View.Details;
            // 
            // Cod
            // 
            this.Cod.Text = "Cod";
            // 
            // Statie
            // 
            this.Statie.Text = "Statie";
            // 
            // KM
            // 
            this.KM.Text = "KM";
            // 
            // lvUtilizatori
            // 
            this.lvUtilizatori.CheckBoxes = true;
            this.lvUtilizatori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.CodUtilizator,
            this.Durata});
            this.lvUtilizatori.GridLines = true;
            this.lvUtilizatori.HideSelection = false;
            this.lvUtilizatori.Location = new System.Drawing.Point(259, 225);
            this.lvUtilizatori.Name = "lvUtilizatori";
            this.lvUtilizatori.Size = new System.Drawing.Size(184, 213);
            this.lvUtilizatori.TabIndex = 18;
            this.lvUtilizatori.UseCompatibleStateImageBehavior = false;
            this.lvUtilizatori.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            // 
            // CodUtilizator
            // 
            this.CodUtilizator.Text = "CodUtilizator";
            // 
            // Durata
            // 
            this.Durata.Text = "Durata";
            // 
            // btnPreluarelvB
            // 
            this.btnPreluarelvB.Location = new System.Drawing.Point(12, 460);
            this.btnPreluarelvB.Name = "btnPreluarelvB";
            this.btnPreluarelvB.Size = new System.Drawing.Size(181, 36);
            this.btnPreluarelvB.TabIndex = 19;
            this.btnPreluarelvB.Text = "Preluare biciclete";
            this.btnPreluarelvB.UseVisualStyleBackColor = true;
            this.btnPreluarelvB.Click += new System.EventHandler(this.btnPreluarelvB_Click);
            // 
            // btnPreluarelvU
            // 
            this.btnPreluarelvU.Location = new System.Drawing.Point(259, 460);
            this.btnPreluarelvU.Name = "btnPreluarelvU";
            this.btnPreluarelvU.Size = new System.Drawing.Size(184, 36);
            this.btnPreluarelvU.TabIndex = 20;
            this.btnPreluarelvU.Text = "PreluareUtilizatori";
            this.btnPreluarelvU.UseVisualStyleBackColor = true;
            this.btnPreluarelvU.Click += new System.EventHandler(this.btnPreluarelvU_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(449, 436);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(149, 60);
            this.btnCheck.TabIndex = 21;
            this.btnCheck.Text = "CheckBiciclete";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnAfisareBicicleteSiUtilizatoriTB
            // 
            this.btnAfisareBicicleteSiUtilizatoriTB.Location = new System.Drawing.Point(449, 370);
            this.btnAfisareBicicleteSiUtilizatoriTB.Name = "btnAfisareBicicleteSiUtilizatoriTB";
            this.btnAfisareBicicleteSiUtilizatoriTB.Size = new System.Drawing.Size(149, 60);
            this.btnAfisareBicicleteSiUtilizatoriTB.TabIndex = 22;
            this.btnAfisareBicicleteSiUtilizatoriTB.Text = "Afisare tot TB";
            this.btnAfisareBicicleteSiUtilizatoriTB.UseVisualStyleBackColor = true;
            this.btnAfisareBicicleteSiUtilizatoriTB.Click += new System.EventHandler(this.btnAfisareBicicleteTB_Click);
            // 
            // btnCalculareSuma
            // 
            this.btnCalculareSuma.Location = new System.Drawing.Point(449, 160);
            this.btnCalculareSuma.Name = "btnCalculareSuma";
            this.btnCalculareSuma.Size = new System.Drawing.Size(149, 40);
            this.btnCalculareSuma.TabIndex = 23;
            this.btnCalculareSuma.Text = "Calcul tarif";
            this.btnCalculareSuma.UseVisualStyleBackColor = true;
            this.btnCalculareSuma.Click += new System.EventHandler(this.btnCalculareSuma_Click);
            // 
            // tbCalculTarif
            // 
            this.tbCalculTarif.Location = new System.Drawing.Point(449, 225);
            this.tbCalculTarif.Name = "tbCalculTarif";
            this.tbCalculTarif.Size = new System.Drawing.Size(149, 22);
            this.tbCalculTarif.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareBinarToolStripMenuItem,
            this.restaurareBinarToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // salvareBinarToolStripMenuItem
            // 
            this.salvareBinarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bicicleteToolStripMenuItem,
            this.utilizatoriToolStripMenuItem});
            this.salvareBinarToolStripMenuItem.Name = "salvareBinarToolStripMenuItem";
            this.salvareBinarToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.salvareBinarToolStripMenuItem.Text = "Salvare Binar";
            // 
            // bicicleteToolStripMenuItem
            // 
            this.bicicleteToolStripMenuItem.Name = "bicicleteToolStripMenuItem";
            this.bicicleteToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.bicicleteToolStripMenuItem.Text = "Biciclete";
            this.bicicleteToolStripMenuItem.Click += new System.EventHandler(this.bicicleteToolStripMenuItem_Click);
            // 
            // utilizatoriToolStripMenuItem
            // 
            this.utilizatoriToolStripMenuItem.Name = "utilizatoriToolStripMenuItem";
            this.utilizatoriToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.utilizatoriToolStripMenuItem.Text = "Utilizatori";
            this.utilizatoriToolStripMenuItem.Click += new System.EventHandler(this.utilizatoriToolStripMenuItem_Click);
            // 
            // restaurareBinarToolStripMenuItem
            // 
            this.restaurareBinarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bicicleteToolStripMenuItem1,
            this.utilizatoriToolStripMenuItem1});
            this.restaurareBinarToolStripMenuItem.Name = "restaurareBinarToolStripMenuItem";
            this.restaurareBinarToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.restaurareBinarToolStripMenuItem.Text = "Restaurare Binar";
            // 
            // bicicleteToolStripMenuItem1
            // 
            this.bicicleteToolStripMenuItem1.Name = "bicicleteToolStripMenuItem1";
            this.bicicleteToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.bicicleteToolStripMenuItem1.Text = "Biciclete";
            this.bicicleteToolStripMenuItem1.Click += new System.EventHandler(this.bicicleteToolStripMenuItem1_Click);
            // 
            // utilizatoriToolStripMenuItem1
            // 
            this.utilizatoriToolStripMenuItem1.Name = "utilizatoriToolStripMenuItem1";
            this.utilizatoriToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.utilizatoriToolStripMenuItem1.Text = "Utilizatori";
            this.utilizatoriToolStripMenuItem1.Click += new System.EventHandler(this.utilizatoriToolStripMenuItem1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 60);
            this.button2.TabIndex = 27;
            this.button2.Text = "ImprimareDocument";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // tvBiciclete
            // 
            this.tvBiciclete.Location = new System.Drawing.Point(702, 161);
            this.tvBiciclete.Name = "tvBiciclete";
            this.tvBiciclete.Size = new System.Drawing.Size(173, 154);
            this.tvBiciclete.TabIndex = 28;
            // 
            // btnAdaugaTv
            // 
            this.btnAdaugaTv.Location = new System.Drawing.Point(702, 340);
            this.btnAdaugaTv.Name = "btnAdaugaTv";
            this.btnAdaugaTv.Size = new System.Drawing.Size(173, 40);
            this.btnAdaugaTv.TabIndex = 29;
            this.btnAdaugaTv.Text = "Adaugare Tree View";
            this.btnAdaugaTv.UseVisualStyleBackColor = true;
            this.btnAdaugaTv.Click += new System.EventHandler(this.btnAdaugaTv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 518);
            this.Controls.Add(this.btnAdaugaTv);
            this.Controls.Add(this.tvBiciclete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCalculTarif);
            this.Controls.Add(this.btnCalculareSuma);
            this.Controls.Add(this.btnAfisareBicicleteSiUtilizatoriTB);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnPreluarelvU);
            this.Controls.Add(this.btnPreluarelvB);
            this.Controls.Add(this.lvUtilizatori);
            this.Controls.Add(this.lvBiciclete);
            this.Controls.Add(this.btnAdaugaUtilizator);
            this.Controls.Add(this.btnAdaugaBiciclete);
            this.Controls.Add(this.tbAfisareTot);
            this.Controls.Add(this.tbDurata);
            this.Controls.Add(this.tbCodUtilizator);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbKM);
            this.Controls.Add(this.tbStatieParcare);
            this.Controls.Add(this.tbCodBicicleta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCodBicicleta;
        private System.Windows.Forms.TextBox tbStatieParcare;
        private System.Windows.Forms.TextBox tbKM;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbCodUtilizator;
        private System.Windows.Forms.TextBox tbDurata;
        private System.Windows.Forms.TextBox tbAfisareTot;
        private System.Windows.Forms.Button btnAdaugaBiciclete;
        private System.Windows.Forms.Button btnAdaugaUtilizator;
        private System.Windows.Forms.ListView lvBiciclete;
        private System.Windows.Forms.ColumnHeader Cod;
        private System.Windows.Forms.ColumnHeader Statie;
        private System.Windows.Forms.ColumnHeader KM;
        private System.Windows.Forms.ListView lvUtilizatori;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader CodUtilizator;
        private System.Windows.Forms.ColumnHeader Durata;
        private System.Windows.Forms.Button btnPreluarelvB;
        private System.Windows.Forms.Button btnPreluarelvU;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnAfisareBicicleteSiUtilizatoriTB;
        private System.Windows.Forms.Button btnCalculareSuma;
        private System.Windows.Forms.TextBox tbCalculTarif;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bicicleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilizatoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bicicleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem utilizatoriToolStripMenuItem1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TreeView tvBiciclete;
        private System.Windows.Forms.Button btnAdaugaTv;
    }
}

