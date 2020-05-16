namespace Lab6
{
    partial class LibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            this.all_books = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.au_searchToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tit_searchToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.pub_searchToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоРегулярномуВыражениюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.au_regToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tit_regToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.pub_regToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.au_sortToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tit_sortToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.save_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.drag_tool = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.поискНаПолноеСоответствиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поАвторуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИздательствуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.поискПоРегулярномуВыражениюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поАвторуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поИздательствуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.сортировкаПоToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.авторамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.названиямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.allfiles_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.drag_tool.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // all_books
            // 
            this.all_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.all_books.HideSelection = false;
            this.all_books.Location = new System.Drawing.Point(520, 70);
            this.all_books.Name = "all_books";
            this.all_books.Size = new System.Drawing.Size(317, 405);
            this.all_books.TabIndex = 0;
            this.all_books.TileSize = new System.Drawing.Size(300, 40);
            this.all_books.UseCompatibleStateImageBehavior = false;
            this.all_books.View = System.Windows.Forms.View.Tile;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(516, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Все файлы";
            // 
            // results
            // 
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.results.HideSelection = false;
            this.results.Location = new System.Drawing.Point(44, 180);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(372, 222);
            this.results.TabIndex = 5;
            this.results.TileSize = new System.Drawing.Size(300, 40);
            this.results.UseCompatibleStateImageBehavior = false;
            this.results.View = System.Windows.Forms.View.Tile;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Результаты поиска";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.поискПоРегулярномуВыражениюToolStripMenuItem,
            this.сортировкаПоToolStripMenuItem,
            this.save_ToolStrip,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.au_searchToolStrip,
            this.tit_searchToolStrip,
            this.pub_searchToolStrip});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(189, 20);
            this.поискToolStripMenuItem.Text = "Поиск на полное соответствие";
            // 
            // au_searchToolStrip
            // 
            this.au_searchToolStrip.Name = "au_searchToolStrip";
            this.au_searchToolStrip.Size = new System.Drawing.Size(145, 22);
            this.au_searchToolStrip.Text = "по автору";
            this.au_searchToolStrip.Click += new System.EventHandler(this.au_searchToolStrip_Click);
            // 
            // tit_searchToolStrip
            // 
            this.tit_searchToolStrip.Name = "tit_searchToolStrip";
            this.tit_searchToolStrip.Size = new System.Drawing.Size(145, 22);
            this.tit_searchToolStrip.Text = "по названию";
            this.tit_searchToolStrip.Click += new System.EventHandler(this.tit_searchToolStrip_Click);
            // 
            // pub_searchToolStrip
            // 
            this.pub_searchToolStrip.Name = "pub_searchToolStrip";
            this.pub_searchToolStrip.Size = new System.Drawing.Size(145, 22);
            this.pub_searchToolStrip.Text = "по издателю";
            this.pub_searchToolStrip.Click += new System.EventHandler(this.pub_searchToolStrip_Click);
            // 
            // поискПоРегулярномуВыражениюToolStripMenuItem
            // 
            this.поискПоРегулярномуВыражениюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.au_regToolStrip,
            this.tit_regToolStrip,
            this.pub_regToolStrip});
            this.поискПоРегулярномуВыражениюToolStripMenuItem.Name = "поискПоРегулярномуВыражениюToolStripMenuItem";
            this.поискПоРегулярномуВыражениюToolStripMenuItem.Size = new System.Drawing.Size(217, 20);
            this.поискПоРегулярномуВыражениюToolStripMenuItem.Text = "Поиск по регулярному выражению";
            // 
            // au_regToolStrip
            // 
            this.au_regToolStrip.Name = "au_regToolStrip";
            this.au_regToolStrip.Size = new System.Drawing.Size(162, 22);
            this.au_regToolStrip.Text = "по автору";
            this.au_regToolStrip.Click += new System.EventHandler(this.au_regToolStrip_Click);
            // 
            // tit_regToolStrip
            // 
            this.tit_regToolStrip.Name = "tit_regToolStrip";
            this.tit_regToolStrip.Size = new System.Drawing.Size(162, 22);
            this.tit_regToolStrip.Text = "по названию";
            this.tit_regToolStrip.Click += new System.EventHandler(this.tit_regToolStrip_Click);
            // 
            // pub_regToolStrip
            // 
            this.pub_regToolStrip.Name = "pub_regToolStrip";
            this.pub_regToolStrip.Size = new System.Drawing.Size(162, 22);
            this.pub_regToolStrip.Text = "по издательству";
            this.pub_regToolStrip.Click += new System.EventHandler(this.pub_regToolStrip_Click);
            // 
            // сортировкаПоToolStripMenuItem
            // 
            this.сортировкаПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.au_sortToolStrip,
            this.tit_sortToolStrip});
            this.сортировкаПоToolStripMenuItem.Name = "сортировкаПоToolStripMenuItem";
            this.сортировкаПоToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.сортировкаПоToolStripMenuItem.Text = "Сортировка по";
            // 
            // au_sortToolStrip
            // 
            this.au_sortToolStrip.Name = "au_sortToolStrip";
            this.au_sortToolStrip.Size = new System.Drawing.Size(133, 22);
            this.au_sortToolStrip.Text = "авторам";
            this.au_sortToolStrip.Click += new System.EventHandler(this.au_sortToolStrip_Click);
            // 
            // tit_sortToolStrip
            // 
            this.tit_sortToolStrip.Name = "tit_sortToolStrip";
            this.tit_sortToolStrip.Size = new System.Drawing.Size(133, 22);
            this.tit_sortToolStrip.Text = "названиям";
            this.tit_sortToolStrip.Click += new System.EventHandler(this.tit_sortToolStrip_Click);
            // 
            // save_ToolStrip
            // 
            this.save_ToolStrip.Name = "save_ToolStrip";
            this.save_ToolStrip.Size = new System.Drawing.Size(133, 20);
            this.save_ToolStrip.Text = "Сохранить результат";
            this.save_ToolStrip.Click += new System.EventHandler(this.save_ToolStrip_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(155, 134);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(191, 20);
            this.search_textbox.TabIndex = 11;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(352, 131);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 12;
            this.search.Text = "Найти";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // drag_tool
            // 
            this.drag_tool.AutoSize = false;
            this.drag_tool.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.drag_tool.Dock = System.Windows.Forms.DockStyle.None;
            this.drag_tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripButton1,
            this.toolStripButton2});
            this.drag_tool.Location = new System.Drawing.Point(9, 32);
            this.drag_tool.Name = "drag_tool";
            this.drag_tool.Size = new System.Drawing.Size(253, 25);
            this.drag_tool.TabIndex = 13;
            this.drag_tool.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискНаПолноеСоответствиеToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // поискНаПолноеСоответствиеToolStripMenuItem
            // 
            this.поискНаПолноеСоответствиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поАвторуToolStripMenuItem,
            this.поНазваниюToolStripMenuItem,
            this.поИздательствуToolStripMenuItem});
            this.поискНаПолноеСоответствиеToolStripMenuItem.Name = "поискНаПолноеСоответствиеToolStripMenuItem";
            this.поискНаПолноеСоответствиеToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.поискНаПолноеСоответствиеToolStripMenuItem.Text = "Поиск на полное соответствие";
            // 
            // поАвторуToolStripMenuItem
            // 
            this.поАвторуToolStripMenuItem.Name = "поАвторуToolStripMenuItem";
            this.поАвторуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поАвторуToolStripMenuItem.Text = "по автору";
            this.поАвторуToolStripMenuItem.Click += new System.EventHandler(this.au_searchToolStrip_Click);
            // 
            // поНазваниюToolStripMenuItem
            // 
            this.поНазваниюToolStripMenuItem.Name = "поНазваниюToolStripMenuItem";
            this.поНазваниюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поНазваниюToolStripMenuItem.Text = "по названию";
            this.поНазваниюToolStripMenuItem.Click += new System.EventHandler(this.tit_searchToolStrip_Click);
            // 
            // поИздательствуToolStripMenuItem
            // 
            this.поИздательствуToolStripMenuItem.Name = "поИздательствуToolStripMenuItem";
            this.поИздательствуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поИздательствуToolStripMenuItem.Text = "по издательству";
            this.поИздательствуToolStripMenuItem.Click += new System.EventHandler(this.pub_searchToolStrip_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоРегулярномуВыражениюToolStripMenuItem1});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // поискПоРегулярномуВыражениюToolStripMenuItem1
            // 
            this.поискПоРегулярномуВыражениюToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поАвторуToolStripMenuItem1,
            this.поНазваниюToolStripMenuItem1,
            this.поИздательствуToolStripMenuItem1});
            this.поискПоРегулярномуВыражениюToolStripMenuItem1.Name = "поискПоРегулярномуВыражениюToolStripMenuItem1";
            this.поискПоРегулярномуВыражениюToolStripMenuItem1.Size = new System.Drawing.Size(272, 22);
            this.поискПоРегулярномуВыражениюToolStripMenuItem1.Text = "Поиск по регулярному выражению";
            // 
            // поАвторуToolStripMenuItem1
            // 
            this.поАвторуToolStripMenuItem1.Name = "поАвторуToolStripMenuItem1";
            this.поАвторуToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.поАвторуToolStripMenuItem1.Text = "по автору";
            this.поАвторуToolStripMenuItem1.Click += new System.EventHandler(this.au_regToolStrip_Click);
            // 
            // поНазваниюToolStripMenuItem1
            // 
            this.поНазваниюToolStripMenuItem1.Name = "поНазваниюToolStripMenuItem1";
            this.поНазваниюToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.поНазваниюToolStripMenuItem1.Text = "по названию";
            this.поНазваниюToolStripMenuItem1.Click += new System.EventHandler(this.tit_regToolStrip_Click);
            // 
            // поИздательствуToolStripMenuItem1
            // 
            this.поИздательствуToolStripMenuItem1.Name = "поИздательствуToolStripMenuItem1";
            this.поИздательствуToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.поИздательствуToolStripMenuItem1.Text = "по издательству";
            this.поИздательствуToolStripMenuItem1.Click += new System.EventHandler(this.pub_regToolStrip_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаПоToolStripMenuItem1});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton3.Text = "toolStripDropDownButton3";
            // 
            // сортировкаПоToolStripMenuItem1
            // 
            this.сортировкаПоToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторамToolStripMenuItem,
            this.названиямToolStripMenuItem});
            this.сортировкаПоToolStripMenuItem1.Name = "сортировкаПоToolStripMenuItem1";
            this.сортировкаПоToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.сортировкаПоToolStripMenuItem1.Text = "Сортировка по";
            // 
            // авторамToolStripMenuItem
            // 
            this.авторамToolStripMenuItem.Name = "авторамToolStripMenuItem";
            this.авторамToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.авторамToolStripMenuItem.Text = "авторам";
            this.авторамToolStripMenuItem.Click += new System.EventHandler(this.au_sortToolStrip_Click);
            // 
            // названиямToolStripMenuItem
            // 
            this.названиямToolStripMenuItem.Name = "названиямToolStripMenuItem";
            this.названиямToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.названиямToolStripMenuItem.Text = "названиям";
            this.названиямToolStripMenuItem.Click += new System.EventHandler(this.tit_sortToolStrip_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.save_ToolStrip_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.allfiles_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(878, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // allfiles_label
            // 
            this.allfiles_label.Name = "allfiles_label";
            this.allfiles_label.Size = new System.Drawing.Size(121, 17);
            this.allfiles_label.Text = "Всего в библиотеке: ";
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 487);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.drag_tool);
            this.Controls.Add(this.search);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.all_books);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(894, 526);
            this.Name = "LibraryForm";
            this.Text = "Каталог библиотеки";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.drag_tool.ResumeLayout(false);
            this.drag_tool.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView all_books;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView results;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem au_searchToolStrip;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ToolStripMenuItem tit_searchToolStrip;
        private System.Windows.Forms.ToolStripMenuItem pub_searchToolStrip;
        private System.Windows.Forms.ToolStripMenuItem поискПоРегулярномуВыражениюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem au_regToolStrip;
        private System.Windows.Forms.ToolStripMenuItem tit_regToolStrip;
        private System.Windows.Forms.ToolStripMenuItem pub_regToolStrip;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem au_sortToolStrip;
        private System.Windows.Forms.ToolStripMenuItem tit_sortToolStrip;
        private System.Windows.Forms.ToolStripMenuItem save_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip drag_tool;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem поискНаПолноеСоответствиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поАвторуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИздательствуToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem поискПоРегулярномуВыражениюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поАвторуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поИздательствуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem авторамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem названиямToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel allfiles_label;
    }
}