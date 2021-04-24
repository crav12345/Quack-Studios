﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules
{
    int choice;

    public static string[] twos = new string[] { "Double Double: Next person to draw 2 must must drink twice." };

    public static string[] threes = new string[] { "Drink for free - take one of someone else’s drinks.", "Drink for me - pick a friend to drink for you for your next turn so you don’t have to!", "Snaps: Everyone snaps their fingers three times, last one drinks." };

    public static string[] fours = new string[] { "Leap frog: leap frog race with a parent against two others from one side of the room to another. Losing team drinks.", "Voltage: Race to turn of the lights. The winner does not drink, the rest do." };

    public static string[] fives = new string[] { "Reroll: Reshuffle the deck." };

    public static string[] sixes = new string[] { "Breakdown: Slap yourself in the face and drink." };

    public static string[] sevens = new string[] { "Skydive: Everyone raises one hand into the air. Continue play. The first person to lower their hand drinks." };

    public static string[] eights = new string[] { "Guardian: Pick a person other than yourself. That person is protected from having to drink once." };

    public static string[] nines = new string[] { "Jinx: Everyone knocks on a wooden surface. The last to knock drinks." };

    public static string[] tens = new string[] { "Hollywood: Name a movie genre. Everyone takes turns listing movies in that genre. If a person can't name a movie in 3 seconds, they drink." };

    public static string[] jacks = new string[] { "Takeout: Pick a person. Play Chopsticks. Loser drinks." };

    public static string[] queens = new string[] { "Everyone but you drinks", "Bring a player back into the game " };

    public static string[] kings = new string[] { "Draw another card and do that rule twice.", "Choose a prince to drink with you until another king is drawn." };

    public static string[] aces = new string[] { "Compliment someone aggressively until you can’t think of a compliment or you laugh. Don’t repeat compliments.", "Alphabet: say a word starting with “A” - “Z”, if you’re can’t think of a word drink " };

    public static string[] jokers = new string[] { "Drink the beverage in the middle of the table, replace it with a new one, and you’re out of the game, congratulations!" };

    public string[][] choices = new string[][] { twos, threes, fours, fives, sixes, sevens, eights, nines, tens, jacks, kings, queens, aces};
    public string GetRule(int i)
    {
        choice = Random.Range(0, choices[i].Length);
        return choices[i][choice];



        /*
        if (i == 2)
        {
            choice = Random.Range(0, choices[i].Length);
            return choices[i][choice];
        }
        else if (i == 3)
        {
            choice = Random.Range(0, threes.Length);
            return threes[choice];
        }
        else if (i == 4)
        {
            choice = Random.Range(0, fours.Length);
            return fours[choice];
        }
        else if (i == 5)
        {
            choice = Random.Range(0, fives.Length);
            return fives[choice];
        }
        else if (i == 6)
        {
            choice = Random.Range(0, sixes.Length);
            return sixes[choice];
        }
        else if (i == 7)
        {
            choice = Random.Range(0, sevens.Length);
            return sevens[choice];
        }
        else if (i == 8)
        {
            choice = Random.Range(0, eights.Length);
            return eights[choice];
        }
        else if (i == 9)
        {
            choice = Random.Range(0, nines.Length);
            return  nines[choice];
        }
        else if (i == 10)
        {
            choice = Random.Range(0, tens.Length);
            return tens[choice];
        }
        else if (i == 11)
        {
            choice = Random.Range(0, jacks.Length);
            return jacks[choice];
        }
        else if (i == 12)
        {
            choice = Random.Range(0, queens.Length);
            return queens[choice];
        }
        else if (i == 13)
        {
            choice = Random.Range(0, kings.Length);
            return kings[choice];
        }
        else
        {
            choice = Random.Range(0, aces.Length);
            return aces[choice];
        }
        */

    }
}
