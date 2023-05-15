using BlackJeck_helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_helper.Models;

    public class UserTable
    {
    private Deck _deck = new Deck(0);
    public Deck UserDeck { get { return _deck; } }

    public UserTable()
    {
        _deck = new Deck(0);
    }
}

