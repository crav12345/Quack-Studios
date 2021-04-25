/// <summary>
/// Card holds the value, suit, and rule associated with an instance of a
/// playinig card.
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public string myValue { get; private set; }
    public string mySuit { get; private set; }
    public string myRule { get; private set; }

    /// <summary>
    /// Constructor for cards
    /// </summary>
    /// <param name="newSuit">Suit of the card (hearts, aces, spades, diamonds)</param>
    /// <param name="newValue">Value of the card</param>
    /// <param name="newRule">Rule generated for the card</param>
    public Card(string newSuit, string newValue, string newRule)
    {
        mySuit = newSuit;
        myValue = newValue;
        myRule = newRule;
    }
}
