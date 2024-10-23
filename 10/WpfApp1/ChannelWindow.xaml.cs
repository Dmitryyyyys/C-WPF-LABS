using System.Windows;
using System.Linq;
using System;

namespace WpfApp1
{
    public partial class ChannelWindow : Window
    {
        private readonly EfGenericRep<Item> _itemRep = new EfGenericRep<Item>(new ChannelContext());
        private readonly EfGenericRep<Channel> _chRep = new EfGenericRep<Channel>(new ChannelContext());
        public ChannelWindow()
        {
            InitializeComponent();
            DataGrid1.ItemsSource = _chRep.Get();
        }

        private void UpdateDb()
        {
            DataGrid1.ItemsSource = null;
            DataGrid1.ItemsSource = _chRep.Get();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var cWin = new ChannelWin();
            if (cWin.ShowDialog() == true)
            {
                var channel = new Channel
                {
                    Title = cWin.textBox1.Text,
                    Description = cWin.textBox2.Text,
                    Link = cWin.textBox3.Text,
                    Copyright = cWin.textBox4.Text
                };
                _chRep.Create(channel);
                UpdateDb();
                MessageBox.Show("Новый канал добавлен");
            }
            else
            {
                return;
            }
        }
    }
}