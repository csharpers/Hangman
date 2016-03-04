namespace Hangman
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.generalPanel = new System.Windows.Forms.TableLayoutPanel();
            this.topMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.novaIgraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hangmanPanel = new System.Windows.Forms.TableLayoutPanel();
            this.slika = new System.Windows.Forms.PictureBox();
            this.wordPanel = new System.Windows.Forms.TableLayoutPanel();
            this.film = new System.Windows.Forms.Label();
            this.keyboardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.generalPanel.SuspendLayout();
            this.topMenu.SuspendLayout();
            this.hangmanPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slika)).BeginInit();
            this.wordPanel.SuspendLayout();
            this.keyboardPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalPanel
            // 
            this.generalPanel.ColumnCount = 1;
            this.generalPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalPanel.Controls.Add(this.topMenu, 0, 0);
            this.generalPanel.Controls.Add(this.hangmanPanel, 0, 1);
            this.generalPanel.Controls.Add(this.keyboardPanel, 0, 2);
            this.generalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalPanel.Location = new System.Drawing.Point(0, 0);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.RowCount = 3;
            this.generalPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.361323F));
            this.generalPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.63868F));
            this.generalPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.generalPanel.Size = new System.Drawing.Size(952, 561);
            this.generalPanel.TabIndex = 0;
            // 
            // topMenu
            // 
            this.topMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.topMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.topMenu.Size = new System.Drawing.Size(952, 22);
            this.topMenu.TabIndex = 0;
            this.topMenu.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaIgraToolStripMenuItem,
            this.rangListaToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(40, 19);
            this.toolStripDropDownButton1.Text = "Igra";
            // 
            // novaIgraToolStripMenuItem
            // 
            this.novaIgraToolStripMenuItem.Name = "novaIgraToolStripMenuItem";
            this.novaIgraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novaIgraToolStripMenuItem.Text = "Nova igra";
            this.novaIgraToolStripMenuItem.Click += new System.EventHandler(this.novaIgraToolStripMenuItem_Click);
            // 
            // rangListaToolStripMenuItem
            // 
            this.rangListaToolStripMenuItem.Name = "rangListaToolStripMenuItem";
            this.rangListaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rangListaToolStripMenuItem.Text = "Rang lista";
            // 
            // hangmanPanel
            // 
            this.hangmanPanel.ColumnCount = 2;
            this.hangmanPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.25581F));
            this.hangmanPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.74419F));
            this.hangmanPanel.Controls.Add(this.slika, 0, 0);
            this.hangmanPanel.Controls.Add(this.wordPanel, 1, 0);
            this.hangmanPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hangmanPanel.Location = new System.Drawing.Point(3, 25);
            this.hangmanPanel.Name = "hangmanPanel";
            this.hangmanPanel.RowCount = 1;
            this.hangmanPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.hangmanPanel.Size = new System.Drawing.Size(946, 323);
            this.hangmanPanel.TabIndex = 1;
            // 
            // slika
            // 
            this.slika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slika.Image = global::Hangman.Properties.Resources._0;
            this.slika.InitialImage = null;
            this.slika.Location = new System.Drawing.Point(24, 18);
            this.slika.Name = "slika";
            this.slika.Size = new System.Drawing.Size(170, 286);
            this.slika.TabIndex = 0;
            this.slika.TabStop = false;
            // 
            // wordPanel
            // 
            this.wordPanel.ColumnCount = 1;
            this.wordPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.wordPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.wordPanel.Controls.Add(this.film, 0, 1);
            this.wordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordPanel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordPanel.Location = new System.Drawing.Point(222, 3);
            this.wordPanel.Name = "wordPanel";
            this.wordPanel.RowCount = 3;
            this.wordPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.76303F));
            this.wordPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.23697F));
            this.wordPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.wordPanel.Size = new System.Drawing.Size(721, 317);
            this.wordPanel.TabIndex = 1;
            // 
            // film
            // 
            this.film.AutoSize = true;
            this.film.Dock = System.Windows.Forms.DockStyle.Fill;
            this.film.Location = new System.Drawing.Point(3, 92);
            this.film.Name = "film";
            this.film.Size = new System.Drawing.Size(715, 92);
            this.film.TabIndex = 0;
            this.film.Text = "NAZIV FILMA";
            this.film.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyboardPanel
            // 
            this.keyboardPanel.ColumnCount = 1;
            this.keyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.keyboardPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.keyboardPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.keyboardPanel.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.keyboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyboardPanel.Location = new System.Drawing.Point(3, 354);
            this.keyboardPanel.Name = "keyboardPanel";
            this.keyboardPanel.RowCount = 3;
            this.keyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.keyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.keyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.keyboardPanel.Size = new System.Drawing.Size(946, 204);
            this.keyboardPanel.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.button11, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button12, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button13, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button14, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button15, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.button16, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.button17, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.button18, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.button19, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.button20, 9, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(940, 52);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(3, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(88, 30);
            this.button11.TabIndex = 0;
            this.button11.Text = "H";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(97, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(88, 30);
            this.button12.TabIndex = 1;
            this.button12.Text = "I";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(191, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(88, 30);
            this.button13.TabIndex = 2;
            this.button13.Text = "J";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_Click);
            // 
            // button14
            // 
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.Dock = System.Windows.Forms.DockStyle.Top;
            this.button14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(285, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(88, 30);
            this.button14.TabIndex = 3;
            this.button14.Text = "K";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_Click);
            // 
            // button15
            // 
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.Dock = System.Windows.Forms.DockStyle.Top;
            this.button15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(379, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(88, 30);
            this.button15.TabIndex = 4;
            this.button15.Text = "L";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button_Click);
            // 
            // button16
            // 
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.Dock = System.Windows.Forms.DockStyle.Top;
            this.button16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(473, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(88, 30);
            this.button16.TabIndex = 5;
            this.button16.Text = "M";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button_Click);
            // 
            // button17
            // 
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.Dock = System.Windows.Forms.DockStyle.Top;
            this.button17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(567, 3);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(88, 30);
            this.button17.TabIndex = 6;
            this.button17.Text = "N";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button_Click);
            // 
            // button18
            // 
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.Dock = System.Windows.Forms.DockStyle.Top;
            this.button18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(661, 3);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(88, 30);
            this.button18.TabIndex = 7;
            this.button18.Text = "O";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button_Click);
            // 
            // button19
            // 
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.Dock = System.Windows.Forms.DockStyle.Top;
            this.button19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(755, 3);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(88, 30);
            this.button19.TabIndex = 8;
            this.button19.Text = "P";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button_Click);
            // 
            // button20
            // 
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.Dock = System.Windows.Forms.DockStyle.Top;
            this.button20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(849, 3);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(88, 30);
            this.button20.TabIndex = 9;
            this.button20.Text = "R";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.button7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.button8, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.button9, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.button10, 9, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(97, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(191, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(285, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "Č";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(379, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "Ć";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(473, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 30);
            this.button6.TabIndex = 5;
            this.button6.Text = "D";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(567, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 30);
            this.button7.TabIndex = 6;
            this.button7.Text = "Đ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(661, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 30);
            this.button8.TabIndex = 7;
            this.button8.Text = "E";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(755, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 30);
            this.button9.TabIndex = 8;
            this.button9.Text = "F";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(849, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(88, 30);
            this.button10.TabIndex = 9;
            this.button10.Text = "G";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 9;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.Controls.Add(this.button21, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button22, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button23, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.button24, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.button25, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.button26, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.button27, 7, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 115);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(940, 86);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // button21
            // 
            this.button21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button21.Dock = System.Windows.Forms.DockStyle.Top;
            this.button21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(107, 3);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(98, 30);
            this.button21.TabIndex = 0;
            this.button21.Text = "S";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button_Click);
            // 
            // button22
            // 
            this.button22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button22.Dock = System.Windows.Forms.DockStyle.Top;
            this.button22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(211, 3);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(98, 30);
            this.button22.TabIndex = 1;
            this.button22.Text = "Š";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button_Click);
            // 
            // button23
            // 
            this.button23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button23.Dock = System.Windows.Forms.DockStyle.Top;
            this.button23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(315, 3);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(98, 30);
            this.button23.TabIndex = 2;
            this.button23.Text = "T";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button_Click);
            // 
            // button24
            // 
            this.button24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button24.Dock = System.Windows.Forms.DockStyle.Top;
            this.button24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(419, 3);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(98, 30);
            this.button24.TabIndex = 3;
            this.button24.Text = "U";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button_Click);
            // 
            // button25
            // 
            this.button25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button25.Dock = System.Windows.Forms.DockStyle.Top;
            this.button25.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(523, 3);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(98, 30);
            this.button25.TabIndex = 4;
            this.button25.Text = "V";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button_Click);
            // 
            // button26
            // 
            this.button26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button26.Dock = System.Windows.Forms.DockStyle.Top;
            this.button26.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(627, 3);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(98, 30);
            this.button26.TabIndex = 5;
            this.button26.Text = "Z";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button_Click);
            // 
            // button27
            // 
            this.button27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button27.Dock = System.Windows.Forms.DockStyle.Top;
            this.button27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(731, 3);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(98, 30);
            this.button27.TabIndex = 6;
            this.button27.Text = "Ž";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 561);
            this.Controls.Add(this.generalPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.ShowIcon = false;
            this.Text = "Hangman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.generalPanel.ResumeLayout(false);
            this.generalPanel.PerformLayout();
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.hangmanPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slika)).EndInit();
            this.wordPanel.ResumeLayout(false);
            this.wordPanel.PerformLayout();
            this.keyboardPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel generalPanel;
        private System.Windows.Forms.ToolStrip topMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem novaIgraToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel hangmanPanel;
        private System.Windows.Forms.PictureBox slika;
        private System.Windows.Forms.TableLayoutPanel keyboardPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.TableLayoutPanel wordPanel;
        private System.Windows.Forms.Label film;
        private System.Windows.Forms.ToolStripMenuItem rangListaToolStripMenuItem;
    }
}

