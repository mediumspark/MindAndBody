using UnityEngine;

public class MawServent_2Effect : EventCardEffect
{
    private void Awake()
    {
        FindObjectOfType<UIManager>().DescisionResult.text =
           "A man in a rabbit mask holding a knife";
        UIManager.instance.ResultsOpen();
    }

    public override void BodyTrigger()
    {
        base.BodyTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/MawServent3"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        //Fail State

    }

    public override void MindTrigger()
    {
        base.MindTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/BackOfInn"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        //Does Nothing
    }
}