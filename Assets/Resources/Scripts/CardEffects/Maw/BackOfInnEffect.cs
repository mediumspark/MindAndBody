using UnityEngine;

public class BackOfInnEffect : EventCardEffect
{
    private void Awake()
    {
        FindObjectOfType<UIManager>().DescisionResult.text =
           "You run out the closest window. As you land outside the inn on the paved ground." +
           " You look at a sky that cannot be described with words alone. It seems to peer into your soul and speak to you at the same time. ";
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