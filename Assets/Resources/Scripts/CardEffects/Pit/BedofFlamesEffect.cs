using UnityEngine;
public class BedofFlamesEffect : EventCardEffect
{

    public override void BodyTrigger()
    {
        base.BodyTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/LadderFromThePit"));
        FindObjectOfType<UIManager>().DescisionResult.text =
           "Head pounding with the knowledge of risks unknown, you hesitate.Before your very eyes the door swings open," +
           " and the little creature quickly disappears within it screaming the way down.Before you know it the door closes" +
           " and the voice is silent.A bright light appears and it reopens slowly. A latter showing from the top, with sounds " +
           "of drunken joy, and merriment coming from underneath it.";
    }

    public override void MindTrigger()
    {
        base.MindTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/LadderFromThePit"));
        FindObjectOfType<UIManager>().DescisionResult.text =
           "Head pounding with the knowledge of risks unknown, you hesitate.Before your very eyes the door swings open," +
           " and the little creature quickly disappears within it screaming the way down.Before you know it the door closes" +
           " and the voice is silent.A bright light appears and it reopens slowly. A latter showing from the top, with sounds " +
           "of drunken joy, and merriment coming from underneath it.";
    }
}