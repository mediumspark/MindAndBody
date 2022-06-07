using UnityEngine;

public class Room_1Effect : EventCardEffect
{
    private void Awake()
    {
        UIManager.instance.DescisionResult.text = "You wander into a small enclosed space. Suddenly you feel a hole being bored in your stomach." +
   " The temptation to end the pain is irresistible. You spy a knife on a table nearby. ";
        UIManager.instance.ResultsOpen();
    }

    public override void BodyTrigger()
    {
        base.BodyTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/TheMaw"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        //Fail State

    }

    public override void MindTrigger()
    {
        base.MindTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/Room5"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        //Does Nothing
    }
}