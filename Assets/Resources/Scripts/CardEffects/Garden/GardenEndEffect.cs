using UnityEngine; 

public class GardenEndEffect : EventCardEffect
{
    private void Awake()
    {
        UIManager.instance.DescisionResult.text = " You finally reach a door that feels to be the end of the maze.  Before you open it, you hesitate," +
    " there seems to be a sound coming from the door. The door seems to be too stuck to simply open, but " +
    "fragile enough to kick down with a running start.";

        UIManager.instance.ResultsOpen(); 
    }

    public override void BodyTrigger()
    {
        DeckManager.instance.ADeckSO = Resources.Load<AdventureDeckScriptableObject>("ScriptableObjects/Decks/Dawkins Hole");
        DeckManager.instance.ADeckSO.AdventureCards.Clear(); 
        DeckManager.instance.AdventureDeck = DeckManager.instance.ADeckSO.AdventureCards;
        DeckManager.instance.ADeckSO.AdventureCards.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/GreatPitP"));
    }

    public override void MindTrigger()
    {
        DeckManager.instance.ADeckSO = Resources.Load<AdventureDeckScriptableObject>("ScriptableObjects/Decks/Dawkins Hole");
        DeckManager.instance.ADeckSO.AdventureCards.Clear(); 
        DeckManager.instance.AdventureDeck = DeckManager.instance.ADeckSO.AdventureCards;
        DeckManager.instance.ADeckSO.AdventureCards.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/GreatPitM"));
    }
}