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
    }


}

