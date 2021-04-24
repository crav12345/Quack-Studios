using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    #region Varibles
    private List<Card> myDeck = new List<Card>();
    private Rules myRules;
    #endregion

    private string path = "Cards/Card_";

    // Start is called before the first frame update
    void Start()
    {
        // Make each card
        BuildDeck();

        // Throw the deck on screen
        // InstantiateDeck();
    }

    /// <summary>
    /// Builds a deck with random rules at runtime
    /// </summary>
    void BuildDeck()
    {
        // Get instance of our Rules script
        myRules = GetComponent<Rules>();

        // For each value in a deck of cards
        for (int i = 2; i <= 14; i++)
        {
            // Grab one of the rules for that value
            string myRule = myRules.GetRule(i);

            // Cards that are not face cards
            if (i <= 10)
            {
                myDeck.Add(new Card("H", i.ToString(), myRule));
                myDeck.Add(new Card("D", i.ToString(), myRule));
                myDeck.Add(new Card("S", i.ToString(), myRule));
                myDeck.Add(new Card("C", i.ToString(), myRule));
            }
            // Jacks
            else if (i == 11)
            {
                myDeck.Add(new Card("H", "J", myRule));
                myDeck.Add(new Card("D", "J", myRule));
                myDeck.Add(new Card("S", "J", myRule));
                myDeck.Add(new Card("C", "J", myRule));
            }
            // Queens
            else if (i == 12)
            {
                myDeck.Add(new Card("H", "Q", myRule));
                myDeck.Add(new Card("D", "Q", myRule));
                myDeck.Add(new Card("S", "Q", myRule));
                myDeck.Add(new Card("C", "Q", myRule));
            }
            // Kings
            else if (i == 13)
            {
                myDeck.Add(new Card("H", "K", myRule));
                myDeck.Add(new Card("D", "K", myRule));
                myDeck.Add(new Card("S", "K", myRule));
                myDeck.Add(new Card("C", "K", myRule));
            }
            // Aces
            else
            {
                myDeck.Add(new Card("H", "A", myRule));
                myDeck.Add(new Card("D", "A", myRule));
                myDeck.Add(new Card("S", "A", myRule));
                myDeck.Add(new Card("C", "A", myRule));
            }
        }
    }

    /*
    void InstantiateDeck()
    {
        // GO through each card
        foreach (Card card in myDeck)
        {
            // Instantiate the card on screen at a random position
            Instantiate(
                Resources.Load(
                    path +
                    card.mySuit +
                    card.myValue
                ),
                new Vector2(

                ),
                Quaternion.identity
            );
        }
    }
    */
}
