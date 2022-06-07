using UnityEngine;

public class LadderFromThePitEffect : EventCardEffect 
{

    public override void BodyTrigger()
    {
        base.BodyTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/TheDoorAtTheEndofThePitP"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        //Fail State

    }

    public override void MindTrigger()
    {
        base.MindTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/TheDoorAtTheEndofThePitM 1"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        //Does Nothing
    }
}
