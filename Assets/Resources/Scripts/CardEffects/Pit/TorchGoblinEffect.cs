using UnityEngine;

public class TorchGoblinEffect : EventCardEffect 
{

    public override void BodyTrigger()
    {
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/TrapDoor"));
        FindObjectOfType<UIManager>().DescisionResult.text = "The creature looks at you, still judging, but no longer as a threat. It says “Come, Come." +
            " Follow Follow. It takes you took a ditch barely covered by a wooden trap door." +
            " “Down Down”. It begins to hop with an unsettling amount of joy at the prospect of your … downfall.”";
        base.BodyTrigger();

    }

    public override void MindTrigger()
    {
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/TalkativeSpiderling"));
        FindObjectOfType<UIManager>().DescisionResult.text = "You briefly hear an awkward hum and a barrage of filler words as a small spider looks to you with interested eyes. " +
            "“Be uh Behind me is a wa- wall. Please don’t go, it's dangerous.” It sees your puzzled face and decides to launch itself into a tangent about a mouth, its fear of feet, and the bad bad feeling. ";
        base.MindTrigger();
    }
}
