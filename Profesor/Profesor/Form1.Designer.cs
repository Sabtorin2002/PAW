namespace Profesor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbMarca = new TextBox();
            tbNume = new TextBox();
            tbSalariu = new TextBox();
            btnAdauga = new Button();
            DataGridView = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            btnAfisareDGV = new Button();
            lvProfesori = new ListView();
            Marca = new ColumnHeader();
            Nume = new ColumnHeader();
            Salariu = new ColumnHeader();
            btnAfiseazaLV = new Button();
            profesorTV = new TreeView();
            btnAdaugareTV = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            btnImprimare = new Button();
            tbAfisare = new TextBox();
            btnAfisareTB = new Button();
            menuStrip1 = new MenuStrip();
            afisareToolStripMenuItem = new ToolStripMenuItem();
            fisierToolStripMenuItem = new ToolStripMenuItem();
            textToolStripMenuItem = new ToolStripMenuItem();
            salvareToolStripMenuItem1 = new ToolStripMenuItem();
            restaurareToolStripMenuItem1 = new ToolStripMenuItem();
            binarToolStripMenuItem = new ToolStripMenuItem();
            salvareToolStripMenuItem = new ToolStripMenuItem();
            restaurareToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            tbNou = new TextBox();
            btnCalculare = new Button();
            tbTotal = new TextBox();
            tbValoare = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button1 = new Button();
            button10 = new Button();
            button11 = new Button();
            printDocument2 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog2 = new PrintPreviewDialog();
            button12 = new Button();
            printPreviewDialog3 = new PrintPreviewDialog();
            printDocument3 = new System.Drawing.Printing.PrintDocument();
            button13 = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 84);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Nume";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 120);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Salariu";
            // 
            // tbMarca
            // 
            tbMarca.Location = new Point(90, 37);
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(125, 27);
            tbMarca.TabIndex = 3;
            // 
            // tbNume
            // 
            tbNume.Location = new Point(90, 77);
            tbNume.Name = "tbNume";
            tbNume.Size = new Size(125, 27);
            tbNume.TabIndex = 4;
            // 
            // tbSalariu
            // 
            tbSalariu.Location = new Point(90, 113);
            tbSalariu.Name = "tbSalariu";
            tbSalariu.Size = new Size(125, 27);
            tbSalariu.TabIndex = 5;
            // 
            // btnAdauga
            // 
            btnAdauga.Location = new Point(23, 197);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(137, 47);
            btnAdauga.TabIndex = 6;
            btnAdauga.Text = "Adauga";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(431, 65);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.RowTemplate.Height = 29;
            DataGridView.Size = new Size(299, 188);
            DataGridView.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnAfisareDGV
            // 
            btnAfisareDGV.Location = new Point(23, 251);
            btnAfisareDGV.Name = "btnAfisareDGV";
            btnAfisareDGV.Size = new Size(137, 49);
            btnAfisareDGV.TabIndex = 8;
            btnAfisareDGV.Text = "Afisare DataGV";
            btnAfisareDGV.UseVisualStyleBackColor = true;
            btnAfisareDGV.Click += btnAfisareDGV_Click;
            // 
            // lvProfesori
            // 
            lvProfesori.CheckBoxes = true;
            lvProfesori.Columns.AddRange(new ColumnHeader[] { Marca, Nume, Salariu });
            lvProfesori.GridLines = true;
            lvProfesori.Location = new Point(201, 197);
            lvProfesori.Name = "lvProfesori";
            lvProfesori.Size = new Size(206, 103);
            lvProfesori.TabIndex = 9;
            lvProfesori.UseCompatibleStateImageBehavior = false;
            lvProfesori.View = View.Details;
            // 
            // Marca
            // 
            Marca.Text = "Marca";
            // 
            // Nume
            // 
            Nume.Text = "Nume";
            // 
            // Salariu
            // 
            Salariu.Text = "Salariu";
            // 
            // btnAfiseazaLV
            // 
            btnAfiseazaLV.Location = new Point(23, 307);
            btnAfiseazaLV.Name = "btnAfiseazaLV";
            btnAfiseazaLV.Size = new Size(137, 44);
            btnAfiseazaLV.TabIndex = 10;
            btnAfiseazaLV.Text = "Afiseaza LV";
            btnAfiseazaLV.UseVisualStyleBackColor = true;
            btnAfiseazaLV.Click += btnAfiseazaLV_Click;
            // 
            // profesorTV
            // 
            profesorTV.Location = new Point(201, 323);
            profesorTV.Name = "profesorTV";
            profesorTV.Size = new Size(206, 116);
            profesorTV.TabIndex = 11;
            // 
            // btnAdaugareTV
            // 
            btnAdaugareTV.Location = new Point(23, 369);
            btnAdaugareTV.Name = "btnAdaugareTV";
            btnAdaugareTV.Size = new Size(137, 39);
            btnAdaugareTV.TabIndex = 12;
            btnAdaugareTV.Text = "Adaugare TV";
            btnAdaugareTV.UseVisualStyleBackColor = true;
            btnAdaugareTV.Click += btnAdaugareTV_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // btnImprimare
            // 
            btnImprimare.Location = new Point(443, 271);
            btnImprimare.Name = "btnImprimare";
            btnImprimare.Size = new Size(187, 45);
            btnImprimare.TabIndex = 13;
            btnImprimare.Text = "Imprimare Document";
            btnImprimare.UseVisualStyleBackColor = true;
            btnImprimare.Click += btnImprimare_Click;
            // 
            // tbAfisare
            // 
            tbAfisare.Location = new Point(443, 323);
            tbAfisare.Margin = new Padding(3, 4, 3, 4);
            tbAfisare.Multiline = true;
            tbAfisare.Name = "tbAfisare";
            tbAfisare.Size = new Size(187, 116);
            tbAfisare.TabIndex = 14;
            tbAfisare.TextChanged += textBox1_TextChanged;
            // 
            // btnAfisareTB
            // 
            btnAfisareTB.Location = new Point(26, 420);
            btnAfisareTB.Name = "btnAfisareTB";
            btnAfisareTB.Size = new Size(134, 35);
            btnAfisareTB.TabIndex = 15;
            btnAfisareTB.Text = "Afisare TextBox";
            btnAfisareTB.UseVisualStyleBackColor = true;
            btnAfisareTB.Click += btnAfisareTB_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { afisareToolStripMenuItem, fisierToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1312, 30);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // afisareToolStripMenuItem
            // 
            afisareToolStripMenuItem.Name = "afisareToolStripMenuItem";
            afisareToolStripMenuItem.Size = new Size(69, 24);
            afisareToolStripMenuItem.Text = "Afisare";
            afisareToolStripMenuItem.Click += afisareToolStripMenuItem_Click;
            // 
            // fisierToolStripMenuItem
            // 
            fisierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { textToolStripMenuItem, binarToolStripMenuItem });
            fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            fisierToolStripMenuItem.Size = new Size(57, 24);
            fisierToolStripMenuItem.Text = "Fisier";
            // 
            // textToolStripMenuItem
            // 
            textToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salvareToolStripMenuItem1, restaurareToolStripMenuItem1 });
            textToolStripMenuItem.Name = "textToolStripMenuItem";
            textToolStripMenuItem.Size = new Size(126, 26);
            textToolStripMenuItem.Text = "Text";
            // 
            // salvareToolStripMenuItem1
            // 
            salvareToolStripMenuItem1.Name = "salvareToolStripMenuItem1";
            salvareToolStripMenuItem1.Size = new Size(162, 26);
            salvareToolStripMenuItem1.Text = "Salvare";
            salvareToolStripMenuItem1.Click += salvareToolStripMenuItem1_Click;
            // 
            // restaurareToolStripMenuItem1
            // 
            restaurareToolStripMenuItem1.Name = "restaurareToolStripMenuItem1";
            restaurareToolStripMenuItem1.Size = new Size(162, 26);
            restaurareToolStripMenuItem1.Text = "Restaurare";
            restaurareToolStripMenuItem1.Click += restaurareToolStripMenuItem1_Click;
            // 
            // binarToolStripMenuItem
            // 
            binarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salvareToolStripMenuItem, restaurareToolStripMenuItem });
            binarToolStripMenuItem.Name = "binarToolStripMenuItem";
            binarToolStripMenuItem.Size = new Size(126, 26);
            binarToolStripMenuItem.Text = "Binar";
            binarToolStripMenuItem.Click += binarToolStripMenuItem_Click;
            // 
            // salvareToolStripMenuItem
            // 
            salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            salvareToolStripMenuItem.Size = new Size(162, 26);
            salvareToolStripMenuItem.Text = "Salvare";
            salvareToolStripMenuItem.Click += salvareToolStripMenuItem_Click;
            // 
            // restaurareToolStripMenuItem
            // 
            restaurareToolStripMenuItem.Name = "restaurareToolStripMenuItem";
            restaurareToolStripMenuItem.Size = new Size(162, 26);
            restaurareToolStripMenuItem.Text = "Restaurare";
            restaurareToolStripMenuItem.Click += restaurareToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 155);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 17;
            label4.Text = "Salariu nou";
            // 
            // tbNou
            // 
            tbNou.Location = new Point(138, 155);
            tbNou.Name = "tbNou";
            tbNou.Size = new Size(125, 27);
            tbNou.TabIndex = 18;
            // 
            // btnCalculare
            // 
            btnCalculare.Location = new Point(281, 39);
            btnCalculare.Name = "btnCalculare";
            btnCalculare.Size = new Size(127, 29);
            btnCalculare.TabIndex = 19;
            btnCalculare.Text = "Calculeaza salarii";
            btnCalculare.UseVisualStyleBackColor = true;
            btnCalculare.Click += btnCalculare_Click;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(281, 84);
            tbTotal.Margin = new Padding(3, 4, 3, 4);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(126, 27);
            tbTotal.TabIndex = 20;
            tbTotal.TextChanged += tbTotal_TextChanged;
            // 
            // tbValoare
            // 
            tbValoare.Location = new Point(286, 161);
            tbValoare.Margin = new Padding(3, 4, 3, 4);
            tbValoare.Name = "tbValoare";
            tbValoare.Size = new Size(122, 27);
            tbValoare.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(293, 131);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 23;
            label5.Text = "Valoare adaugata";
            // 
            // button2
            // 
            button2.Location = new Point(737, 44);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 24;
            button2.Text = "AfisareDGV";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(737, 75);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 25;
            button3.Text = "AfisareDGV";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(737, 109);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(94, 31);
            button4.TabIndex = 26;
            button4.Text = "AfisareDGV";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(738, 169);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(93, 31);
            button5.TabIndex = 27;
            button5.Text = "AfisareLV";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(741, 205);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 28;
            button6.Text = "AfisareLV";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(743, 243);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(88, 31);
            button7.TabIndex = 29;
            button7.Text = "AfisareLV";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(838, 44);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(86, 31);
            button8.TabIndex = 30;
            button8.Text = "AfisareDGV";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(838, 169);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(86, 31);
            button9.TabIndex = 31;
            button9.Text = "AfisareLV";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button1
            // 
            button1.Location = new Point(744, 291);
            button1.Name = "button1";
            button1.Size = new Size(95, 29);
            button1.TabIndex = 32;
            button1.Text = "TvAdd";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button10
            // 
            button10.Location = new Point(745, 327);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 33;
            button10.Text = "TvAdd";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(743, 369);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 34;
            button11.Text = "TvAdd";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // printDocument2
            // 
            printDocument2.PrintPage += printDocument2_PrintPage;
            // 
            // printPreviewDialog2
            // 
            printPreviewDialog2.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog2.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog2.ClientSize = new Size(400, 300);
            printPreviewDialog2.Enabled = true;
            printPreviewDialog2.Icon = (Icon)resources.GetObject("printPreviewDialog2.Icon");
            printPreviewDialog2.Name = "printPreviewDialog2";
            printPreviewDialog2.Visible = false;
            // 
            // button12
            // 
            button12.Location = new Point(958, 44);
            button12.Name = "button12";
            button12.Size = new Size(106, 29);
            button12.TabIndex = 35;
            button12.Text = "Imprimare";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // printPreviewDialog3
            // 
            printPreviewDialog3.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog3.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog3.ClientSize = new Size(400, 300);
            printPreviewDialog3.Enabled = true;
            printPreviewDialog3.Icon = (Icon)resources.GetObject("printPreviewDialog3.Icon");
            printPreviewDialog3.Name = "printPreviewDialog3";
            printPreviewDialog3.Visible = false;
            // 
            // printDocument3
            // 
            printDocument3.PrintPage += printDocument3_PrintPage;
            // 
            // button13
            // 
            button13.Location = new Point(958, 86);
            button13.Name = "button13";
            button13.Size = new Size(106, 29);
            button13.TabIndex = 36;
            button13.Text = "Imprimare";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 420);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(tbValoare);
            Controls.Add(tbTotal);
            Controls.Add(btnCalculare);
            Controls.Add(tbNou);
            Controls.Add(label4);
            Controls.Add(btnAfisareTB);
            Controls.Add(tbAfisare);
            Controls.Add(btnImprimare);
            Controls.Add(btnAdaugareTV);
            Controls.Add(profesorTV);
            Controls.Add(btnAfiseazaLV);
            Controls.Add(lvProfesori);
            Controls.Add(btnAfisareDGV);
            Controls.Add(DataGridView);
            Controls.Add(btnAdauga);
            Controls.Add(tbSalariu);
            Controls.Add(tbNume);
            Controls.Add(tbMarca);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbMarca;
        private TextBox tbNume;
        private TextBox tbSalariu;
        private Button btnAdauga;
        private DataGridView DataGridView;
        private ErrorProvider errorProvider1;
        private Button btnAfisareDGV;
        private Button btnAfiseazaLV;
        private ListView lvProfesori;
        private ColumnHeader Marca;
        private ColumnHeader Nume;
        private ColumnHeader Salariu;
        private Button btnAdaugareTV;
        private TreeView profesorTV;
        private Button btnImprimare;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private TextBox tbAfisare;
        private Button btnAfisareTB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem afisareToolStripMenuItem;
        private Button btnCalculare;
        private TextBox tbNou;
        private Label label4;
        private TextBox tbTotal;
        private TextBox tbValoare;
        private Button button1;
        private Label label5;
        private ToolStripMenuItem fisierToolStripMenuItem;
        private ToolStripMenuItem textToolStripMenuItem;
        private ToolStripMenuItem salvareToolStripMenuItem1;
        private ToolStripMenuItem restaurareToolStripMenuItem1;
        private ToolStripMenuItem binarToolStripMenuItem;
        private ToolStripMenuItem salvareToolStripMenuItem;
        private ToolStripMenuItem restaurareToolStripMenuItem;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button11;
        private Button button10;
        private Button button12;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private PrintPreviewDialog printPreviewDialog2;
        private Button button13;
        private PrintPreviewDialog printPreviewDialog3;
        private System.Drawing.Printing.PrintDocument printDocument3;
    }
}