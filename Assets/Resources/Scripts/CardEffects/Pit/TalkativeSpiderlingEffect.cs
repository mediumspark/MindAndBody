using UnityEngine;

public class TalkativeSpiderlingEffect : EventCardEffect 
{

    public override void BodyTrigger()
    {
        base.BodyTrigger(); 
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/TrapWall"));
        FindObjectOfType<UIManager>().DescisionResult.text = "You press your weary hand to the wall. " +
            "Suddenly you feel your feet give way as you fall your begin to feel hotter and hotter";
    }

    public override void MindTrigger()
    {
        base.MindTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/TorchGoblin"));
        FindObjectOfType<UIManager>().DescisionResult.text = "Its eyes shrink to the floor. It slowly begins to move forward, with a" +
            " small light finally revealing its form to you. Its voice goes from a boom to a shrill whimper as it says, “Ah! It escapes " +
            "you seek, seek. No. Once here, the only certainty is death, death.” It begins to judge you. Suddenly, it beings to clutch its" +
            " torch even tighter. “NO, light is MINE.” ";
    }
}
