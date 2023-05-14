using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJeck_helper.Models;
    public class Card
    {
    private int _cardsCount;

    public string Name { get; set; }
    public int Value { get; set; }
    public int CardsCount { get { return _cardsCount; }
        set {_cardsCount = value >= 0 ? value : 0; }
    }


    /// <summary>
    /// Принимает строку с названием карты и её "вес"
    /// </summary>
    /// <param name="name"></param>
    /// <param name="value"></param>
    public Card(string name, int value, int count)
    {
        Name = name;
        Value = value;
        CardsCount = count;
    }
}

