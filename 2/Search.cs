using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.IO;


namespace _2
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex r1 = new Regex(textBox1.Text);
            Building building = null;

            XmlSerializer ser = new XmlSerializer(typeof(Building));
            using (FileStream stream = new FileStream("Building.xml", FileMode.Open))
            {
                building = ser.Deserialize(stream) as Building;
            }
            listBox1.Items.Clear();
            List<House> searchResult = new List<House>();
            foreach (House house in building.Houses)
            {
                if (r1.IsMatch(house.Result))
                {
                    if (checkBox1.Checked)
                    {
                        if (textBox2.Text.Length > 0 && textBox2.Text != house.Address.City)
                            continue;
                        if (numericUpDown1.Value != house.Date_built.Year)
                            continue;
                        if (numericUpDown2.Value != house.Rooms)
                            continue;
                    }
                    //listBox1.Items.Add(house.Reault);
                    searchResult.Add(house);
                }
            }
            IEnumerable<House> ordered = null;
            if (domainUpDown1.Text == "По площади")
                ordered = searchResult.OrderBy(p => p.Meter);
            else
                ordered = searchResult.OrderBy(p => p.Price);
            foreach (House item in ordered)
                listBox1.Items.Add(item.Result);

        }
    }
    
}
