using UnityEngine;
public class TheDoorAtTheEndOfThePit_2 : EventCardEffect
{
    private void Awake()
    {
        FindObjectOfType<UIManager>().DescisionResult.text = "You slide down the ladder " +
            "As you descend, the door closes, the sounds cease and the darkness once again encapsulates you." +
            "How will you continue your descent? Cautiously, or quickly?";
        UIManager.instance.ResultsOpen();
    }


    public override void BodyTrigger()
    {
        DeckManager.instance.ADeckSO = Resources.Load<AdventureDeckScriptableObject>("ScriptableObjects/Decks/The Inn");
        DeckManager.instance.ADeckSO.AdventureCards.Clear();
        DeckManager.instance.AdventureDeck = DeckManager.instance.ADeckSO.AdventureCards;
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/Room1"));


    }

    public override void MindTrigger()
    {
        DeckManager.instance.ADeckSO = Resources.Load<AdventureDeckScriptableObject>("ScriptableObjects/Decks/The Inn");
        DeckManager.instance.ADeckSO.AdventureCards.Clear();
        DeckManager.instance.AdventureDeck = DeckManager.instance.ADeckSO.AdventureCards;
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/Room1"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
    }
}