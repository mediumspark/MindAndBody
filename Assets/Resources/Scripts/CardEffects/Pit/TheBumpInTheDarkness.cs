using UnityEngine;

public class TheBumpInTheDarkness : EventCardEffect 
{
    public override void BodyTrigger()
    {
        base.BodyTrigger();
        PlayerStats.instance.Body -= CardBase.BodyMod;
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/TalkativeSpiderling"));
        UIManager.instance.DescisionResult.text = "You briefly hear an awkward hum and a barrage of filler words " +
            "as a small spider looks to you with interested eyes. “Be uh Behind me is a wa- wall. Please don’t go, it's dangerous.”" +
            "It sees your puzzled face and decides to launch itself into a tangent about a mouth, its fear of feet, and the bad bad feeling.";

    }

    public override void MindTrigger()
    {
        base.MindTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/BedOfFlames"));
        UIManager.instance.DescisionResult.text = "You fall to your doom cooked to a crisp ";
    }
}
