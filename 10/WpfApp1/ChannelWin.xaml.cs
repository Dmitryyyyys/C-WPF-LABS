using System.Windows;

namespace WpfApp1
{
    public partial class ChannelWin : Window
    {
        public ChannelWin()
        {
            InitializeComponent();
        }
        private void OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;

        }
    }
}