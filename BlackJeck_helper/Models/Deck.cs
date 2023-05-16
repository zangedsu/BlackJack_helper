using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BlackJeck_helper.Models;
    public class Deck
    {
    public List<Card> Cards { get; set; }

    //ctor
    public Deck(int decksCount)
    {
        Cards = new List<Card>();
        int cardsCount = decksCount == 0 ? 0 : decksCount*4;
        createDeck(cardsCount);
    }

    private void createDeck(int cardsCount) 
    {
        Cards.Add(new Card("2",      2, cardsCount));
        Cards.Add(new Card("3",      3, cardsCount));
        Cards.Add(new Card("4",      4, cardsCount));
        Cards.Add(new Card("5",      5, cardsCount));
        Cards.Add(new Card("6",      6, cardsCount));
        Cards.Add(new Card("7",      7, cardsCount));
        Cards.Add(new Card("8",      8, cardsCount));
        Cards.Add(new Card("9",      9, cardsCount));
        Cards.Add(new Card("10",     10, cardsCount));
        Cards.Add(new Card("туз",    11, cardsCount));
        Cards.Add(new Card("король", 10, cardsCount));
        Cards.Add(new Card("дама",   10, cardsCount));
        Cards.Add(new Card("валет",  10, cardsCount));  
    }

    //получить количество карт
    public int GetAllCardsCount()
    {
        int count = 0;
        foreach (Card card in Cards) { count += card.CardsCount; }
        return count;
    }

    //получить количество карт - 1 
    public int GetAllCardsWithoutOneCount()
    {
        int count = 0;
        foreach (Card card in Cards) 
        { 
            if(card.CardsCount != 0)
            {
                count += card.CardsCount - 1;
            }
            
        }
        return count;
    }

    //получить сумму очков колоды
    public int GetPointsSumm()
    {
        int summ = 0;
        foreach (Card card in Cards)
        {
            if(card.CardsCount != 0)
            {
                summ += card.Value * card.CardsCount;
            }
            
        }
        return summ;
    }

}

