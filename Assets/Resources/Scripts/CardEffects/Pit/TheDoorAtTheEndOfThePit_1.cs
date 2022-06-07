using UnityEngine;

public class TheDoorAtTheEndOfThePit_1 : EventCardEffect
{
    private void Awake()
    {
        FindObjectOfType<UIManager>().DescisionResult.text = "After looking into the darkness, you decide to cautiously descend." +
            "As you descend, the door closes, the sounds cease and the darkness once again encapsulates you. How will you continue your descent? Cautiously, or quickly?";
        UIManager.instance.ResultsOpen();
    }


    public override void BodyTrigger()
    {
        base.BodyTrigger();
        DeckManager.instance.ADeckSO = Resources.Load<AdventureDeckScriptableObject>("ScriptableObjects/Decks/The Inn");
        DeckManager.instance.ADeckSO.AdventureCards.Clear();
        DeckManager.instance.AdventureDeck = DeckManager.instance.ADeckSO.AdventureCards;
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/TheMaw"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";

    }

    public override void MindTrigger()
    {
        base.MindTrigger();

        DeckManager.instance.ADeckSO = Resources.Load<AdventureDeckScriptableObject>("ScriptableObjects/Decks/The Inn");
        DeckManager.instance.ADeckSO.AdventureCards.Clear();
        DeckManager.instance.AdventureDeck = DeckManager.instance.ADeckSO.AdventureCards;
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/TheMaw"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";

    }
}