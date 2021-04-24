using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    private string myValue;
    private string mySuit;
    private string myRule;

    public Card(string newSuit, string newValue, string newRule)
    {
        mySuit = newSuit;
        myValue = newValue;
        myRule = newRule;
    }
}
