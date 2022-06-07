using UnityEngine;

public class Room_5Effect : EventCardEffect
{
    private void Awake()
    {
        FindObjectOfType<UIManager>().DescisionResult.text =
           " You walk through the hall looking for a way out. The 5th room you run into is open and in it, you find a group of men one of whom groans," +
           "“ We can get you to the high floor for answers. However, we’ll need a bit of your blood.";
        UIManager.instance.ResultsOpen();
    }

    public override void BodyTrigger()
    {
        base.BodyTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/Floor2"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        //Fail State

    }

    public override void MindTrigger()
    {
        base.MindTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/MawServent1"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        //Does Nothing
    }
}