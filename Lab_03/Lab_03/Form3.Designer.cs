namespace Lab_02
{
    partial class Form3
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
            this.textBoxRangeOfPages = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYearOfPublishing = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox11 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRangeOfPages
            // 
            this.textBoxRangeOfPages.BackColor = System.Drawing.Color.Salmon;
            this.textBoxRangeOfPages.Location = new System.Drawing.Point(4, 189);
            this.textBoxRangeOfPages.Name = "textBoxRangeOfPages";
            this.textBoxRangeOfPages.Size = new System.Drawing.Size(215, 22);
            this.textBoxRangeOfPages.TabIndex = 65;
            this.textBoxRangeOfPages.TextChanged += new System.EventHandler(this.textBoxRangeOfPages_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(-37, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 29);
            this.label5.TabIndex = 64;
            this.label5.Text = "диапазон";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(243, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 31);
            this.button2.TabIndex = 63;
            this.button2.Text = "поиск";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.Color.Salmon;
            this.textBoxYear.Location = new System.Drawing.Point(4, 88);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(215, 22);
            this.textBoxYear.TabIndex = 62;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // labelYearOfPublishing
            // 
            this.labelYearOfPublishing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYearOfPublishing.Location = new System.Drawing.Point(20, 42);
            this.labelYearOfPublishing.Name = "labelYearOfPublishing";
            this.labelYearOfPublishing.Size = new System.Drawing.Size(189, 29);
            this.labelYearOfPublishing.TabIndex = 61;
            this.labelYearOfPublishing.Text = "год";
            this.labelYearOfPublishing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(243, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 29);
            this.button1.TabIndex = 60;
            this.button1.Text = "поиск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Salmon;
            this.textBox1.Location = new System.Drawing.Point(4, 288);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-37, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 29);
            this.label1.TabIndex = 67;
            this.label1.Text = "издательство";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox11
            // 
            this.listBox11.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listBox11.FormattingEnabled = true;
            this.listBox11.ItemHeight = 16;
            this.listBox11.Location = new System.Drawing.Point(375, 12);
            this.listBox11.Name = "listBox11";
            this.listBox11.Size = new System.Drawing.Size(513, 244);
            this.listBox11.TabIndex = 68;
            this.listBox11.SelectedIndexChanged += new System.EventHandler(this.listBox11_SelectedIndexChanged_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(243, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 31);
            this.button3.TabIndex = 69;
            this.button3.Text = "поиск";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Khaki;
            this.button4.Location = new System.Drawing.Point(24, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 33);
            this.button4.TabIndex = 70;
            this.button4.Text = "вернуться ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Khaki;
            this.button5.Location = new System.Drawing.Point(174, 391);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 33);
            this.button5.TabIndex = 71;
            this.button5.Text = "очистить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(327, 391);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 23);
            this.button6.TabIndex = 72;
            this.button6.Text = "сохранить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxRangeOfPages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYearOfPublishing);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRangeOfPages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYearOfPublishing;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}