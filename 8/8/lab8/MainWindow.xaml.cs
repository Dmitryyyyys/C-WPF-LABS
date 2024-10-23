using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace lab8
{
    public partial class MainWindow : Window
    {
        private readonly Model1 _db = new Model1();
        public MainWindow()
        {
            InitializeComponent();
            var outter = from dict in _db.MyEntities select dict ;
            Data.DataContext =  outter.ToList();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text.Equals("") || Email.Text.Equals("") || Password.Password.Equals(""))
            {
                MessageBox.Show("Нужно заполнить все поля перед добавлением");
            }
            else
            {
                var add = new MyEntity
                {
                    Name = Name.Text,
                    Email = Email.Text,
                    Password = Password.Password
                };
                _db.MyEntities.Add(add);
                await _db.SaveChangesAsync();
            }
            var last = from dict in _db.MyEntities select dict;
            Data.DataContext = last.ToList();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var outter = from dict in _db.MyEntities select dict;
            Data.DataContext = outter.ToList();
        }
        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var p1 = (MyEntity)Data.SelectedItem;
            if(p1!=null)
            {
                _db.MyEntities.Remove(p1);
                await _db.SaveChangesAsync();
            }
            var last = from dict in _db.MyEntities select dict;
            Data.DataContext = last.ToList();
        }
        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var p1 = (MyEntity)Data.SelectedItem;
            if (p1 == null)
            {
                MessageBox.Show("Нужно выбрать элемент который хотим изменить!");
            }
            else
            {
                if (Name.Text.Equals(""))
                {
                    MessageBox.Show("Нужно заполнить поле имени перед изменением");
                }
                else
                {
                    p1.Name = Name.Text;
                    await _db.SaveChangesAsync();
                    var outter = from dict in _db.MyEntities select dict;
                    Data.DataContext = outter.ToList();
                }
                if (Email.Text.Equals(""))
                {
                    MessageBox.Show("Нужно заполнить поле перед имэйл изменением");
                }
                else
                {
                    p1.Email = Email.Text;
                    await _db.SaveChangesAsync();
                    var outter = from dict in _db.MyEntities select dict;
                    Data.DataContext = outter.ToList();
                }
                if (Password.Password.Equals(""))
                {
                    MessageBox.Show("Нужно заполнить поле пароля перед изменением");
                }
                else
                {
                    p1.Password = Password.Password;
                    await _db.SaveChangesAsync();
                    var outter = from dict in _db.MyEntities select dict;
                    Data.DataContext = outter.ToList();
                }
            }
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            using (var transaction = _db.Database.BeginTransaction())
            {
                try
                {
                    _db.Database.ExecuteSqlCommand(@"UPDATE dbo.MyEntities SET Email = 'TREK' WHERE Name = 'Влад'");
                    _db.MyEntities.Add(new MyEntity { Email = "vladmyr", Name = "Vova", Id=33, Password="1111" });
                    await _db.SaveChangesAsync();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
            var last = from dict in _db.MyEntities select dict;
            Data.DataContext = last.ToList();
        }
        private  void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var outter = from dict in _db.MyEntities select dict;
            var serch = outter.ToList();
            var list = new List<MyEntity>();
            foreach (var item in serch)
            {
                if(item.Name.Contains(Name.Text) && Name.Text.Equals("") != true)
                { list.Add(item); continue; }
                if( item.Email.Contains(Email.Text) && Email.Text.Equals("") != true)
                { list.Add(item); continue; }
                if(item.Password.Contains(Password.Password) && Password.Password.Equals("") != true)
                { list.Add(item);}
            }
            if (list.Count > 0)
                Data.DataContext = list;
            else
                MessageBox.Show("Введите информацию для поиска хотя бы в одну из строк!");
            var last = from dict in list select dict;
            Data.DataContext = last.ToList();
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var outter = from dict in _db.MyEntities select dict;
            var serch = outter.ToList();
            var list = new List<MyEntity>();
            foreach (var item in serch)
            {
                if ((item.Name.Contains(Name.Text) && !Name.Text.Equals("")) &&
                    (item.Email.Contains(Email.Text) && !Email.Text.Equals("")))
                { list.Add(item); continue; }
                if ((item.Email.Contains(Email.Text) && !Email.Text.Equals("")) && 
                    (item.Password.Contains(Password.Password) && !Password.Password.Equals("")))
                { list.Add(item); continue; }
                if ((item.Name.Contains(Name.Text) && !Name.Text.Equals("")) &&
                    (item.Password.Contains(Password.Password) && !Password.Password.Equals("")))
                { list.Add(item);}
            }
            if (list.Count > 0)
                Data.DataContext = list;
            else
                MessageBox.Show("Введите информацию для поиска хотя бы в две строки или проверьте корректность ввода!");
            var last = from dict in list select dict;
            Data.DataContext = last.ToList();
        }
    }
}