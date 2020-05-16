namespace Lab5
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
            this.all_books = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.au_str = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.au_search = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.ListView();
            this.formatUpDown = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.format_search = new System.Windows.Forms.Button();
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
            // au_str
            // 
            this.au_str.Location = new System.Drawing.Point(184, 70);
            this.au_str.Name = "au_str";
            this.au_str.Size = new System.Drawing.Size(140, 20);
            this.au_str.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск по автору";
            // 
            // au_search
            // 
            this.au_search.Location = new System.Drawing.Point(352, 68);
            this.au_search.Name = "au_search";
            this.au_search.Size = new System.Drawing.Size(75, 23);
            this.au_search.TabIndex = 4;
            this.au_search.Text = "Найти";
            this.au_search.UseVisualStyleBackColor = true;
            this.au_search.Click += new System.EventHandler(this.au_search_Click);
            // 
            // results
            // 
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.results.HideSelection = false;
            this.results.Location = new System.Drawing.Point(55, 253);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(372, 222);
            this.results.TabIndex = 5;
            this.results.TileSize = new System.Drawing.Size(300, 40);
            this.results.UseCompatibleStateImageBehavior = false;
            this.results.View = System.Windows.Forms.View.Tile;
            // 
            // formatUpDown
            // 
            this.formatUpDown.Items.Add("doc");
            this.formatUpDown.Items.Add("docx");
            this.formatUpDown.Items.Add("txt");
            this.formatUpDown.Items.Add("pdf");
            this.formatUpDown.Items.Add("html");
            this.formatUpDown.Items.Add("rtf");
            this.formatUpDown.Location = new System.Drawing.Point(184, 130);
            this.formatUpDown.Name = "formatUpDown";
            this.formatUpDown.Size = new System.Drawing.Size(140, 20);
            this.formatUpDown.TabIndex = 6;
            this.formatUpDown.Text = "Формат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(52, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Поиск по формату";
            // 
            // format_search
            // 
            this.format_search.Location = new System.Drawing.Point(352, 130);
            this.format_search.Name = "format_search";
            this.format_search.Size = new System.Drawing.Size(75, 23);
            this.format_search.TabIndex = 8;
            this.format_search.Text = "Найти";
            this.format_search.UseVisualStyleBackColor = true;
            this.format_search.Click += new System.EventHandler(this.format_search_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 487);
            this.Controls.Add(this.format_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.formatUpDown);
            this.Controls.Add(this.results);
            this.Controls.Add(this.au_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.au_str);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.all_books);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(894, 526);
            this.Name = "LibraryForm";
            this.Text = "Каталог библиотеки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView all_books;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox au_str;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button au_search;
        private System.Windows.Forms.ListView results;
        private System.Windows.Forms.DomainUpDown formatUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button format_search;
    }
}