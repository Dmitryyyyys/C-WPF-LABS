using Lab_02;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class Form3 : Form
    {
        private void SaveSearchResultsToJson(int year, List<book> searchResults)
        {
            try
            {
                // Создаем объект для сохранения
                var searchData = new Dictionary<int, List<book>>();

                // Добавляем в словарь год и соответствующие ему результаты поиска
                searchData.Add(year, searchResults);

                // Сериализуем объект в JSON строку
                string json = JsonConvert.SerializeObject(searchData);

                // Указываем путь и имя файла для сохранения
                string filePath = @"C:\labs\Обьектно ориентированное программирование\лабораторные\Lab_03\Lab_03\JSON\Lab2.json";

                // Записываем JSON строку в файл
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении результатов поиска: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

    private readonly List<book> _bookFiles = new List<book>();
        public Form3()
        {
            InitializeComponent();
        }
        public void GetBookFilesFromBaseListbox(ListBox.ObjectCollection items)
        {
            _bookFiles.Clear();
            foreach (object item in items) _bookFiles.Add(item as book);
        }



        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            (sender as Form3).Hide();
        }


        private void listBox11_SelectedIndexChanged(object sender, EventArgs e)
        {


            var selectedBookFile = ((ListBox)sender).SelectedItem as Form3;

            if (selectedBookFile == null) return;


            //foreach (var author in selectedBookFile.Authors) textBoxAuthors.Text += author + Environment.NewLine;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) return;
            e.Handled = true;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        internal static void GetBookFilesFromBaseListbox(object items)
        {
            throw new NotImplementedException();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxYear.Text == "") return;
            listBox11.Items.Clear();

            int year = int.Parse(textBoxYear.Text);

            foreach (var bookFile in _bookFiles.Where(bookFile => bookFile.Year == year))
            {
                listBox11.Items.Add(bookFile);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBoxRangeOfPages.Text == "") return;
            var regex = new Regex(@"^(\d+)-(\d+)$");
            if (regex.IsMatch(textBoxRangeOfPages.Text) == false)
            {
                MessageBox.Show("Неправильный формат ввода диапазона");
                return;
            }
            listBox11.Items.Clear();
            var separatedNumbers = textBoxRangeOfPages.Text.Split('-');
            var firstNumber = int.Parse(separatedNumbers[0]);
            var secondNumber = int.Parse(separatedNumbers[1]);

            foreach (var bookFile in _bookFiles.Where(bookFile => bookFile.Page >= firstNumber && bookFile.Page <= secondNumber))
            {
                listBox11.Items.Add(bookFile);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string izd = textBox1.Text;

            listBox11.Items.Clear();

            List<book> searchedBooks = _bookFiles.Where(account => Regex.IsMatch(account.Izd, $@"{izd}\w*", RegexOptions.IgnoreCase)).ToList();
            foreach (book account in searchedBooks)
            {
                listBox11.Items.Add(account.ToString());
            }
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void listBox11_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox11.Items.Clear();
        }

        private void textBoxRangeOfPages_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxYear.Text == "")
                {
                    MessageBox.Show("Введите год для сохранения поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int year = int.Parse(textBoxYear.Text);

                var searchResults = _bookFiles.FindAll(book => book.Year == year);

                SaveSearchResultsToJson(year, searchResults);

                MessageBox.Show($"Результаты поиска за {year} год успешно сохранены в файл JSON.", "Сохранение завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении результатов поиска: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
