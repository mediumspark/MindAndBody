using UnityEngine;

public class TheCorruptionEffect : EventCardEffect
{
    private void Awake()
    {
        FindObjectOfType<UIManager>().DescisionResult.text =
           "A being launches from your stomach without making any tears it pears into your eyes, its bright white teeth becoming the brightest thing in the room. " +
           "It sinks into the ground closing all the hallways in the room. You hear a chorus of cackling. ";
        UIManager.instance.ResultsOpen();
    }

    public override void BodyTrigger()
    {
        base.BodyTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/BeingFromTheMaw"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        //Fail State

    }

    public override void MindTrigger()
    {
        base.MindTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/BeingFromTheMaw"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        //Does Nothing
    }
}