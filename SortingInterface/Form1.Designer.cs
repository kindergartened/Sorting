namespace SortingInterface
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
            this.SortDirectionBox = new System.Windows.Forms.ComboBox();
            this.BoxType = new System.Windows.Forms.ComboBox();
            this.BoxSort = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckSortDirectionBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SortDirectionBox
            // 
            this.SortDirectionBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortDirectionBox.FormattingEnabled = true;
            this.SortDirectionBox.Items.AddRange(new object[] {
            "По убыванию",
            "По возрастанию"});
            this.SortDirectionBox.Location = new System.Drawing.Point(290, 183);
            this.SortDirectionBox.Name = "SortDirectionBox";
            this.SortDirectionBox.Size = new System.Drawing.Size(222, 29);
            this.SortDirectionBox.TabIndex = 0;
            this.SortDirectionBox.Text = "Выберите направление сортировки";
            // 
            // BoxType
            // 
            this.BoxType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxType.FormattingEnabled = true;
            this.BoxType.Items.AddRange(new object[] {
            "Строки",
            "Целые числа",
            "Числа с плавающей точкой"});
            this.BoxType.Location = new System.Drawing.Point(37, 119);
            this.BoxType.Name = "BoxType";
            this.BoxType.Size = new System.Drawing.Size(224, 29);
            this.BoxType.TabIndex = 1;
            this.BoxType.Text = "Выберите тип элементов";
            // 
            // BoxSort
            // 
            this.BoxSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BoxSort.FormattingEnabled = true;
            this.BoxSort.Items.AddRange(new object[] {
            "Пузырьковая",
            "Вставками",
            "Слиянием",
            "Быстрая",
            "Пирамидальная"});
            this.BoxSort.Location = new System.Drawing.Point(290, 119);
            this.BoxSort.Name = "BoxSort";
            this.BoxSort.Size = new System.Drawing.Size(223, 29);
            this.BoxSort.TabIndex = 2;
            this.BoxSort.Text = "Выберите сортировку";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(540, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Проверить сортировку";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckSortDirectionBox
            // 
            this.CheckSortDirectionBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckSortDirectionBox.FormattingEnabled = true;
            this.CheckSortDirectionBox.Items.AddRange(new object[] {
            "По убыванию",
            "По возрастанию"});
            this.CheckSortDirectionBox.Location = new System.Drawing.Point(540, 119);
            this.CheckSortDirectionBox.Name = "CheckSortDirectionBox";
            this.CheckSortDirectionBox.Size = new System.Drawing.Size(222, 29);
            this.CheckSortDirectionBox.TabIndex = 4;
            this.CheckSortDirectionBox.Text = "Выберите направление сортировки";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(35, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Сгенерировать массив";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(290, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 41);
            this.button3.TabIndex = 6;
            this.button3.Text = "Отсортировать массив";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(214, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 32);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Работа с массивами";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(37, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Создание массива";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(290, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Сортировка массива";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(540, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(222, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Проверка корректности ";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CountBox
            // 
            this.CountBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountBox.Location = new System.Drawing.Point(37, 183);
            this.CountBox.Name = "CountBox";
            this.CountBox.PlaceholderText = "Количество элементов";
            this.CountBox.Size = new System.Drawing.Size(222, 29);
            this.CountBox.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 319);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(727, 261);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // timer
            // 
            this.timer.Enabled = false;
            this.timer.Location = new System.Drawing.Point(63, 592);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(100, 23);
            this.timer.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(169, 592);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(33, 22);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "мс";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CheckSortDirectionBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoxSort);
            this.Controls.Add(this.BoxType);
            this.Controls.Add(this.SortDirectionBox);
            this.Name = "Form1";
            this.Text = "Sorting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox SortDirectionBox;
        private ComboBox BoxType;
        private ComboBox BoxSort;
        private Button button1;
        private ComboBox CheckSortDirectionBox;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox CountBox;
        private RichTextBox richTextBox1;
        private TextBox timer;
        private TextBox textBox5;
    }
}