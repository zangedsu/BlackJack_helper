using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public Deck Deck { get { return _deck; } }
    public OpponentsTable OpponentsTable { get {return _opponentsTable;} }
    public DealerTable DealerTable { get { return _dealerTable;} }
    public UserTable UserTable { get { return _userTable;} }




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
    }

    //добавить карту в колоду на столе оппонентов
    public void AddCardToOpponentsTable(string nominal)
    {
        _opponentsTable.OpponentsDeck.Cards[_indexes[nominal]].CardsCount += 1;
        _deck.Cards[_indexes[nominal]].CardsCount -= 1;
    }

    //удалить карту из колоды на столе оппонентов
    public void DeleteCardFromOpponentsTable(string nominal)
    {
        _opponentsTable.OpponentsDeck.Cards[_indexes[nominal]].CardsCount -= 1;
        _deck.Cards[_indexes[nominal]].CardsCount += 1;
    }


    //добавить карту в колоду на столе дилера
    public void AddCardToDealerTable(string nominal)
    {
        _dealerTable.DealerDeck.Cards[_indexes[nominal]].CardsCount += 1;
        _deck.Cards[_indexes[nominal]].CardsCount -= 1;
    }

    //добавить карту в колоду на столе игрока
    public void AddCardToUserTable(string nominal)
    {
        _userTable.UserDeck.Cards[_indexes[nominal]].CardsCount += 1;
        _deck.Cards[_indexes[nominal]].CardsCount -= 1;
    }
}

