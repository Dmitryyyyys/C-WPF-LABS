using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;

namespace lab8
{
    public partial class Page3 : Page
    {
        Model1 db;

        List<Hostel> list1 = new List<Hostel>();
        private static Students students = null;

        public Page3()
        {
            InitializeComponent();
            db = new Model1();
            onStudentRequest();
            int count = 0;
            bool IsGoodJob = true;
            while (MyStudet == null)
            {
                count++;
                if (count == 100)
                {
                    IsGoodJob = false;
                    break;
                }
            }
            if (IsGoodJob)
            {
                students = MyStudet;
                MyStudet = null;
                name.Text = students.Name;
                sname.Text = students.S_name;
                age.Text = students.Age.ToString();
                List<Hostel> hostels = db.Hostels.ToList();

                lis.ItemsSource = hostels;
                lis.DisplayMemberPath = "Name";
            }
        }

        public delegate void MethodContainer();

        public static event MethodContainer onStudentRequest;
        public static event MethodContainer onLoad;

        public static Students MyStudet = null;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            students.Name = name.Text;
            students.S_name = sname.Text;
            students.Age = Convert.ToInt32(age.Text);
            foreach (Hostel item in lis.SelectedItems)
            {
                list1.Add(item);
            }
            students.Hostels = list1;
            db.Entry(students).State = EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Информация обновлена");
            onLoad();

        }
    }
}
