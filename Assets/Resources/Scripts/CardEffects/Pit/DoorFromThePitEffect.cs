using UnityEngine;
public class DoorFromThePitEffect : EventCardEffect {
    private void Awake()
    {
        FindObjectOfType<UIManager>().DescisionResult.text = "After looking into the darkness, you decide to cautiously descend. ";
        UIManager.instance.ResultsOpen();
    }


    public override void BodyTrigger()
    {
        PlayerStats.instance.Body -= CardBase.BodyMod;
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/TheMaw"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
    }

    public override void MindTrigger()
    {
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/Room1"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
    }
}