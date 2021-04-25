/// <summary>
/// Creates a deck of 52 cards and places them on the screen in random
/// positions.
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    #region Variables
    private List<Card> myDeck = new List<Card>();
    private Rules myRules;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        // Make each card
        BuildDeck();

        // Throw the deck on screen
        InstantiateDeck();
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

    void InstantiateDeck()
    {
        // Go through each card
        foreach (Card card in myDeck)
        {
            /*
            // Get random Y-pos within the boundaries of the main camera
            float spawnY =
                Random.Range(
                    Camera.main.ScreenToWorldPoint(
                        new Vector2(0, 0)).y,
                    Camera.main.ScreenToWorldPoint(
                        new Vector2(0, Screen.height)).y
                );
            // Get random X-pos within the boundaries of the main camera
            float spawnX =
                Random.Range(
                    Camera.main.ScreenToWorldPoint(
                        new Vector2(0, 0)).x,
                    Camera.main.ScreenToWorldPoint(
                        new Vector2(Screen.width, 0)).x
                );

            // Create a vector two based on the above X and Y values
            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
            */

            // Instantiate the card on screen at our random position
            GameObject newCard = (GameObject)Instantiate(
                Resources.Load(
                    "Cards/Card"
                ),
                new Vector2(0,0),
                Quaternion.Euler(0, 0, Random.Range(0, 360))
            );


            CardInteraction newCardValues = newCard.GetComponentInChildren<CardInteraction>();

            newCardValues.mySuit = card.mySuit;
            newCardValues.myRule = card.myRule;
            newCardValues.myValue = card.myValue;
        }
    }
}
