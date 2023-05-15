using BlackJeck_helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_helper.Models;

    public class DealerTable
    {
    private Deck _deck = new Deck(0);
    public Deck DealerDeck { get { return _deck; } }

    public DealerTable()
    {
        _deck = new Deck(0);
    }

}

