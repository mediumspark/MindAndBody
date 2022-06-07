using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessMischiefEffect : EventCardEffect
{

    public override void BodyTrigger()
    {
        PlayerStats.instance.Mind--;

        FindObjectOfType<UIManager>().DescisionResult.text = "You slaughter the rodents wholesale. As you come too, you realize you're in the middle of a headgemaze.";

        base.BodyTrigger();
    }

    public override void MindTrigger()
    {     
        DeckManager.instance.AdventureDeck.Insert(1, Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Garden/EndlessMischief"));
        FindObjectOfType<UIManager>().DescisionResult.text = "The horde seems endless, the more you turn to run the more seem to appear.";

        base.MindTrigger();
    }
}