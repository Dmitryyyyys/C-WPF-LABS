using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace _2
{
    public partial class Form1 : Form
    {
        public Building building;
        public Form1()
        {
            InitializeComponent();
            building = new Building();
        }

        private void button1_Click(object sender, EventArgs e)  ///ДОБАВИТЬ
        {
            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("Введите метраж квартиры!!!");
                return;
            }
            if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Выберите материал!!!");
                return;
            }
            if (textBox3.Text.Equals("") || textBox4.Text.Equals("") || textBox5.Text.Equals("")
                || textBox6.Text.Equals("") || textBox7.Text.Equals(""))
            {
                MessageBox.Show("Все поля адреса квартиры должны быть заполнены!");
                return;
            }

            House currentHouse = new House
            {
                Meter = Int32.Parse(textBox2.Text),
                Material = comboBox1.Text,
                Date_built = dateTimePicker1.Value,
                Floor = trackBar1.Value,
                Rooms = numericUpDown1.Value,
                Address = new Address
                {
                    Country = textBox3.Text,
                    City = textBox4.Text,
                    Street = textBox5.Text,
                    Home = Int32.Parse(textBox6.Text),
                    Apartment = Int32.Parse(textBox7.Text)
                }
            };
            currentHouse.Price = Decimal.ToInt32(currentHouse.Rooms) * 10000 - currentHouse.Floor * 54;
            building.Houses.Add(currentHouse);
            currentHouse.Result = currentHouse.Address.Street + ": " + currentHouse.Rooms + "-комн., " +
                currentHouse.Floor + " этаж, " + currentHouse.Material + ", " +
                currentHouse.Meter + " кв.м";
            if (checkBox1.Checked) currentHouse.Result += " + кухня";
            if (checkBox2.Checked) currentHouse.Result += " + ванная";
            if (checkBox3.Checked) currentHouse.Result += " + балкон";
            if (checkBox4.Checked) currentHouse.Result += " + туалет";
            listBox1.Items.Add(currentHouse.Result);
            listBox1.Items.Add("\r\nЦена: " + currentHouse.Price + " $");
        }

        private void button2_Click(object sender, EventArgs e)      ///СОХРАНИТЬ
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Building));
            using (FileStream stream = new FileStream("Building.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, building);
            }
        }

        private void button3_Click(object sender, EventArgs e)      ///ОТКРЫТЬ
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Building));
            using (FileStream stream = new FileStream("Building.xml", FileMode.Open))
            {
                building = serializer.Deserialize(stream) as Building;
            }
            foreach(House house in building.Houses)
                listBox1.Items.Add(house.Result);
        }

        #region бред
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) ///ТИП МАТЕРИАЛА
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)    ///КОЛИЧЕСТВО КОМНАТ
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)   ///МЕТРАЖ
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)   ///ЭТАЖ
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)   ///ГОД ПОСТРОЙКИ
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)   ///кухня
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)   ///туалет
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)   ///ванная
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)   ///балкон
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)  ///ОКНО ВЫВОДА
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)   ///СТРАНА
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)   ///ГОРОД
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)   ///УЛИЦА
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)   ///ДОМ
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)   ///НОМЕР КВАРТИРЫ
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void сортироватьПоToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик - Селех Дмитрий Сергеевич");
        }


        private void площадьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlSerializer ser = new XmlSerializer(typeof(Building));
            using (FileStream stream = new FileStream("Building.xml", FileMode.Open))
                building = ser.Deserialize(stream) as Building;

            IEnumerable<House> ordered = building.Houses.OrderBy(p => p.Meter);
            foreach (House house in ordered)
                listBox1.Items.Add(house.Result);
        }

        private void ценаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlSerializer ser = new XmlSerializer(typeof(Building));
            using (FileStream stream = new FileStream("Building.xml", FileMode.Open))
                building = ser.Deserialize(stream) as Building;

            IEnumerable<House> ordered = building.Houses.OrderBy(p => p.Price);
            foreach (House house in ordered)
                listBox1.Items.Add(house.Result);
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog(this);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            button3_Click(null, null);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            button2_Click(null, null);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Текущее время - " + DateTime.Now.ToString();
        }
    }
}
