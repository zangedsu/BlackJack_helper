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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlackJeck_helper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickAddGamers(object sender, RoutedEventArgs e)
        {
            int tmp = int.Parse(LabelCountGamers2.Content.ToString());
            LabelCountGamers2.Content = ++tmp;
            var st = e.Source.ToString();
            string s = ((Button)sender).Tag.ToString();
            MessageBox.Show(s);
           
        }
    }
}
