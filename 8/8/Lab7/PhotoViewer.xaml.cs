using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab7
{
    public partial class PhotoViewer : Window
    {
        public PhotoViewer()
        {
            InitializeComponent();
        }

        public PhotoViewer(ImageSource source)
        {
            InitializeComponent();
            this.viewImage.Source = source;
        }
    }
}
