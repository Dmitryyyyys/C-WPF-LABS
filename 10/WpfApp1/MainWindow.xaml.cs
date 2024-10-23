using System.Windows;
using System;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private readonly EfGenericRep<Item> _itemRep = new EfGenericRep<Item>(new ChannelContext());
        private readonly EfGenericRep<Channel> _chRep = new EfGenericRep<Channel>(new ChannelContext());
        public MainWindow()
        {
            InitializeComponent();
            DataGrid1.ItemsSource = _itemRep.Get();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var iWin = new ItemWindow
            {
                comboBox1 =
                {
                    ItemsSource = _chRep.Get(),
                    DisplayMemberPath = "Title"
                }
            };
            if (iWin.ShowDialog() == true)
            {
                var item = new Item
                {
                    Title = iWin.textBox1.Text,
                    Description = iWin.textBox2.Text,
                    Link = iWin.textBox3.Text,
                    PubDate = iWin.textBox4.Text,
                    Channel = (Channel) iWin.comboBox1.SelectedItem
                };
                _itemRep.Create(item);
                UpdateDb();
                MessageBox.Show("Новая статья добавлена");
            }
            else
            {
                return;
            }
        }

        
        //обновление данных грида
        private void UpdateDb()
        {
            DataGrid1.ItemsSource = null;
            DataGrid1.ItemsSource = _itemRep.Get();
        }


        private void Channels_Click(object sender, RoutedEventArgs e)
        {
            var cWin = new ChannelWindow();
            cWin.Show();
        }
    }
}