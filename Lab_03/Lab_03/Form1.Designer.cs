namespace Lab_02
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox11 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.hScrollBarSize_Scroll = new System.Windows.Forms.HScrollBar();
            this.udcMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.actionUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеЗагрузкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.впередToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "тип (формат)";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(107, 101);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "TXT";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(160, 101);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PDF";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(221, 101);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 20);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "FB2";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(279, 101);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(65, 20);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "EPUB";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "размер файла";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.textBox1.Location = new System.Drawing.Point(117, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.YellowGreen;
            this.textBox2.Location = new System.Drawing.Point(137, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "название файла";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "УДК";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "дата выпуска";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(12, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Location = new System.Drawing.Point(96, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "загрузить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.Location = new System.Drawing.Point(183, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "добавить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox11
            // 
            this.listBox11.BackColor = System.Drawing.Color.YellowGreen;
            this.listBox11.FormattingEnabled = true;
            this.listBox11.ItemHeight = 16;
            this.listBox11.Location = new System.Drawing.Point(12, 338);
            this.listBox11.Name = "listBox11";
            this.listBox11.Size = new System.Drawing.Size(471, 164);
            this.listBox11.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.YellowGreen;
            this.button4.Location = new System.Drawing.Point(557, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(219, 212);
            this.button4.TabIndex = 17;
            this.button4.Text = "авторы";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CalendarForeColor = System.Drawing.Color.Green;
            this.dateTimePickerYear.CalendarMonthBackground = System.Drawing.Color.Green;
            this.dateTimePickerYear.CalendarTitleBackColor = System.Drawing.Color.Green;
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerYear.Location = new System.Drawing.Point(137, 204);
            this.dateTimePickerYear.MaxDate = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            this.dateTimePickerYear.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.ShowUpDown = true;
            this.dateTimePickerYear.Size = new System.Drawing.Size(73, 22);
            this.dateTimePickerYear.TabIndex = 20;
            this.dateTimePickerYear.Value = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "количество страниц";
            // 
            // hScrollBarSize_Scroll
            // 
            this.hScrollBarSize_Scroll.Location = new System.Drawing.Point(457, 205);
            this.hScrollBarSize_Scroll.Name = "hScrollBarSize_Scroll";
            this.hScrollBarSize_Scroll.Size = new System.Drawing.Size(334, 21);
            this.hScrollBarSize_Scroll.TabIndex = 23;
            this.hScrollBarSize_Scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBarSize_Scroll_Scroll);
            // 
            // udcMaskedTextBox
            // 
            this.udcMaskedTextBox.Location = new System.Drawing.Point(61, 259);
            this.udcMaskedTextBox.Mask = "00-00";
            this.udcMaskedTextBox.Name = "udcMaskedTextBox";
            this.udcMaskedTextBox.Size = new System.Drawing.Size(125, 22);
            this.udcMaskedTextBox.TabIndex = 24;
            this.udcMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.udcMaskedTextBox_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateLabel,
            this.toolStripStatusLabel2,
            this.actionUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 507);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 38;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dateLabel
            // 
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(82, 20);
            this.dateLabel.Text = "StatusTime";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(70, 20);
            this.toolStripStatusLabel2.Text = "Активно:";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // actionUser
            // 
            this.actionUser.Name = "actionUser";
            this.actionUser.Size = new System.Drawing.Size(107, 20);
            this.actionUser.Text = "toolStripStatus";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.удToolStripMenuItem,
            this.впередToolStripMenuItem,
            this.назадToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.поискToolStripMenuItem.Text = "поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНазваниюToolStripMenuItem,
            this.поДатеЗагрузкиToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.сортировкаToolStripMenuItem.Text = "сортировка";
            this.сортировкаToolStripMenuItem.Click += new System.EventHandler(this.сортировкаToolStripMenuItem_Click);
            // 
            // поНазваниюToolStripMenuItem
            // 
            this.поНазваниюToolStripMenuItem.Name = "поНазваниюToolStripMenuItem";
            this.поНазваниюToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.поНазваниюToolStripMenuItem.Text = "по названию";
            this.поНазваниюToolStripMenuItem.Click += new System.EventHandler(this.поНазваниюToolStripMenuItem_Click);
            // 
            // поДатеЗагрузкиToolStripMenuItem
            // 
            this.поДатеЗагрузкиToolStripMenuItem.Name = "поДатеЗагрузкиToolStripMenuItem";
            this.поДатеЗагрузкиToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.поДатеЗагрузкиToolStripMenuItem.Text = "по дате загрузки";
            this.поДатеЗагрузкиToolStripMenuItem.Click += new System.EventHandler(this.поДатеЗагрузкиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = "о программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.очиститьToolStripMenuItem.Text = "очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // удToolStripMenuItem
            // 
            this.удToolStripMenuItem.Name = "удToolStripMenuItem";
            this.удToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.удToolStripMenuItem.Text = "удалить";
            this.удToolStripMenuItem.Click += new System.EventHandler(this.удToolStripMenuItem_Click_1);
            // 
            // впередToolStripMenuItem
            // 
            this.впередToolStripMenuItem.Name = "впередToolStripMenuItem";
            this.впередToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.впередToolStripMenuItem.Text = "вперед";
            this.впередToolStripMenuItem.Click += new System.EventHandler(this.впередToolStripMenuItem_Click_1);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.назадToolStripMenuItem.Text = "назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click_1);
            // 
            // buttonHide
            // 
            this.buttonHide.Location = new System.Drawing.Point(507, 41);
            this.buttonHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(100, 26);
            this.buttonHide.TabIndex = 40;
            this.buttonHide.Text = "скрыть";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(628, 41);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(96, 26);
            this.buttonShow.TabIndex = 41;
            this.buttonShow.Text = "закрепить";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "издательство";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.YellowGreen;
            this.textBox3.Location = new System.Drawing.Point(425, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.udcMaskedTextBox);
            this.Controls.Add(this.hScrollBarSize_Scroll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerYear);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HScrollBar hScrollBarSize_Scroll;
        private System.Windows.Forms.MaskedTextBox udcMaskedTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel dateLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel actionUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem впередToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДатеЗагрузкиToolStripMenuItem;
    }
}

