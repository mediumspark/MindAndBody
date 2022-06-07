using UnityEngine;

public class AroundTheFacility : EventCardEffect
{
    private void Awake()
    {
        FindObjectOfType<UIManager>().DescisionResult.text =
           "You flee as fast as you can only to end up in a room you don’t recognize. You continue to walk lost." +
           " This reminds you of the maze you ended up in earlier. You feel something in the pit of your gut begin to stir.";
        UIManager.instance.ResultsOpen();
    }

    public override void BodyTrigger()
    {
        base.BodyTrigger(); 
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/TheCorruption"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        //Fail State

    }

    public override void MindTrigger()
    {
        base.MindTrigger(); 
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/TheCorruption"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        //Does Nothing
    }
}