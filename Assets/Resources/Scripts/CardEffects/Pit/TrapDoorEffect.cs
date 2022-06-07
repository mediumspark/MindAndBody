using UnityEngine;

public class TrapDoorEffect : EventCardEffect
{
    public override void BodyTrigger()
    {
        base.BodyTrigger();
        PlayerStats.instance.Body -= CardBase.BodyMod;
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/The Pit/LadderFromThePit"));
        FindObjectOfType<UIManager>().DescisionResult.text =
   "Head pounding with the knowledge of risks unknown, you hesitate.Before your very eyes the door swings open," +
   " and the little creature quickly disappears within it screaming the way down.Before you know it the door closes" +
   " and the voice is silent.A bright light appears and it reopens slowly. A latter showing from the top, with sounds " +
   "of drunken joy, and merriment coming from underneath it.";
        //Fail State

    }

    public override void MindTrigger()
    {
        base.MindTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/The Pit/BedOfFlames"));
        FindObjectOfType<UIManager>().DescisionResult.text = "As you crouch to open the door it swings open, and as " +
            "you being to climb downwards a small cackle turns to a deep repeated moan. You cannot remember where you " +
            "are or your way up, you continue to climb down for eternity";
        //Does Nothing
    }
}
