using BlackJeck_helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Xps;

namespace BlackJack_helper.Models;

    internal class OpponentsTable
    {
    private Deck _deck = new Deck(0);
    public Deck Deck { get { return _deck; } }

    public OpponentsTable()
    {
      
    }
}

