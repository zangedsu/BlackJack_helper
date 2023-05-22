using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using BlackJack_helper.Models;
using BlackJeck_helper.Models;

namespace BlackJack_helper.Controllers;
    public class MainController
    {
    private Deck _deck;
    private OpponentsTable _opponentsTable;
    private DealerTable _dealerTable;
    private UserTable _userTable;
    private Dictionary<string, int> _indexes;
    private int _userPoints = 0;
    private int _matchingCardsCount = 0;
    private string _result;

    public Deck Deck { get { return _deck; } }
    public OpponentsTable OpponentsTable { get {return _opponentsTable;} }
    public DealerTable DealerTable { get { return _dealerTable;} }
    public UserTable UserTable { get { return _userTable;} }
    public string Result { get { return _result; } }  
    public int UserPoints { get { return _userPoints; } }
    public int MathchingCardsCount { get {return _matchingCardsCount; } }




    public MainController()
    {
        _deck = new Deck(1);
        _opponentsTable = new OpponentsTable();
        _userTable = new UserTable();
        _dealerTable = new DealerTable();
        _indexes = new Dictionary<string, int>();
        _indexes.Add("2", 0);
        _indexes.Add("3", 1);
        _indexes.Add("4", 2);
        _indexes.Add("5", 3);
        _indexes.Add("6", 4);
        _indexes.Add("7", 5);
        _indexes.Add("8", 6);
        _indexes.Add("9", 7);
        _indexes.Add("10", 8);
        _indexes.Add("туз", 9);
        _indexes.Add("король", 10);
        _indexes.Add("дама", 11);
        _indexes.Add("валет", 12);
        _result = "N/D";
    }

    //расчет результата
    public void RefreshResult()
    {
        _userPoints = _userTable.UserDeck.GetPointsSumm();

        //количество подходящих карт в оставшейся колоде
        _matchingCardsCount = 0;

        foreach (var card in _deck.Cards)
        {
            if(_userPoints + card.Value <= 21)
            {
                _matchingCardsCount += card.CardsCount;
            }
        }

        //количество карт с учетом одной незвестной у диллера
        var matchingCardsWithoutOne = 0;

        foreach (var card in _deck.Cards)
        {
            if (_userPoints + card.Value <= 21)
            {
                if(card.CardsCount != 0)
                {
                    matchingCardsWithoutOne += card.CardsCount - 1;
                }  
            }
        }
        //считаем два сценария (нужная карта в колоде\одна нужная карта у дилера)
        //"плохой" сценарий
        double iter1 = ((double)matchingCardsWithoutOne / (double)_deck.GetAllCardsWithoutOneCount()) * 100;
        //"хороший" сценарий
        double iter2 = ((double)_matchingCardsCount / (double)_deck.GetAllCardsCount()) * 100;

      // MessageBox.Show($"1: {iter1}\n2: {iter2}");
        //вычисляем среднее из двух сценариев
        double chance = ((iter1 + iter2)/2);
        _result = $"{Math.Round(chance, 3)}%"; 
    }//RefreshResult

    //добавить карту в колоду на столе оппонентов
    public void AddCardToOpponentsTable(string nominal)
    {
        if (_deck.Cards[_indexes[nominal]].CardsCount != 0)
        {
            _opponentsTable.OpponentsDeck.Cards[_indexes[nominal]].CardsCount += 1;
            _deck.Cards[_indexes[nominal]].CardsCount -= 1;
        }
    }


    //добавить карту в колоду на столе дилера
    public void AddCardToDealerTable(string nominal)
    {
        if(_deck.Cards[_indexes[nominal]].CardsCount != 0)
        {
            _dealerTable.DealerDeck.Cards[_indexes[nominal]].CardsCount += 1;
            _deck.Cards[_indexes[nominal]].CardsCount -= 1;
        }

    }

    //удалить карту из колоды на столе оппонентов
    public void DeleteCardFromOpponentsTable(string nominal)
    {
        if (_opponentsTable.OpponentsDeck.Cards[_indexes[nominal]].CardsCount != 0)
        {
            _opponentsTable.OpponentsDeck.Cards[_indexes[nominal]].CardsCount -= 1;
            _deck.Cards[_indexes[nominal]].CardsCount += 1;
        }

    }


    //добавить карту в колоду на столе игрока
    public void AddCardToUserTable(string nominal)
    {
        if (_deck.Cards[_indexes[nominal]].CardsCount != 0)
        {
            _userTable.UserDeck.Cards[_indexes[nominal]].CardsCount += 1;
            _deck.Cards[_indexes[nominal]].CardsCount -= 1;
        }
    }

    //удалить карту из колоды на столе дилера
    public void DeleteCardFromDealerTable(string nominal)
    {
        if (_dealerTable.DealerDeck.Cards[_indexes[nominal]].CardsCount != 0)
        {
            _dealerTable.DealerDeck.Cards[_indexes[nominal]].CardsCount -= 1;
            _deck.Cards[_indexes[nominal]].CardsCount += 1;
        }
    }

    //удалить карту из колоды на столе игрока
    public void DeleteCardFromGamerTable(string nominal)
    {
        if (_userTable.UserDeck.Cards[_indexes[nominal]].CardsCount != 0)
        {
            _userTable.UserDeck.Cards[_indexes[nominal]].CardsCount -= 1;
            _deck.Cards[_indexes[nominal]].CardsCount += 1;
        }
    }

    //сброс партии
    public void ResetGame()
    {
        _deck = new Deck(1);
        _opponentsTable = new OpponentsTable();
        _userTable = new UserTable();
        _dealerTable = new DealerTable();
    }
}

