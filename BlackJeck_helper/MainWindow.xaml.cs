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
            controller.AddCardToOpponentsTable(s.ToLower());
           updateOpponentsDataSources();
        }

        public void updateOpponentsDataSources()
        {
            LabelCountGamers2.DataContext = null;
            LabelCountGamers2.DataContext = controller;

            LabelCountGamers3.DataContext = null;
            LabelCountGamers3.DataContext = controller;

            LabelCountGamers4.DataContext = null;
            LabelCountGamers4.DataContext = controller;

            LabelCountGamers5.DataContext = null;
            LabelCountGamers5.DataContext = controller;

            LabelCountGamers6.DataContext = null;
            LabelCountGamers6.DataContext = controller;

            LabelCountGamers7.DataContext = null;
            LabelCountGamers7.DataContext = controller;

            LabelCountGamers8.DataContext = null;
            LabelCountGamers8.DataContext = controller;

            LabelCountGamers9.DataContext = null;
            LabelCountGamers9.DataContext = controller;
            LabelCountGamers10.DataContext = null;
            LabelCountGamers10.DataContext = controller;
            LabelCountGamersTuz.DataContext = null;
            LabelCountGamersTuz.DataContext = controller;
            LabelCountGamersKorol.DataContext = null;
            LabelCountGamersKorol.DataContext = controller;
            LabelCountGamersDama.DataContext = null;
            LabelCountGamersDama.DataContext = controller;
            LabelCountGamersValet.DataContext = null;
            LabelCountGamersValet.DataContext = controller;
        }

        private void ClickDeleteGamers(object sender, RoutedEventArgs e)
        {
            string s = ((Button)sender).Tag.ToString();
            controller.DeleteCardFromOpponentsTable(s.ToLower());
            updateOpponentsDataSources();
        }
    }
}
