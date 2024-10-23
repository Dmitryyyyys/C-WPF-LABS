using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace Lab_02
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();

        [UdcValidation(ErrorMessage = "УДК должен содержать только цифры от 1 до 7.")]
        public string UDC { get; set; }
        //экземпляр второй формы
        public readonly Form2 _authorsForm = new Form2();
        private readonly Form3 _searchForm = new Form3();

        public Form1()
        {
            InitializeComponent();
            //скрытие формы
            _authorsForm.Hide();
            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();

        }

        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            actionUser.Text = DateTime.Now.ToLongTimeString();
        }



       public List<book> books = new List<book>();
        private void MaskedTextBo1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        //для открытия второй формы
        private void button4_Click(object sender, EventArgs e)
        {
            _authorsForm.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Создание списка книг (BookFilesList), взятых из элементов списка listBox11
            var BookFilesList = (from object item in listBox11.Items select item as book).ToList();

            using (var reader = new StreamWriter(@"C:\labs\Обьектно ориентированное программирование\лабораторные\Lab_03\Lab_03\JSON\Lab2.json"))
            {
                string jsonString = JsonConvert.SerializeObject(BookFilesList);
                reader.Write(jsonString);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var BookFilesList = books;
            using (var reader = new StreamReader(@"C:\labs\Обьектно ориентированное программирование\лабораторные\Lab_03\Lab_03\JSON\Lab2.json"))
            {
                BookFilesList = JsonConvert.DeserializeObject<List<book>>(reader.ReadToEnd());
            }

            foreach (var bookFile in BookFilesList)
                listBox11.Items.Add(bookFile.Name+" "+bookFile.Izd + " " +bookFile.Page + " " + bookFile.Format);
            
        }


        private Author.Pages selectedPageSize = Author.Pages.Small;

        public object izd { get; private set; }

        private void HScrollBarSize_Scroll_Scroll(object sender, ScrollEventArgs e)
        {
            var amount = hScrollBarSize_Scroll.Value;
            label6.Text = $"количество страниц: {hScrollBarSize_Scroll.Value}";
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) return;
            e.Handled = true;
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46) return;
            e.Handled = true;
        }



        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void udcMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            int digit = int.Parse(e.KeyChar.ToString());

            if (digit < 1 || digit > 7)
            {
                MessageBox.Show("Цифры должны быть в диапазоне от 1 до 7.");
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (_authorsForm.CurrentAuthorsList == null) return;
            //if (Controls.OfType<RadioButton>().Any(r => r.Checked) == false) return;


            var name = "";
            var izd = textBox3.Text;
            var sizee = 0;
            var page = 0;
            //var numberOfPages = 0;
            var udc = udcMaskedTextBox.Text;
            var format = Format.FB2;
            int year = DateTime.Now.Year;



            try
            {
                if (!Controls.OfType<RadioButton>().Any(r => r.Checked) || textBox2.Text == "" || textBox1.Text == "" || textBox3.Text == "" || udcMaskedTextBox.Text == "")
                    throw new Exception("Заполните поля!");
                if (textBox2.Text.Length > 30 || textBox1.Text.Length > 30 || textBox3.Text.Length > 30)
                    throw new Exception("Превышен размер входных данных");

                name = textBox2.Text;
                sizee = int.Parse(textBox1.Text);
                izd = textBox3.Text;

                //numberOfPages = int.Parse(textBox4.Text);
                udc = udcMaskedTextBox.Text;
                year = dateTimePickerYear.Value.Year;

                var checkedRadioButton = Controls.OfType<RadioButton>().First(r => r.Checked);
                switch (checkedRadioButton.Name)
                {
                    case "radioButton1":
                        format = Format.TXT;
                        break;
                    case "radioButton2":
                        format = Format.PDF;
                        break;
                    case "radioButtonF3":
                        format = Format.FB2;
                        break;
                    case "radioButton4":
                        format = Format.EPUB;
                        break;
                }
                page = hScrollBarSize_Scroll.Value;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Числа великоваты");
                return;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            var authorsList = new List<Author>(_authorsForm.CurrentAuthorsList);
            if (_authorsForm.TextBoxName.Text == "" && _authorsForm.ComboBox1.Text == "" && _authorsForm.TextBoxID.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните информацию об авторе!");
                return;
            }
            var bookFile = new book(format, sizee, name, udc, page, year, izd, _authorsForm.TextBoxName.Text, _authorsForm.ComboBox1.Text, Convert.ToInt32(_authorsForm.TextBoxID.Text));
            listBox11.Items.Add(bookFile);


            
        }

        private object ToString(string text)
        {
            throw new NotImplementedException();
        }



        private void buttonHide_Click(object sender, EventArgs e)
        {
            menuStrip1.Hide();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            menuStrip1.Show();
        }





        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
               _searchForm.Show();
            
            _searchForm.GetBookFilesFromBaseListbox(listBox11.Items);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор : Selekh Dmitriy Sergeevich , Версия : new");
        }

        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedBookFiles = listBox11.Items.OfType<book>().OrderBy(x => x.Name).ToList();
            listBox11.Items.Clear();

            foreach (var sortedBookFile in sortedBookFiles)
            {
                listBox11.Items.Add(sortedBookFile);
            }
        }

        private void поДатеЗагрузкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedBookFiles = listBox11.Items.OfType<book>().OrderBy(x => x.Year).ToList();
            listBox11.Items.Clear();

            foreach (var sortedBookFile in sortedBookFiles)
            {
                listBox11.Items.Add(sortedBookFile);
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox11.Items.Clear();
        }
        private void DeleteInformationFromFile()
        {
            string filePath = @"C:\labs\Обьектно ориентированное программирование\лабораторные\Lab_03\Lab_03\JSON\Lab2.json";

            try
            {
               
                File.WriteAllText(filePath, string.Empty);

                MessageBox.Show("Информация успешно удалена из файла.");
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Ошибка при удалении информации из файла: {ex.Message}");
            }
        }
        private void впередToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (listBox11.Items.Count >= 2)
            {
                listBox11.ClearSelected();
                listBox11.SetSelected(1, true);
            }
        }

        private void назадToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (listBox11.Items.Count >= 1)
            {
                listBox11.ClearSelected();
                listBox11.SetSelected(0, true);
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void удToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DeleteInformationFromFile();
        }
    }
}