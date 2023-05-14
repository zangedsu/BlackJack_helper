using BlackJack_helper.Controllers;
using BlackJack_helper.Models;
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
        public MainController controller;
        public OpponentsTable opponentsTable;
        public MainWindow()
        {
            InitializeComponent();
            controller = new MainController();
            opponentsTable = new OpponentsTable();
        }

        private void ClickAddGamers(object sender, RoutedEventArgs e)
        {
            string s = ((Button)sender).Tag.ToString();
            controller.AddCardToOpponentsTable(s);
           updateOpponentsDataSources();
        }

        public void updateOpponentsDataSources()
        {
            LabelCountGamers2.DataContext = null;
            LabelCountGamers2.DataContext = controller;
        }
    }
}
