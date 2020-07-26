namespace REA_Testing
{
    partial class Form1
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
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.next_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupNumber_textbox = new System.Windows.Forms.TextBox();
            this.faculty_textbox = new System.Windows.Forms.TextBox();
            this.group_label = new System.Windows.Forms.Label();
            this.faculty_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.date_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(99, 130);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(510, 20);
            this.name_textbox.TabIndex = 0;
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(492, 310);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(153, 23);
            this.next_button.TabIndex = 1;
            this.next_button.Text = "Далее";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(243, 159);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(189, 45);
            this.save_button.TabIndex = 2;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тест по предмету \"Комплексный анализ\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Полный номер группы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(405, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Факультет";
            // 
            // groupNumber_textbox
            // 
            this.groupNumber_textbox.Location = new System.Drawing.Point(219, 90);
            this.groupNumber_textbox.Name = "groupNumber_textbox";
            this.groupNumber_textbox.Size = new System.Drawing.Size(147, 20);
            this.groupNumber_textbox.TabIndex = 7;
            // 
            // faculty_textbox
            // 
            this.faculty_textbox.Location = new System.Drawing.Point(494, 89);
            this.faculty_textbox.Name = "faculty_textbox";
            this.faculty_textbox.Size = new System.Drawing.Size(115, 20);
            this.faculty_textbox.TabIndex = 8;
            // 
            // group_label
            // 
            this.group_label.AutoSize = true;
            this.group_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_label.Location = new System.Drawing.Point(49, 250);
            this.group_label.Name = "group_label";
            this.group_label.Size = new System.Drawing.Size(56, 18);
            this.group_label.TabIndex = 9;
            this.group_label.Text = "Группа";
            // 
            // faculty_label
            // 
            this.faculty_label.AutoSize = true;
            this.faculty_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.faculty_label.Location = new System.Drawing.Point(48, 279);
            this.faculty_label.Name = "faculty_label";
            this.faculty_label.Size = new System.Drawing.Size(83, 18);
            this.faculty_label.TabIndex = 10;
            this.faculty_label.Text = "Факультет";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(48, 306);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(44, 18);
            this.name_label.TabIndex = 11;
            this.name_label.Text = "ФИО";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(49, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Проверьте ваши данные:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_label.Location = new System.Drawing.Point(258, 49);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(80, 18);
            this.date_label.TabIndex = 13;
            this.date_label.Text = "01.01.2019";
            // 
            // Form1
            // 
            this.AcceptButton = this.next_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 345);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.faculty_label);
            this.Controls.Add(this.group_label);
            this.Controls.Add(this.faculty_textbox);
            this.Controls.Add(this.groupNumber_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.name_textbox);
            this.Name = "Form1";
            this.Text = "Комплексный анализ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox groupNumber_textbox;
        private System.Windows.Forms.TextBox faculty_textbox;
        private System.Windows.Forms.Label group_label;
        private System.Windows.Forms.Label faculty_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label5;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label date_label;
    }
}

