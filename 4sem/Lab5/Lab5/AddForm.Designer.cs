namespace Lab5
{
    partial class AddForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.format_help = new System.Windows.Forms.Label();
            this.upload_help = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.size_help = new System.Windows.Forms.Label();
            this.filesize = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.RadioButton();
            this.KB = new System.Windows.Forms.RadioButton();
            this.MB = new System.Windows.Forms.RadioButton();
            this.GB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pages_lable = new System.Windows.Forms.Label();
            this.pages_bar = new System.Windows.Forms.TrackBar();
            this.clean = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.country_help = new System.Windows.Forms.Label();
            this.pub_help = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.TextBox();
            this.auth_help = new System.Windows.Forms.Label();
            this.auth = new System.Windows.Forms.TextBox();
            this.help_title = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.escape = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pages_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.pages_lable);
            this.splitContainer1.Panel1.Controls.Add(this.pages_bar);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.escape);
            this.splitContainer1.Panel2.Controls.Add(this.clean);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.AddBook);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.country_help);
            this.splitContainer1.Panel2.Controls.Add(this.pub_help);
            this.splitContainer1.Panel2.Controls.Add(this.country);
            this.splitContainer1.Panel2.Controls.Add(this.publisher);
            this.splitContainer1.Panel2.Controls.Add(this.auth_help);
            this.splitContainer1.Panel2.Controls.Add(this.auth);
            this.splitContainer1.Panel2.Controls.Add(this.help_title);
            this.splitContainer1.Panel2.Controls.Add(this.title);
            this.splitContainer1.Size = new System.Drawing.Size(878, 487);
            this.splitContainer1.SplitterDistance = 507;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.format_help);
            this.groupBox1.Controls.Add(this.upload_help);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.size_help);
            this.groupBox1.Controls.Add(this.filesize);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Controls.Add(this.KB);
            this.groupBox1.Controls.Add(this.MB);
            this.groupBox1.Controls.Add(this.GB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 279);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о файле";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(202, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата загрузки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Формат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Размер";
            // 
            // format_help
            // 
            this.format_help.ForeColor = System.Drawing.Color.Red;
            this.format_help.Location = new System.Drawing.Point(22, 231);
            this.format_help.Name = "format_help";
            this.format_help.Size = new System.Drawing.Size(165, 23);
            this.format_help.TabIndex = 9;
            // 
            // upload_help
            // 
            this.upload_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upload_help.ForeColor = System.Drawing.Color.Red;
            this.upload_help.Location = new System.Drawing.Point(197, 157);
            this.upload_help.Name = "upload_help";
            this.upload_help.Size = new System.Drawing.Size(200, 23);
            this.upload_help.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "docx",
            "pdf",
            "doc",
            "txt",
            "rtf",
            "html"});
            this.checkedListBox1.Location = new System.Drawing.Point(22, 134);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 6;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // size_help
            // 
            this.size_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size_help.ForeColor = System.Drawing.Color.Red;
            this.size_help.Location = new System.Drawing.Point(162, 52);
            this.size_help.Name = "size_help";
            this.size_help.Size = new System.Drawing.Size(235, 23);
            this.size_help.TabIndex = 5;
            // 
            // filesize
            // 
            this.filesize.Location = new System.Drawing.Point(162, 29);
            this.filesize.Name = "filesize";
            this.filesize.Size = new System.Drawing.Size(65, 20);
            this.filesize.TabIndex = 4;
            this.filesize.TextChanged += new System.EventHandler(this.filesize_TextChanged);
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(366, 29);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(31, 17);
            this.B.TabIndex = 3;
            this.B.Text = "б";
            this.B.UseVisualStyleBackColor = true;
            this.B.CheckedChanged += new System.EventHandler(this.size_format_CheckedChanged);
            // 
            // KB
            // 
            this.KB.AutoSize = true;
            this.KB.Location = new System.Drawing.Point(322, 29);
            this.KB.Name = "KB";
            this.KB.Size = new System.Drawing.Size(38, 17);
            this.KB.TabIndex = 2;
            this.KB.Text = "Кб";
            this.KB.UseVisualStyleBackColor = true;
            this.KB.CheckedChanged += new System.EventHandler(this.size_format_CheckedChanged);
            // 
            // MB
            // 
            this.MB.AutoSize = true;
            this.MB.Location = new System.Drawing.Point(276, 29);
            this.MB.Name = "MB";
            this.MB.Size = new System.Drawing.Size(40, 17);
            this.MB.TabIndex = 1;
            this.MB.Text = "Мб";
            this.MB.UseVisualStyleBackColor = true;
            this.MB.CheckedChanged += new System.EventHandler(this.size_format_CheckedChanged);
            // 
            // GB
            // 
            this.GB.AutoSize = true;
            this.GB.Checked = true;
            this.GB.Location = new System.Drawing.Point(233, 29);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(37, 17);
            this.GB.TabIndex = 0;
            this.GB.TabStop = true;
            this.GB.Text = "Гб";
            this.GB.UseVisualStyleBackColor = true;
            this.GB.CheckedChanged += new System.EventHandler(this.size_format_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Количество страниц";
            // 
            // pages_lable
            // 
            this.pages_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pages_lable.ForeColor = System.Drawing.Color.Black;
            this.pages_lable.Location = new System.Drawing.Point(367, 334);
            this.pages_lable.Name = "pages_lable";
            this.pages_lable.Size = new System.Drawing.Size(62, 23);
            this.pages_lable.TabIndex = 3;
            // 
            // pages_bar
            // 
            this.pages_bar.Location = new System.Drawing.Point(167, 334);
            this.pages_bar.Maximum = 1000;
            this.pages_bar.Minimum = 1;
            this.pages_bar.Name = "pages_bar";
            this.pages_bar.Size = new System.Drawing.Size(194, 45);
            this.pages_bar.TabIndex = 2;
            this.pages_bar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.pages_bar.Value = 1;
            this.pages_bar.Scroll += new System.EventHandler(this.pages_bar_Scroll);
            this.pages_bar.ValueChanged += new System.EventHandler(this.pages_bar_ValueChanged);
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.Color.Orange;
            this.clean.FlatAppearance.BorderSize = 0;
            this.clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clean.Location = new System.Drawing.Point(163, 415);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(93, 37);
            this.clean.TabIndex = 12;
            this.clean.Text = "Сбросить";
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Страна";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(15, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Издательство";
            // 
            // AddBook
            // 
            this.AddBook.BackColor = System.Drawing.Color.Chartreuse;
            this.AddBook.FlatAppearance.BorderSize = 0;
            this.AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBook.Location = new System.Drawing.Point(64, 415);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(93, 37);
            this.AddBook.TabIndex = 4;
            this.AddBook.Text = "Добавить";
            this.AddBook.UseVisualStyleBackColor = false;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название";
            // 
            // country_help
            // 
            this.country_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.country_help.ForeColor = System.Drawing.Color.Red;
            this.country_help.Location = new System.Drawing.Point(146, 195);
            this.country_help.Name = "country_help";
            this.country_help.Size = new System.Drawing.Size(191, 23);
            this.country_help.TabIndex = 3;
            // 
            // pub_help
            // 
            this.pub_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pub_help.ForeColor = System.Drawing.Color.Red;
            this.pub_help.Location = new System.Drawing.Point(149, 294);
            this.pub_help.Name = "pub_help";
            this.pub_help.Size = new System.Drawing.Size(191, 23);
            this.pub_help.TabIndex = 6;
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(146, 172);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(191, 20);
            this.country.TabIndex = 2;
            this.country.TextChanged += new System.EventHandler(this.country_TextChanged);
            // 
            // publisher
            // 
            this.publisher.Location = new System.Drawing.Point(149, 271);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(191, 20);
            this.publisher.TabIndex = 5;
            this.publisher.TextChanged += new System.EventHandler(this.publisher_TextChanged);
            // 
            // auth_help
            // 
            this.auth_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth_help.ForeColor = System.Drawing.Color.Red;
            this.auth_help.Location = new System.Drawing.Point(146, 130);
            this.auth_help.Name = "auth_help";
            this.auth_help.Size = new System.Drawing.Size(191, 23);
            this.auth_help.TabIndex = 1;
            // 
            // auth
            // 
            this.auth.Location = new System.Drawing.Point(146, 107);
            this.auth.Name = "auth";
            this.auth.Size = new System.Drawing.Size(191, 20);
            this.auth.TabIndex = 0;
            this.auth.TextChanged += new System.EventHandler(this.auth_TextChanged);
            // 
            // help_title
            // 
            this.help_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help_title.ForeColor = System.Drawing.Color.Red;
            this.help_title.Location = new System.Drawing.Point(146, 61);
            this.help_title.Name = "help_title";
            this.help_title.Size = new System.Drawing.Size(191, 23);
            this.help_title.TabIndex = 1;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(146, 38);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(191, 20);
            this.title.TabIndex = 0;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // escape
            // 
            this.escape.BackColor = System.Drawing.Color.Tomato;
            this.escape.FlatAppearance.BorderSize = 0;
            this.escape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.escape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.escape.Location = new System.Drawing.Point(262, 415);
            this.escape.Name = "escape";
            this.escape.Size = new System.Drawing.Size(93, 37);
            this.escape.TabIndex = 13;
            this.escape.Text = "Назад";
            this.escape.UseVisualStyleBackColor = false;
            this.escape.Click += new System.EventHandler(this.escape_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 487);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(894, 526);
            this.Name = "AddForm";
            this.Text = "Добавление книги";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pages_bar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label help_title;
        private System.Windows.Forms.TrackBar pages_bar;
        private System.Windows.Forms.Label pages_lable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton GB;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.RadioButton KB;
        private System.Windows.Forms.RadioButton MB;
        private System.Windows.Forms.TextBox filesize;
        private System.Windows.Forms.Label size_help;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label upload_help;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.Label pub_help;
        private System.Windows.Forms.TextBox auth;
        private System.Windows.Forms.Label auth_help;
        private System.Windows.Forms.Label country_help;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Label format_help;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button escape;
    }
}