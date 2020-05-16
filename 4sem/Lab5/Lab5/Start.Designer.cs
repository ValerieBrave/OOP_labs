namespace Lab5
{
    partial class Start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AddForm = new System.Windows.Forms.Button();
            this.ShowLib = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(343, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Электронная библиотека";
            // 
            // AddForm
            // 
            this.AddForm.Location = new System.Drawing.Point(252, 200);
            this.AddForm.Name = "AddForm";
            this.AddForm.Size = new System.Drawing.Size(119, 23);
            this.AddForm.TabIndex = 1;
            this.AddForm.Text = "Добавить книгу";
            this.AddForm.UseVisualStyleBackColor = true;
            this.AddForm.Click += new System.EventHandler(this.AddForm_Click);
            // 
            // ShowLib
            // 
            this.ShowLib.Location = new System.Drawing.Point(438, 200);
            this.ShowLib.Name = "ShowLib";
            this.ShowLib.Size = new System.Drawing.Size(119, 23);
            this.ShowLib.TabIndex = 2;
            this.ShowLib.Text = "Библиотека";
            this.ShowLib.UseVisualStyleBackColor = true;
            this.ShowLib.Click += new System.EventHandler(this.ShowLib_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 487);
            this.Controls.Add(this.ShowLib);
            this.Controls.Add(this.AddForm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(894, 526);
            this.Name = "Start";
            this.Text = "Электронная библиотека";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddForm;
        private System.Windows.Forms.Button ShowLib;
    }
}

