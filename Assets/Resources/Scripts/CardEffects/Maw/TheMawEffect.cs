using UnityEngine;

public class TheMawEffect : EventCardEffect
{
    private void Awake()
    {
        FindObjectOfType<UIManager>().DescisionResult.text =
           " After blinking you notice that you are surrounded by men in black hoods. Each standing in silence holding knives.";
        UIManager.instance.ResultsOpen();
    }

    public override void BodyTrigger()
    {
        base.BodyTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/MawServent1"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        //Fail State

    }

    public override void MindTrigger()
    {
        base.MindTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Maw/AroundTheFacility"));
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        //Does Nothing
    }
}