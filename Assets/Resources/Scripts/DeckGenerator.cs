using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; 


/// <summary>
/// Creates a usable database for all the cards currently in the game
/// so that they can be called without having to reference their location 
/// </summary>
[System.Serializable]
public class DeckGenerator 
{

    Card[] CardDatabase;

    public void Generate()
    {
        CardDatabase = Resources.LoadAll<Card>("ScriptableObjects/Cards");
    }

    //Calls a random Item card 
    public Card ItemGeneration()
    {
        List<Card> Items = CardDatabase.Where
            (
                ctx => ctx.CardType == CardType.ItemCard
            ).ToList();


        return Items[Random.Range(0, Items.Count)];
    }

    //Calls a random event card
    public Card EventGenerator()
    {
        System.Random rand = new System.Random();
        List<Card> Items = CardDatabase.Where
            (
                ctx => ctx.CardType == CardType.EventCard
            ).ToList();
        return Items[rand.Next(0, Items.Count)];
    }
}
