namespace Comenzi_Pizza
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbNume = new TextBox();
            tbPret = new TextBox();
            tbCantitate = new TextBox();
            tbCod = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbNumeComanda = new TextBox();
            tbDurataComanda = new TextBox();
            cbBlatComanda = new ComboBox();
            label10 = new Label();
            tbCodComanda = new TextBox();
            btnAdaugaTopping = new Button();
            btnAdaugaComanda = new Button();
            tbAfisareComenzi = new TextBox();
            button1 = new Button();
            tvComenzi = new TreeView();
            btnPreluareTV = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            tXTToolStripMenuItem = new ToolStripMenuItem();
            salvareToolStripMenuItem = new ToolStripMenuItem();
            citireToolStripMenuItem = new ToolStripMenuItem();
            sQLToolStripMenuItem = new ToolStripMenuItem();
            citireSQLToolStripMenuItem = new ToolStripMenuItem();
            lvComenzi = new ListView();
            NumeHeader = new ColumnHeader();
            PretHeader = new ColumnHeader();
            CantitateHeader = new ColumnHeader();
            CodHeader = new ColumnHeader();
            dgvTopping = new DataGridView();
            btnAfisareGridView = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopping).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 29);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Topping";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 66);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Nume";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 116);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 2;
            label3.Text = "Pret";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 156);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Cantitate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 198);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 4;
            label5.Text = "Cod";
            // 
            // tbNume
            // 
            tbNume.Location = new Point(131, 63);
            tbNume.Name = "tbNume";
            tbNume.Size = new Size(125, 27);
            tbNume.TabIndex = 5;
            // 
            // tbPret
            // 
            tbPret.Location = new Point(131, 109);
            tbPret.Name = "tbPret";
            tbPret.Size = new Size(125, 27);
            tbPret.TabIndex = 6;
            // 
            // tbCantitate
            // 
            tbCantitate.Location = new Point(131, 149);
            tbCantitate.Name = "tbCantitate";
            tbCantitate.Size = new Size(125, 27);
            tbCantitate.TabIndex = 7;
            // 
            // tbCod
            // 
            tbCod.Location = new Point(131, 191);
            tbCod.Name = "tbCod";
            tbCod.Size = new Size(125, 27);
            tbCod.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(422, 21);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 9;
            label6.Text = "Comanda Pizza";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(374, 62);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 10;
            label7.Text = "Nume";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(374, 156);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 11;
            label8.Text = "Blat";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(374, 112);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 12;
            label9.Text = "Durata";
            // 
            // tbNumeComanda
            // 
            tbNumeComanda.Location = new Point(479, 59);
            tbNumeComanda.Name = "tbNumeComanda";
            tbNumeComanda.Size = new Size(125, 27);
            tbNumeComanda.TabIndex = 13;
            // 
            // tbDurataComanda
            // 
            tbDurataComanda.Location = new Point(479, 109);
            tbDurataComanda.Name = "tbDurataComanda";
            tbDurataComanda.Size = new Size(125, 27);
            tbDurataComanda.TabIndex = 15;
            // 
            // cbBlatComanda
            // 
            cbBlatComanda.FormattingEnabled = true;
            cbBlatComanda.Items.AddRange(new object[] { "Italian", "Gros", "Subtire", "Barcuta" });
            cbBlatComanda.Location = new Point(479, 148);
            cbBlatComanda.Name = "cbBlatComanda";
            cbBlatComanda.Size = new Size(151, 28);
            cbBlatComanda.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(374, 197);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 17;
            label10.Text = "CodTopping:";
            // 
            // tbCodComanda
            // 
            tbCodComanda.Location = new Point(485, 195);
            tbCodComanda.Name = "tbCodComanda";
            tbCodComanda.Size = new Size(125, 27);
            tbCodComanda.TabIndex = 18;
            // 
            // btnAdaugaTopping
            // 
            btnAdaugaTopping.Location = new Point(46, 249);
            btnAdaugaTopping.Name = "btnAdaugaTopping";
            btnAdaugaTopping.Size = new Size(173, 39);
            btnAdaugaTopping.TabIndex = 19;
            btnAdaugaTopping.Text = "AdaugaTopping";
            btnAdaugaTopping.UseVisualStyleBackColor = true;
            btnAdaugaTopping.Click += btnAdaugaTopping_Click;
            // 
            // btnAdaugaComanda
            // 
            btnAdaugaComanda.Location = new Point(409, 249);
            btnAdaugaComanda.Name = "btnAdaugaComanda";
            btnAdaugaComanda.Size = new Size(173, 39);
            btnAdaugaComanda.TabIndex = 20;
            btnAdaugaComanda.Text = "AdaugaComanda";
            btnAdaugaComanda.UseVisualStyleBackColor = true;
            btnAdaugaComanda.Click += btnAdaugaComanda_Click;
            // 
            // tbAfisareComenzi
            // 
            tbAfisareComenzi.Location = new Point(27, 308);
            tbAfisareComenzi.Multiline = true;
            tbAfisareComenzi.Name = "tbAfisareComenzi";
            tbAfisareComenzi.Size = new Size(250, 110);
            tbAfisareComenzi.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(409, 308);
            button1.Name = "button1";
            button1.Size = new Size(173, 44);
            button1.TabIndex = 22;
            button1.Text = "AfisareComanda";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tvComenzi
            // 
            tvComenzi.Location = new Point(735, 29);
            tvComenzi.Name = "tvComenzi";
            tvComenzi.Size = new Size(325, 198);
            tvComenzi.TabIndex = 23;
            // 
            // btnPreluareTV
            // 
            btnPreluareTV.Location = new Point(735, 260);
            btnPreluareTV.Name = "btnPreluareTV";
            btnPreluareTV.Size = new Size(325, 43);
            btnPreluareTV.TabIndex = 24;
            btnPreluareTV.Text = "PreluareTV";
            btnPreluareTV.UseVisualStyleBackColor = true;
            btnPreluareTV.Click += btnPreluareTV_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1279, 28);
            menuStrip1.TabIndex = 25;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tXTToolStripMenuItem, sQLToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // tXTToolStripMenuItem
            // 
            tXTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salvareToolStripMenuItem, citireToolStripMenuItem });
            tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            tXTToolStripMenuItem.Size = new Size(118, 26);
            tXTToolStripMenuItem.Text = "TXT";
            // 
            // salvareToolStripMenuItem
            // 
            salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            salvareToolStripMenuItem.Size = new Size(140, 26);
            salvareToolStripMenuItem.Text = "Salvare";
            salvareToolStripMenuItem.Click += salvareToolStripMenuItem_Click;
            // 
            // citireToolStripMenuItem
            // 
            citireToolStripMenuItem.Name = "citireToolStripMenuItem";
            citireToolStripMenuItem.Size = new Size(140, 26);
            citireToolStripMenuItem.Text = "Citire";
            citireToolStripMenuItem.Click += citireToolStripMenuItem_Click;
            // 
            // sQLToolStripMenuItem
            // 
            sQLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { citireSQLToolStripMenuItem });
            sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            sQLToolStripMenuItem.Size = new Size(118, 26);
            sQLToolStripMenuItem.Text = "SQL";
            // 
            // citireSQLToolStripMenuItem
            // 
            citireSQLToolStripMenuItem.Name = "citireSQLToolStripMenuItem";
            citireSQLToolStripMenuItem.Size = new Size(153, 26);
            citireSQLToolStripMenuItem.Text = "CitireSQL";
            citireSQLToolStripMenuItem.Click += citireSQLToolStripMenuItem_Click;
            // 
            // lvComenzi
            // 
            lvComenzi.CheckBoxes = true;
            lvComenzi.Columns.AddRange(new ColumnHeader[] { NumeHeader, PretHeader, CantitateHeader, CodHeader });
            lvComenzi.FullRowSelect = true;
            lvComenzi.GridLines = true;
            lvComenzi.Location = new Point(729, 349);
            lvComenzi.Name = "lvComenzi";
            lvComenzi.Size = new Size(245, 161);
            lvComenzi.TabIndex = 26;
            lvComenzi.UseCompatibleStateImageBehavior = false;
            lvComenzi.View = View.Details;
            // 
            // NumeHeader
            // 
            NumeHeader.Text = "Nume";
            // 
            // PretHeader
            // 
            PretHeader.Text = "Pret";
            // 
            // CantitateHeader
            // 
            CantitateHeader.Text = "Cantitate";
            // 
            // CodHeader
            // 
            CodHeader.Text = "Cod";
            // 
            // dgvTopping
            // 
            dgvTopping.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopping.Location = new Point(1009, 349);
            dgvTopping.Name = "dgvTopping";
            dgvTopping.RowHeadersWidth = 51;
            dgvTopping.RowTemplate.Height = 29;
            dgvTopping.Size = new Size(258, 161);
            dgvTopping.TabIndex = 27;
            dgvTopping.CellContentClick += dgvTopping_CellContentClick;
            // 
            // btnAfisareGridView
            // 
            btnAfisareGridView.Location = new Point(409, 371);
            btnAfisareGridView.Name = "btnAfisareGridView";
            btnAfisareGridView.Size = new Size(173, 47);
            btnAfisareGridView.TabIndex = 28;
            btnAfisareGridView.Text = "AfisareGridView";
            btnAfisareGridView.UseVisualStyleBackColor = true;
            btnAfisareGridView.Click += btnAfisareGridView_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 580);
            Controls.Add(btnAfisareGridView);
            Controls.Add(dgvTopping);
            Controls.Add(lvComenzi);
            Controls.Add(btnPreluareTV);
            Controls.Add(tvComenzi);
            Controls.Add(button1);
            Controls.Add(tbAfisareComenzi);
            Controls.Add(btnAdaugaComanda);
            Controls.Add(btnAdaugaTopping);
            Controls.Add(tbCodComanda);
            Controls.Add(label10);
            Controls.Add(cbBlatComanda);
            Controls.Add(tbDurataComanda);
            Controls.Add(tbNumeComanda);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(tbCod);
            Controls.Add(tbCantitate);
            Controls.Add(tbPret);
            Controls.Add(tbNume);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopping).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbNume;
        private TextBox tbPret;
        private TextBox tbCantitate;
        private TextBox tbCod;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tbNumeComanda;
        private TextBox tbDurataComanda;
        private ComboBox cbBlatComanda;
        private Label label10;
        private TextBox tbCodComanda;
        private Button btnAdaugaTopping;
        private Button btnAdaugaComanda;
        private TextBox tbAfisareComenzi;
        private Button button1;
        private TreeView tvComenzi;
        private Button btnPreluareTV;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem tXTToolStripMenuItem;
        private ToolStripMenuItem salvareToolStripMenuItem;
        private ToolStripMenuItem citireToolStripMenuItem;
        private ListView lvComenzi;
        private ColumnHeader NumeHeader;
        private ColumnHeader PretHeader;
        private ColumnHeader CantitateHeader;
        private ColumnHeader CodHeader;
        private ToolStripMenuItem sQLToolStripMenuItem;
        private ToolStripMenuItem citireSQLToolStripMenuItem;
        private DataGridView dgvTopping;
        private Button btnAfisareGridView;
    }
}