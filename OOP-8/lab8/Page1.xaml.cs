using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab8
{
    public partial class Page1 : Page
    {
        Model1 db;
        List<Hostel> select = new List<Hostel>();
        List<string> k = new List<string>();
        public Page1()
        {
            InitializeComponent();
            db = new Model1();

            List<Hostel> hostels = db.Hostels.ToList();
            lis.ItemsSource = hostels;
            lis.DisplayMemberPath = "Name";
            
        }
        public delegate void MethodContainer();
        public static event MethodContainer onLoad;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var trans = db.Database.BeginTransaction())
            {
                try
                {
                    // Проверка наличия значений в текстовых полях
                    if (string.IsNullOrWhiteSpace(sname.Text) || string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(age.Text))
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля.");
                        return;
                    }

                    Students stud = new Students();
                    stud.S_name = sname.Text;
                    stud.Name = name.Text;

                    // Проверка возраста на отрицательное значение
                    if (!int.TryParse(age.Text, out int ageValue) || ageValue < 0)
                    {
                        MessageBox.Show("Пожалуйста, введите корректный возраст.");
                        return;
                    }
                    stud.Age = ageValue;

                    select.Clear();
                    foreach (Hostel item in lis.SelectedItems)
                    {
                        select.Add(item);
                    }
                    stud.Hostels = select;

                    db.Student.Add(stud);
                    db.SaveChanges();
                    MessageBox.Show("Студент добавлен");
                    onLoad();
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    trans.Rollback();
                }
            }
        }
        private void age_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
