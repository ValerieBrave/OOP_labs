namespace Lab4
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
            this.label1 = new System.Windows.Forms.Label();
            this.col_size = new System.Windows.Forms.TextBox();
            this.size_message = new System.Windows.Forms.Label();
            this.collection_basic = new System.Windows.Forms.ListView();
            this.sortAsc = new System.Windows.Forms.Button();
            this.sorted_col = new System.Windows.Forms.ListView();
            this.age_sort = new System.Windows.Forms.Button();
            this.newEmps = new System.Windows.Forms.Button();
            this.experts = new System.Windows.Forms.Button();
            this.youngsters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(378, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сгенерировать коллекцию";
            // 
            // col_size
            // 
            this.col_size.Location = new System.Drawing.Point(381, 32);
            this.col_size.Name = "col_size";
            this.col_size.Size = new System.Drawing.Size(135, 20);
            this.col_size.TabIndex = 1;
            this.col_size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.size_input);
            // 
            // size_message
            // 
            this.size_message.Location = new System.Drawing.Point(381, 55);
            this.size_message.Name = "size_message";
            this.size_message.Size = new System.Drawing.Size(135, 21);
            this.size_message.TabIndex = 2;
            // 
            // collection_basic
            // 
            this.collection_basic.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.collection_basic.HideSelection = false;
            this.collection_basic.Location = new System.Drawing.Point(12, 217);
            this.collection_basic.Name = "collection_basic";
            this.collection_basic.Size = new System.Drawing.Size(237, 194);
            this.collection_basic.TabIndex = 3;
            this.collection_basic.UseCompatibleStateImageBehavior = false;
            this.collection_basic.View = System.Windows.Forms.View.List;
            // 
            // sortAsc
            // 
            this.sortAsc.Location = new System.Drawing.Point(51, 128);
            this.sortAsc.Name = "sortAsc";
            this.sortAsc.Size = new System.Drawing.Size(141, 58);
            this.sortAsc.TabIndex = 4;
            this.sortAsc.Text = "Сортировать по возрастанию стажа";
            this.sortAsc.UseVisualStyleBackColor = true;
            this.sortAsc.Click += new System.EventHandler(this.sortAsc_Click);
            // 
            // sorted_col
            // 
            this.sorted_col.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.sorted_col.HideSelection = false;
            this.sorted_col.Location = new System.Drawing.Point(628, 217);
            this.sorted_col.Name = "sorted_col";
            this.sorted_col.Size = new System.Drawing.Size(229, 194);
            this.sorted_col.TabIndex = 5;
            this.sorted_col.UseCompatibleStateImageBehavior = false;
            this.sorted_col.View = System.Windows.Forms.View.List;
            // 
            // age_sort
            // 
            this.age_sort.Location = new System.Drawing.Point(660, 128);
            this.age_sort.Name = "age_sort";
            this.age_sort.Size = new System.Drawing.Size(157, 58);
            this.age_sort.TabIndex = 6;
            this.age_sort.Text = "Сортировать по убыванию возраста";
            this.age_sort.UseVisualStyleBackColor = true;
            this.age_sort.Click += new System.EventHandler(this.age_sort_Click);
            // 
            // newEmps
            // 
            this.newEmps.Location = new System.Drawing.Point(276, 182);
            this.newEmps.Name = "newEmps";
            this.newEmps.Size = new System.Drawing.Size(75, 23);
            this.newEmps.TabIndex = 7;
            this.newEmps.Text = "Новенькие";
            this.newEmps.UseVisualStyleBackColor = true;
            this.newEmps.Click += new System.EventHandler(this.newEmps_Click);
            // 
            // experts
            // 
            this.experts.Location = new System.Drawing.Point(381, 173);
            this.experts.Name = "experts";
            this.experts.Size = new System.Drawing.Size(75, 62);
            this.experts.TabIndex = 8;
            this.experts.Text = "Без пяти минут ветераны фирмы";
            this.experts.UseVisualStyleBackColor = true;
            this.experts.Click += new System.EventHandler(this.experts_Click);
            // 
            // youngsters
            // 
            this.youngsters.Location = new System.Drawing.Point(486, 182);
            this.youngsters.Name = "youngsters";
            this.youngsters.Size = new System.Drawing.Size(75, 23);
            this.youngsters.TabIndex = 9;
            this.youngsters.Text = "Молодежь";
            this.youngsters.UseVisualStyleBackColor = true;
            this.youngsters.Click += new System.EventHandler(this.youngsters_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 439);
            this.Controls.Add(this.youngsters);
            this.Controls.Add(this.experts);
            this.Controls.Add(this.newEmps);
            this.Controls.Add(this.age_sort);
            this.Controls.Add(this.sorted_col);
            this.Controls.Add(this.sortAsc);
            this.Controls.Add(this.collection_basic);
            this.Controls.Add(this.size_message);
            this.Controls.Add(this.col_size);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox col_size;
        private System.Windows.Forms.Label size_message;
        private System.Windows.Forms.ListView collection_basic;
        private System.Windows.Forms.Button sortAsc;
        private System.Windows.Forms.ListView sorted_col;
        private System.Windows.Forms.Button age_sort;
        private System.Windows.Forms.Button newEmps;
        private System.Windows.Forms.Button experts;
        private System.Windows.Forms.Button youngsters;
    }
}