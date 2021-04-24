using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    #region Variables
    private string myValue;
    private string mySuit;
    private string myRule;
    #endregion

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
