namespace ToataMateria
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.btnAdaugaProdus = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAfisare = new System.Windows.Forms.Button();
            this.tbAfisareTB = new System.Windows.Forms.TextBox();
            this.tbValoare = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNumeSupermarket = new System.Windows.Forms.TextBox();
            this.cbLocatie = new System.Windows.Forms.ComboBox();
            this.tbProduse = new System.Windows.Forms.TextBox();
            this.btnAdaugaSupermarket = new System.Windows.Forms.Button();
            this.btnAfisareSupermarket = new System.Windows.Forms.Button();
            this.tbAfisareSupermarket = new System.Windows.Forms.TextBox();
            this.lvProduse = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAfisareLV = new System.Windows.Forms.Button();
            this.btnStergereLV = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbIDCheck = new System.Windows.Forms.TextBox();
            this.DataGridViewProduse = new System.Windows.Forms.DataGridView();
            this.btnAdaugareDGV = new System.Windows.Forms.Button();
            this.tvProduse = new System.Windows.Forms.TreeView();
            this.btnAfisareTv = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.citireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewBD = new System.Windows.Forms.DataGridView();
            this.tbProduseTXT = new System.Windows.Forms.TextBox();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnImprimare = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.btnControl = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAfisareListBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduse)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pret";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantitate";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(89, 83);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 22);
            this.tbID.TabIndex = 5;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(89, 125);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 22);
            this.tbNume.TabIndex = 6;
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(89, 167);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(100, 22);
            this.tbPret.TabIndex = 7;
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(89, 206);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(100, 22);
            this.tbCantitate.TabIndex = 8;
            // 
            // btnAdaugaProdus
            // 
            this.btnAdaugaProdus.Location = new System.Drawing.Point(37, 234);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(133, 35);
            this.btnAdaugaProdus.TabIndex = 9;
            this.btnAdaugaProdus.Text = "Adauga produs";
            this.btnAdaugaProdus.UseVisualStyleBackColor = true;
            this.btnAdaugaProdus.Click += new System.EventHandler(this.btnAdaugaProdus_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(37, 288);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(133, 36);
            this.btnAfisare.TabIndex = 10;
            this.btnAfisare.Text = "AfisareTB";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // tbAfisareTB
            // 
            this.tbAfisareTB.Location = new System.Drawing.Point(216, 79);
            this.tbAfisareTB.Multiline = true;
            this.tbAfisareTB.Name = "tbAfisareTB";
            this.tbAfisareTB.Size = new System.Drawing.Size(174, 143);
            this.tbAfisareTB.TabIndex = 11;
            // 
            // tbValoare
            // 
            this.tbValoare.Location = new System.Drawing.Point(200, 41);
            this.tbValoare.Name = "tbValoare";
            this.tbValoare.Size = new System.Drawing.Size(100, 22);
            this.tbValoare.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Valoare Produs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Supermarket";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nume";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(451, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Locatie";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Produse";
            // 
            // tbNumeSupermarket
            // 
            this.tbNumeSupermarket.Location = new System.Drawing.Point(522, 80);
            this.tbNumeSupermarket.Name = "tbNumeSupermarket";
            this.tbNumeSupermarket.Size = new System.Drawing.Size(100, 22);
            this.tbNumeSupermarket.TabIndex = 18;
            // 
            // cbLocatie
            // 
            this.cbLocatie.FormattingEnabled = true;
            this.cbLocatie.Items.AddRange(new object[] {
            "Bucuresti",
            "Iasi",
            "Galati",
            "Buzau"});
            this.cbLocatie.Location = new System.Drawing.Point(522, 116);
            this.cbLocatie.Name = "cbLocatie";
            this.cbLocatie.Size = new System.Drawing.Size(121, 24);
            this.cbLocatie.TabIndex = 19;
            // 
            // tbProduse
            // 
            this.tbProduse.Location = new System.Drawing.Point(522, 156);
            this.tbProduse.Name = "tbProduse";
            this.tbProduse.Size = new System.Drawing.Size(100, 22);
            this.tbProduse.TabIndex = 20;
            // 
            // btnAdaugaSupermarket
            // 
            this.btnAdaugaSupermarket.Location = new System.Drawing.Point(475, 199);
            this.btnAdaugaSupermarket.Name = "btnAdaugaSupermarket";
            this.btnAdaugaSupermarket.Size = new System.Drawing.Size(147, 45);
            this.btnAdaugaSupermarket.TabIndex = 21;
            this.btnAdaugaSupermarket.Text = "Adauga supermarket";
            this.btnAdaugaSupermarket.UseVisualStyleBackColor = true;
            this.btnAdaugaSupermarket.Click += new System.EventHandler(this.btnAdaugaSupermarket_Click);
            // 
            // btnAfisareSupermarket
            // 
            this.btnAfisareSupermarket.Location = new System.Drawing.Point(475, 250);
            this.btnAfisareSupermarket.Name = "btnAfisareSupermarket";
            this.btnAfisareSupermarket.Size = new System.Drawing.Size(147, 43);
            this.btnAfisareSupermarket.TabIndex = 22;
            this.btnAfisareSupermarket.Text = "Afisare Supermarket";
            this.btnAfisareSupermarket.UseVisualStyleBackColor = true;
            this.btnAfisareSupermarket.Click += new System.EventHandler(this.btnAfisareSupermarket_Click);
            // 
            // tbAfisareSupermarket
            // 
            this.tbAfisareSupermarket.Location = new System.Drawing.Point(675, 79);
            this.tbAfisareSupermarket.Multiline = true;
            this.tbAfisareSupermarket.Name = "tbAfisareSupermarket";
            this.tbAfisareSupermarket.Size = new System.Drawing.Size(181, 143);
            this.tbAfisareSupermarket.TabIndex = 23;
            // 
            // lvProduse
            // 
            this.lvProduse.CheckBoxes = true;
            this.lvProduse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nume,
            this.Pret,
            this.Cantitate});
            this.lvProduse.GridLines = true;
            this.lvProduse.HideSelection = false;
            this.lvProduse.Location = new System.Drawing.Point(37, 349);
            this.lvProduse.Name = "lvProduse";
            this.lvProduse.Size = new System.Drawing.Size(248, 97);
            this.lvProduse.TabIndex = 24;
            this.lvProduse.UseCompatibleStateImageBehavior = false;
            this.lvProduse.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            // 
            // Pret
            // 
            this.Pret.Text = "Pret";
            // 
            // Cantitate
            // 
            this.Cantitate.Text = "Cantitate";
            // 
            // btnAfisareLV
            // 
            this.btnAfisareLV.Location = new System.Drawing.Point(216, 234);
            this.btnAfisareLV.Name = "btnAfisareLV";
            this.btnAfisareLV.Size = new System.Drawing.Size(174, 35);
            this.btnAfisareLV.TabIndex = 25;
            this.btnAfisareLV.Text = "Afisare LV";
            this.btnAfisareLV.UseVisualStyleBackColor = true;
            this.btnAfisareLV.Click += new System.EventHandler(this.btnAfisareLV_Click);
            // 
            // btnStergereLV
            // 
            this.btnStergereLV.Location = new System.Drawing.Point(216, 288);
            this.btnStergereLV.Name = "btnStergereLV";
            this.btnStergereLV.Size = new System.Drawing.Size(174, 36);
            this.btnStergereLV.TabIndex = 26;
            this.btnStergereLV.Text = "Stergere LV";
            this.btnStergereLV.UseVisualStyleBackColor = true;
            this.btnStergereLV.Click += new System.EventHandler(this.btnStergereLV_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(329, 349);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(139, 39);
            this.btnCheck.TabIndex = 27;
            this.btnCheck.Text = "Check produs";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "ID Check:";
            // 
            // tbIDCheck
            // 
            this.tbIDCheck.Location = new System.Drawing.Point(351, 424);
            this.tbIDCheck.Name = "tbIDCheck";
            this.tbIDCheck.Size = new System.Drawing.Size(100, 22);
            this.tbIDCheck.TabIndex = 29;
            // 
            // DataGridViewProduse
            // 
            this.DataGridViewProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProduse.Location = new System.Drawing.Point(475, 299);
            this.DataGridViewProduse.Name = "DataGridViewProduse";
            this.DataGridViewProduse.RowHeadersWidth = 51;
            this.DataGridViewProduse.RowTemplate.Height = 24;
            this.DataGridViewProduse.Size = new System.Drawing.Size(240, 150);
            this.DataGridViewProduse.TabIndex = 30;
            // 
            // btnAdaugareDGV
            // 
            this.btnAdaugareDGV.Location = new System.Drawing.Point(675, 250);
            this.btnAdaugareDGV.Name = "btnAdaugareDGV";
            this.btnAdaugareDGV.Size = new System.Drawing.Size(181, 43);
            this.btnAdaugareDGV.TabIndex = 31;
            this.btnAdaugareDGV.Text = "Afisare DGV";
            this.btnAdaugareDGV.UseVisualStyleBackColor = true;
            this.btnAdaugareDGV.Click += new System.EventHandler(this.btnAdaugareDGV_Click);
            // 
            // tvProduse
            // 
            this.tvProduse.Location = new System.Drawing.Point(890, 79);
            this.tvProduse.Name = "tvProduse";
            this.tvProduse.Size = new System.Drawing.Size(164, 143);
            this.tvProduse.TabIndex = 32;
            // 
            // btnAfisareTv
            // 
            this.btnAfisareTv.Location = new System.Drawing.Point(890, 250);
            this.btnAfisareTv.Name = "btnAfisareTv";
            this.btnAfisareTv.Size = new System.Drawing.Size(164, 43);
            this.btnAfisareTv.TabIndex = 33;
            this.btnAfisareTv.Text = "Afisare TreeView";
            this.btnAfisareTv.UseVisualStyleBackColor = true;
            this.btnAfisareTv.Click += new System.EventHandler(this.btnAfisareTv_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.afisareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1305, 28);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierTXTToolStripMenuItem,
            this.binarToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // fisierTXTToolStripMenuItem
            // 
            this.fisierTXTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem1,
            this.restaurareToolStripMenuItem1,
            this.citireToolStripMenuItem});
            this.fisierTXTToolStripMenuItem.Name = "fisierTXTToolStripMenuItem";
            this.fisierTXTToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.fisierTXTToolStripMenuItem.Text = "Fisier TXT";
            this.fisierTXTToolStripMenuItem.Click += new System.EventHandler(this.fisierTXTToolStripMenuItem_Click);
            // 
            // salvareToolStripMenuItem1
            // 
            this.salvareToolStripMenuItem1.Name = "salvareToolStripMenuItem1";
            this.salvareToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.salvareToolStripMenuItem1.Text = "Salvare";
            this.salvareToolStripMenuItem1.Click += new System.EventHandler(this.salvareToolStripMenuItem1_Click);
            // 
            // restaurareToolStripMenuItem1
            // 
            this.restaurareToolStripMenuItem1.Name = "restaurareToolStripMenuItem1";
            this.restaurareToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.restaurareToolStripMenuItem1.Text = "Restaurare";
            this.restaurareToolStripMenuItem1.Click += new System.EventHandler(this.restaurareToolStripMenuItem1_Click);
            // 
            // citireToolStripMenuItem
            // 
            this.citireToolStripMenuItem.Name = "citireToolStripMenuItem";
            this.citireToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.citireToolStripMenuItem.Text = "Citire";
            this.citireToolStripMenuItem.Click += new System.EventHandler(this.citireToolStripMenuItem_Click);
            // 
            // binarToolStripMenuItem
            // 
            this.binarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.restaurareToolStripMenuItem});
            this.binarToolStripMenuItem.Name = "binarToolStripMenuItem";
            this.binarToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.binarToolStripMenuItem.Text = "Binar";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // restaurareToolStripMenuItem
            // 
            this.restaurareToolStripMenuItem.Name = "restaurareToolStripMenuItem";
            this.restaurareToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.restaurareToolStripMenuItem.Text = "Restaurare";
            this.restaurareToolStripMenuItem.Click += new System.EventHandler(this.restaurareToolStripMenuItem_Click);
            // 
            // afisareToolStripMenuItem
            // 
            this.afisareToolStripMenuItem.Name = "afisareToolStripMenuItem";
            this.afisareToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.afisareToolStripMenuItem.Text = "Afisare";
            this.afisareToolStripMenuItem.Click += new System.EventHandler(this.afisareToolStripMenuItem_Click);
            // 
            // dataGridViewBD
            // 
            this.dataGridViewBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBD.Location = new System.Drawing.Point(739, 299);
            this.dataGridViewBD.Name = "dataGridViewBD";
            this.dataGridViewBD.RowHeadersWidth = 51;
            this.dataGridViewBD.RowTemplate.Height = 24;
            this.dataGridViewBD.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewBD.TabIndex = 35;
            // 
            // tbProduseTXT
            // 
            this.tbProduseTXT.Location = new System.Drawing.Point(675, 12);
            this.tbProduseTXT.Multiline = true;
            this.tbProduseTXT.Name = "tbProduseTXT";
            this.tbProduseTXT.Size = new System.Drawing.Size(181, 61);
            this.tbProduseTXT.TabIndex = 36;
            // 
            // btnClipboard
            // 
            this.btnClipboard.Location = new System.Drawing.Point(890, 32);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(164, 41);
            this.btnClipboard.TabIndex = 37;
            this.btnClipboard.Text = "Copy Clipboard";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
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
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnImprimare
            // 
            this.btnImprimare.Location = new System.Drawing.Point(985, 299);
            this.btnImprimare.Name = "btnImprimare";
            this.btnImprimare.Size = new System.Drawing.Size(123, 37);
            this.btnImprimare.TabIndex = 38;
            this.btnImprimare.Text = "Imprimare";
            this.btnImprimare.UseVisualStyleBackColor = true;
            this.btnImprimare.Click += new System.EventHandler(this.btnImprimare_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(1147, 61);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 22);
            this.tbUsername.TabIndex = 39;
            // 
            // tbParola
            // 
            this.tbParola.Location = new System.Drawing.Point(1147, 99);
            this.tbParola.Name = "tbParola";
            this.tbParola.Size = new System.Drawing.Size(100, 22);
            this.tbParola.TabIndex = 40;
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(1147, 138);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(100, 34);
            this.btnControl.TabIndex = 41;
            this.btnControl.Text = "Control";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1135, 199);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 148);
            this.listBox1.TabIndex = 42;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAfisareListBox
            // 
            this.btnAfisareListBox.Location = new System.Drawing.Point(1135, 364);
            this.btnAfisareListBox.Name = "btnAfisareListBox";
            this.btnAfisareListBox.Size = new System.Drawing.Size(158, 24);
            this.btnAfisareListBox.TabIndex = 43;
            this.btnAfisareListBox.Text = "Afisare ListBox";
            this.btnAfisareListBox.UseVisualStyleBackColor = true;
            this.btnAfisareListBox.Click += new System.EventHandler(this.btnAfisareListBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(994, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "AfLV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(994, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "AfDGV";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1135, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 23);
            this.button3.TabIndex = 46;
            this.button3.Text = "AfLB";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 458);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAfisareListBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnImprimare);
            this.Controls.Add(this.btnClipboard);
            this.Controls.Add(this.tbProduseTXT);
            this.Controls.Add(this.dataGridViewBD);
            this.Controls.Add(this.btnAfisareTv);
            this.Controls.Add(this.tvProduse);
            this.Controls.Add(this.btnAdaugareDGV);
            this.Controls.Add(this.DataGridViewProduse);
            this.Controls.Add(this.tbIDCheck);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnStergereLV);
            this.Controls.Add(this.btnAfisareLV);
            this.Controls.Add(this.lvProduse);
            this.Controls.Add(this.tbAfisareSupermarket);
            this.Controls.Add(this.btnAfisareSupermarket);
            this.Controls.Add(this.btnAdaugaSupermarket);
            this.Controls.Add(this.tbProduse);
            this.Controls.Add(this.cbLocatie);
            this.Controls.Add(this.tbNumeSupermarket);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbValoare);
            this.Controls.Add(this.tbAfisareTB);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnAdaugaProdus);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbID);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduse)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.TextBox tbAfisareTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbValoare;
        private System.Windows.Forms.ComboBox cbLocatie;
        private System.Windows.Forms.TextBox tbNumeSupermarket;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbProduse;
        private System.Windows.Forms.TextBox tbAfisareSupermarket;
        private System.Windows.Forms.Button btnAfisareSupermarket;
        private System.Windows.Forms.Button btnAdaugaSupermarket;
        private System.Windows.Forms.ListView lvProduse;
        private System.Windows.Forms.Button btnAfisareLV;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Pret;
        private System.Windows.Forms.ColumnHeader Cantitate;
        private System.Windows.Forms.Button btnStergereLV;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox tbIDCheck;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdaugareDGV;
        private System.Windows.Forms.DataGridView DataGridViewProduse;
        private System.Windows.Forms.Button btnAfisareTv;
        private System.Windows.Forms.TreeView tvProduse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierTXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restaurareToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridViewBD;
        private System.Windows.Forms.ToolStripMenuItem citireToolStripMenuItem;
        private System.Windows.Forms.TextBox tbProduseTXT;
        private System.Windows.Forms.Button btnClipboard;
        private System.Windows.Forms.Button btnImprimare;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem afisareToolStripMenuItem;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnAfisareListBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

