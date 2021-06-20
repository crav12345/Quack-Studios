using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules : MonoBehaviour
{
    #region Variables
    [Header("Rules")]
    public static string[] twos = new string[] {
        "Double Double:\nNext person to draw 2 must must drink twice.",
        "Pants on Fire:\nPlay one round of two truths and a lie. If the lie is found, you drink. If a truth is picked, the rest of the group drinks.",
        "Whirl:\nSpin a bottle or similar object. Whoever it lands on, drinks."
    };

    public static string[] threes = new string[] {
        "Drink for free:\nTake one of someone else’s drinks.",
        "Drink for me:\nPick a friend to drink for you the next time you are supposed to so that you don’t have to!",
        "Snaps:\nEveryone snaps their fingers three times, last one drinks.",
        "Rainbow:\nThe person wearing the most colorful outfit chooses a person to drink."
    };

    public static string[] fours = new string[] {
        "Leap frog:\nPLay a game of Leap frog with a partner against another pair from one side of the room to another and back again.  Losing pair drinks.",
        "Voltage:\nRace to turn of the lights. The winner does not drink, the rest do.",
        "Overkill:\nThe person who last drank drinks again."
    };

    public static string[] fives = new string[] {
       "Copycat:\nPick a person. That person drinks every time you drink for 9 turns, or until copycat is drawn again.",
       "Picasso:\nDraw something in 10 seconds. If the group guesses it, you drink, if they can't, everyone drinks once and you drink twice.",
       "Chaos:\nFinish your drink. The next drinking requirement affects everyone but you."
    };

    public static string[] sixes = new string[] {
        "Breakdown:\nSlap yourself in the face and drink.",
        "Radio:\nPick a person. Have them hum a song for 5 seconds. If you can't guess it, you drink.",
        "Groundhog:\nRe-do the last card. If you don't remember what it was, drink."
    };
    
    public static string[] sevens = new string[] {
        "Skydive:\nEveryone raises one hand into the air.  Continue play.  The first person to lower their hand drinks.",
        "Homies:\nPick two people to be your homies. You and your homies skip the next group event.",
        "Pandemic:\n You and the two people physically closest to you that are playing drink."
    };
    
    public static string[] eights = new string[] {
        "Guardian:\nPick a person other than yourself.  That person is protected from having to drink once.",
        "Gymnast:\nEvery balances on one leg. First person to lose their balance drinks."
    };
    
    public static string[] nines = new string[] {
        "Jinx:\nEveryone knocks on a wooden surface.  The last to knock drinks.",
        "Ninja:\nPlay a game of ninja with someone.  The loser drinks."
    };

    public static string[] tens = new string[] {
        "Hollywood:\nName a movie genre.  Everyone takes turns listing movies in that genre.  If a person can't name a movie in 3 seconds, they drink.",
        "Roast:\nPick someone to have a roast battle or rap battle.  The other players judge.  Loser drinks.",
        "An InTENse Break:\nEveryone take a drink of water. Everyone should be drinking water Queens!"
    };
    
    public static string[] jacks = new string[] {
        "Takeout:\nPick a person. Play Chopsticks. Loser drinks.",
        "Charades!:\nPlay a game of charades, and you're doing the acting!  If your act is guessed, drink.  If not, everyone else drinks."
    };
    
    public static string[] queens = new string[] {
        "Outlier:\nEveryone but you drinks.",
        "Throne:\nDrink the beverage in the middle of the table, replace it with a new one, and you’re out of the game, congratulations!"
    };
    
    public static string[] kings = new string[] {
        "King's Bounty!:\n Draw another card and do that rule twice.",
        "Father and Son:\nChoose a prince to drink with you until another king is drawn."
    };

    public static string[] aces = new string[] {
        "Compliments to the Chef:\nCompliment someone aggressively until you can’t think of a compliment or you laugh.  Don’t repeat compliments.",
        "Alphabet:\nSay a word starting with “A” - “Z”, if you’re can’t think of a word, drink."
    };

    public static string[] jokers = new string[] {
        "Resurrection:\nBring a player back into the game, or make a new custom rule everyone has to follow. If anyone forgets to follow it, they drink.",
        "Forgery:\nMake up a rule for another card."
    };

    [Header("Choices")]
    int choice;
    public string[][] choices = new string[][] { twos, threes, fours, fives, sixes, sevens, eights, nines, tens, jacks, kings, queens, aces};
    #endregion

    /// <summary>
    /// Grabs a random rule by the index
    /// </summary>
    /// <param name="i"></param>
    /// <returns></returns>
    public string GetRule(int i)
    {
        choice = Random.Range(0, choices[i - 2].Length);
        return choices[i - 2][choice];
    }
}
