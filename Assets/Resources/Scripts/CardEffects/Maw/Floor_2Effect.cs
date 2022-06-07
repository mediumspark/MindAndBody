using UnityEngine;

public class Floor_2Effect : EventCardEffect
{
    private void Awake()
    {
        FindObjectOfType<UIManager>().DescisionResult.text =
           " The building has clearly changed. You assume the men were correct that this was a higher floor. As you walk the hallway you see a window." +
           " You begin to feel sick to your stomach. The hallway continues, but the window looks destructible";
        UIManager.instance.ResultsOpen();
    }

    public override void BodyTrigger()
    {
        base.BodyTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/BackOfInn"));
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