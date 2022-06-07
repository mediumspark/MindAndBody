using UnityEngine;

public class TheGreatPitEffect_2 : EventCardEffect 
{

    private void Awake()
    {
        FindObjectOfType<UIManager>().DescisionResult.text = "You brace yourself, about to give the doorknob a solid kick, " +
            "but just as your foot hit’s its mark the door swings and you find yourself engulfed in darkness, falling for what " +
            "feels like an eternity. You hit the ground with a massive thud," +
            " face looking up to the door to a garden and a light that no longer exists. You attempt to pick yourself up";
        UIManager.instance.ResultsOpen();

    }

    public override void BodyTrigger()
    {
        base.BodyTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/TheBumpInTheDarkness"));
        FindObjectOfType<UIManager>().DescisionResult.text = "As you begin to ready yourself for danger, it covers you." +
            " You being to feel lighter, the ground begins to shake, until you can no longer feel as you come face to face with a massive blinking white light." +
            " A booming choir of great beings speaks, “Oh a violent one, a delectable one, a stupid one. Your rarity must be put to test. Please" +
            " continue to struggle. We could want nothing more";
    }

    public override void MindTrigger()
    {
        base.MindTrigger();
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/TheBumpInTheDarkness"));
        FindObjectOfType<UIManager>().DescisionResult.text = "As you begin to ready yourself for danger, it covers you." +
            " You being to feel lighter, the ground begins to shake, until you can no longer feel as you come face to face with a massive blinking white light." +
            " A booming choir of great beings speaks, “Oh a violent one, a delectable one, a stupid one. Your rarity must be put to test. Please" +
            " continue to struggle. We could want nothing more";
    }
}
