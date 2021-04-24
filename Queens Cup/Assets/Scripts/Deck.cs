using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    private List<Card> myDeck;

    // Start is called before the first frame update
    void Start()
    {
        BuildDeck();
    }

    void BuildDeck()
    {
        // For each value in a deck of cards
        for (int i = 2; i <= 14; i++)
        {
            string myRule = ""; // GetRule(i);

            if (i <= 10)
            {
                myDeck.Add(new Card("H", i.ToString(), myRule));
                myDeck.Add(new Card("D", i.ToString(), myRule));
                myDeck.Add(new Card("S", i.ToString(), myRule));
                myDeck.Add(new Card("C", i.ToString(), myRule));
            }
            else if (i == 11)
            {
                myDeck.Add(new Card("H", "J", myRule));
                myDeck.Add(new Card("D", "J", myRule));
                myDeck.Add(new Card("S", "J", myRule));
                myDeck.Add(new Card("C", "J", myRule));
            }
            else if (i == 12)
            {
                myDeck.Add(new Card("H", "Q", myRule));
                myDeck.Add(new Card("D", "Q", myRule));
                myDeck.Add(new Card("S", "Q", myRule));
                myDeck.Add(new Card("C", "Q", myRule));
            }
            else if (i == 13)
            {
                myDeck.Add(new Card("H", "K", myRule));
                myDeck.Add(new Card("D", "K", myRule));
                myDeck.Add(new Card("S", "K", myRule));
                myDeck.Add(new Card("C", "K", myRule));
            }
            else
            {
                myDeck.Add(new Card("H", "A", myRule));
                myDeck.Add(new Card("D", "A", myRule));
                myDeck.Add(new Card("S", "A", myRule));
                myDeck.Add(new Card("C", "A", myRule));
            }
        }
    }
}
