using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJeck_helper.Models;
    internal class Deck
    {
    public List<Card> Cards { get; set; }

    //ctor
    public Deck()
    {
        Cards = new List<Card>();
        loadData();
    }

    private void loadData() 
    {
        Cards.Add(new Card("2",      2));
        Cards.Add(new Card("3",      3));
        Cards.Add(new Card("4",      4));
        Cards.Add(new Card("5",      5));
        Cards.Add(new Card("6",      6));
        Cards.Add(new Card("7",      7));
        Cards.Add(new Card("8",      8));
        Cards.Add(new Card("9",      9));
        Cards.Add(new Card("10",     10));
        Cards.Add(new Card("туз",    11));
        Cards.Add(new Card("король", 10));
        Cards.Add(new Card("дама",   10));
        Cards.Add(new Card("валет",  10));  
    }
}

