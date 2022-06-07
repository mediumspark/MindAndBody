using UnityEngine;
using System.Linq; 
public class GardenEffect : EventCardEffect
{

    public override void BodyTrigger()
    {
        base.BodyTrigger(); 
        
        DeckManager.instance.AdventureDeck.Insert(1, Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Garden/EndlessMischief"));
        DeckManager.instance.AdventureDeck.Insert(2, Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Garden/GardenMaze"));
        UIManager.instance.DescisionResult.text = "You run and turn, run and turn, run and turn simply to end up right where you began, you see more rats begin to swarm you. ";
        //Fail State

    }

    public override void MindTrigger()
    {
        base.MindTrigger();
        if (!DeckManager.instance.AdventureDeck.Where(ctx => ctx.EffectName == "GardenEnd").Any())
            DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/Garden/GardenEnd"));
        //Does Nothing
    }
}
