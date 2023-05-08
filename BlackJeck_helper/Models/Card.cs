using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJeck_helper.Models;
    internal class Card
    {
    public string Name { get; set; }
    public int Value { get; set; }

    /// <summary>
    /// Принимает строку с названием карты и её "вес"
    /// </summary>
    /// <param name="name"></param>
    /// <param name="value"></param>
    public Card(string name, int value)
    {
        Name = name;
        Value = value;
    }
}

