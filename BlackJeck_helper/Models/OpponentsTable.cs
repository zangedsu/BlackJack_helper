using BlackJeck_helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Xps;

namespace BlackJack_helper.Models;

    public class OpponentsTable
    {
    private Deck _deck = new Deck(0);
    public Deck OpponentsDeck { get { return _deck; } }

    public OpponentsTable()
    {
        _deck = new Deck(0); 
    }
}

