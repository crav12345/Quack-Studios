using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public string myValue { get; private set; }
    public string mySuit { get; private set; }
    public string myRule { get; private set; }

    public Card(string newSuit, string newValue, string newRule)
    {
        mySuit = newSuit;
        myValue = newValue;
        myRule = newRule;
    }
}
