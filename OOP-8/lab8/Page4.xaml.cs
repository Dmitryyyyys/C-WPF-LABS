using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;

namespace lab8
{
    public partial class Page4 : Page
    {
        Model1 db;

        //List<Hostel> list1 = new List<Hostel>();
        private static Hostel hostels = null;
        public delegate void MethodContainer();
        public static event MethodContainer onHostRequest;
        public static event MethodContainer onLoad;
        public static Hostel MyHost = null;

        public Page4()
        {
            InitializeComponent();
            db = new Model1();
            onHostRequest();
            int count = 0;
            bool IsGoodJob = true;

            while (MyHost == null)
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
                hostels = MyHost;
                MyHost = null;
                name.Text = hostels.Name;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            hostels.Name = name.Text;
            db.Entry(hostels).State = EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Информация обновлена");
            onLoad();
        }
    }
}
