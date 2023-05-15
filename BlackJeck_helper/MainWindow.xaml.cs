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

        //добавить карту в колоду оппонентов
        private void ClickAddGamers(object sender, RoutedEventArgs e)
        {
            string s = ((Button)sender).Tag.ToString();
            controller.AddCardToOpponentsTable(s.ToLower());
           updateOpponentsDataSources();
        }

        //добавить карту в колоду дилера
        private void ClickAddDealer(object sender, RoutedEventArgs e)
        {
            string s = ((Button)sender).Tag.ToString();
            controller.AddCardToDealerTable(s.ToLower());
            updateDealerDataSources();
        }

        //добавить карту в колоду игрока
        private void ClickAddUser(object sender, RoutedEventArgs e)
        {
            string s = ((Button)sender).Tag.ToString();
            controller.AddCardToUserTable(s.ToLower());
            updateUserDataSources();
        }

        private void ClickDeleteGamers(object sender, RoutedEventArgs e)
        {
            string s = ((Button)sender).Tag.ToString();
            controller.DeleteCardFromOpponentsTable(s.ToLower());
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

        public void updateDealerDataSources()
        {
            LabelCountDealer2.DataContext = null;
            LabelCountDealer2.DataContext = controller;
            LabelCountDealer3.DataContext = null;
            LabelCountDealer3.DataContext = controller;
            LabelCountDealer4.DataContext = null;
            LabelCountDealer4.DataContext = controller;
            LabelCountDealer5.DataContext = null;
            LabelCountDealer5.DataContext = controller;
            LabelCountDealer6.DataContext = null;
            LabelCountDealer6.DataContext = controller;
            LabelCountDealer7.DataContext = null;
            LabelCountDealer7.DataContext = controller;
            LabelCountDealer8.DataContext = null;
            LabelCountDealer8.DataContext = controller;
            LabelCountDealer9.DataContext = null;
            LabelCountDealer9.DataContext = controller;
            LabelCountDealer10.DataContext = null;
            LabelCountDealer10.DataContext = controller;
            LabelCountDealerTuz.DataContext = null;
            LabelCountDealerTuz.DataContext = controller;
            LabelCountDealerKorol.DataContext = null;
            LabelCountDealerKorol.DataContext = controller;
            LabelCountDealerDama.DataContext = null;
            LabelCountDealerDama.DataContext = controller;
            LabelCountDealerValet.DataContext = null;
            LabelCountDealerValet.DataContext = controller;
        }

        public void updateUserDataSources()
        {
            LabelCountUser2.DataContext = null;
            LabelCountUser2.DataContext = controller;
            LabelCountUser3.DataContext = null;
            LabelCountUser3.DataContext = controller;
            LabelCountUser4.DataContext = null;
            LabelCountUser4.DataContext = controller;
            LabelCountUser5.DataContext = null;
            LabelCountUser5.DataContext = controller;
            LabelCountUser6.DataContext = null;
            LabelCountUser6.DataContext = controller;
            LabelCountUser7.DataContext = null;
            LabelCountUser7.DataContext = controller;
            LabelCountUser8.DataContext = null;
            LabelCountUser8.DataContext = controller;
            LabelCountUser9.DataContext = null;
            LabelCountUser9.DataContext = controller;
            LabelCountUser10.DataContext = null;
            LabelCountUser10.DataContext = controller;
            LabelCountUserTuz.DataContext = null;
            LabelCountUserTuz.DataContext = controller;
            LabelCountUserKorol.DataContext = null;
            LabelCountUserKorol.DataContext = controller;
            LabelCountUserDama.DataContext = null;
            LabelCountUserDama.DataContext = controller;
            LabelCountUserValet.DataContext = null;
            LabelCountUserValet.DataContext = controller;
        }

    }
}
