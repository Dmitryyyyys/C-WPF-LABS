using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_02
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
            CurrentAuthorsList = new List<Author>();
        }
        public new Author.Pages Size { get; set; }

        public List<Author> CurrentAuthorsList { get; private set; }

        public System.Windows.Forms.TextBox TextBoxName => this.textBoxName;
        public System.Windows.Forms.TextBox TextBoxID => this.textBoxID;
        public System.Windows.Forms.ComboBox ComboBox1 => this.comboBox1;

        public Author.Pages S { get; internal set; }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text.Length > 35 || textBoxID.Text.Length > 5 || comboBox1.Text == "")
                    throw new Exception("входные данные должны быть меньше");
                if (textBoxName.Text == "" || textBoxID.Text == "")
                    throw new NullReferenceException();

                string name = textBoxName.Text;
                int id = int.Parse(textBoxID.Text);


                var newAuthor = new Author(name,comboBox1.Text, id);
                CurrentAuthorsList.Add(newAuthor);
                listBox1.Items.Add(newAuthor);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("все заполните");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            CurrentAuthorsList.Clear();
            listBox1.Items.Clear();
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(GroupBox))
                    foreach (Control d in c.Controls)
                        if (d.GetType() == typeof(System.Windows.Forms.TextBox))
                            d.Text = string.Empty;

                if (c.GetType() == typeof(System.Windows.Forms.TextBox))
                    c.Text = string.Empty;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32) return;
            e.Handled = true;
        }

        public void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) return;
            e.Handled = true;
        }

        public void textBoxCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32) return;
            e.Handled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
