using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Data.Entity;

//1. Добавьте EF
//2. Сохр. строку подключения в конфиг.файле
//3. Исп. Code First, создать 2-3 сущности
//4. написать CRUD, сортировка по зад.критериям, поиск по 1-2 полям
//          исп. LINQ to Entity, продем. асинхр.работу, транзакции, SQL
//5. продем. как сгенер. модель EDM из подключенной БД

namespace lab8
{
    public partial class Window1 : Window
    {
        List<Hostel> select = new List<Hostel>();
        Model1 db;
        int z;
        int p;
        public Window1()
        {
            InitializeComponent();
            db = new Model1();
            db.Student.Load();
            db.Hostels.Load();
            studentsDataGrid.DataContext = db.Student.ToList();
            hostelDataGrid.DataContext = db.Hostels.ToList();
            Page4.onHostRequest += GetHostel;
            Page4.onLoad += load;
            Page3.onStudentRequest += GetStudent;
            Page3.onLoad += load;
            Page1.onLoad += load;
            Page2.onLoad += load;
        }

        private void load()
        {
            studentsDataGrid.DataContext = db.Student.ToList();
            hostelDataGrid.DataContext = db.Hostels.ToList();
        }

        private void GetStudent()
        {
            try
            {
                if (studentsDataGrid.SelectedItems.Count < 1)
                {
                    throw new Exception("Select student");
                }
                else
                {
                    Page3.MyStudet = (Students)studentsDataGrid.SelectedItem;
                    foreach (Students k in studentsDataGrid.SelectedItems)
                    {
                        z = k.Id;
                    }
                    Page3.MyStudet = db.Student.Find(z);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetHostel()
        {
            try
            {
                if (hostelDataGrid.SelectedItems.Count < 1)
                {
                    throw new Exception("Select hostel");
                }
                else
                {
                    Page4.MyHost = (Hostel)hostelDataGrid.SelectedItem;
                    foreach (Hostel k in hostelDataGrid.SelectedItems)
                    {
                        z = k.Id;
                    }
                    Page4.MyHost = db.Hostels.Find(z);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource studentsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("studentsViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // studentsViewSource.Source = [универсальный источник данных]
            System.Windows.Data.CollectionViewSource hostelViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("hostelViewSource")));
            // Загрузите данные, установив свойство CollectionViewSource.Source:
            // hostelViewSource.Source = [универсальный источник данных]
        }

        private void ad_st_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page1();
            studentsDataGrid.DataContext = db.Student.ToList();
            hostelDataGrid.DataContext = db.Hostels.ToList();
        }

        private void ad_host_Click(object sender, RoutedEventArgs e)
        {
            fr.Content = new Page2();
            studentsDataGrid.DataContext = db.Student.ToList();
            hostelDataGrid.DataContext = db.Hostels.ToList();
        }

        private void del_st_Click(object sender, RoutedEventArgs e)
        {
            if (studentsDataGrid.SelectedItems.Count < 1)
                return;
            foreach (Students k in studentsDataGrid.SelectedItems)
            {
                z = k.Id;
            }
            int index = studentsDataGrid.SelectedIndex;

            Students st = db.Student.Find(z);                               //ПОИСК
            db.Student.Remove(st);
            db.SaveChanges();
            MessageBox.Show("Student удален");
            studentsDataGrid.DataContext = db.Student.ToList();
            hostelDataGrid.DataContext = db.Hostels.ToList();
        }

        private void del_host_Click(object sender, RoutedEventArgs e)
        {
            if (hostelDataGrid.SelectedItems.Count < 1)
                return;
            foreach (Hostel k in hostelDataGrid.SelectedItems)
            {
                p = k.Id;
            }
            Hostel st = db.Hostels.Find(p);
            db.Hostels.Remove(st);
            db.SaveChanges();
            MessageBox.Show("Hostel удален");
            studentsDataGrid.DataContext = db.Student.ToList();
            hostelDataGrid.DataContext = db.Hostels.ToList();
        }

        private void ch_st_Click(object sender, RoutedEventArgs e)
        {
            if (studentsDataGrid.SelectedItems.Count < 1)
                return;
            foreach (Students k in studentsDataGrid.SelectedItems)
            {
                z = k.Id;
            }
            Students st = db.Student.Find(z);
            Page3 pag = new Page3();
            fr.Content = pag;
            pag.name.Text = st.Name;
            pag.age.Text = st.Age.ToString();
            pag.sname.Text = st.S_name;
            pag.lis.SelectedItem = st.Hostels;


            st.Name = pag.name.Text;
            st.Age = Convert.ToInt32(pag.age.Text);
            st.S_name = pag.sname.Text;
            foreach (Hostel item in pag.lis.SelectedItems)
            {
                select.Add(item);
            }
            st.Hostels = select;
            db.Entry(st).State = EntityState.Modified;
            db.SaveChanges();
        }

        private void ch_host_Click(object sender, RoutedEventArgs e)
        {
            if (hostelDataGrid.SelectedItems.Count < 1)
                return;
            foreach (Hostel k in hostelDataGrid.SelectedItems)
            {
                z = k.Id;
            }
            Hostel host = db.Hostels.Find(z);
            Page4 pag = new Page4();
            fr.Content = pag;
            pag.name.Text = host.Name;

            host.Name = pag.name.Text;
            db.Entry(host).State = EntityState.Modified;
            db.SaveChanges();
        }

        //LINQ to ENTITIES

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var query = db.Student.OrderBy(u => u.Name);
            studentsDataGrid.DataContext = db.Student.ToList();

        }

        //
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var query = db.Student.OrderByDescending(u => u.Name);
            studentsDataGrid.DataContext = db.Student.ToList();
        }

        //обновить
        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            var outter = from dict in db.Student select dict;
            studentsDataGrid.DataContext = outter.ToList();
        }

        //SQL
        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.Student.Add(new Students { S_name = "Грикьян", Name = "Алексей", Id = 33, Age = 21 });
                    await db.SaveChangesAsync();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
            var last = from dict in db.Student select dict;
            studentsDataGrid.DataContext = last.ToList();
        }
    }
}
