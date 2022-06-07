using UnityEngine;

public class TheGreatPitEffect_1 : EventCardEffect 
{
    private void Awake()
    {
        FindObjectOfType<UIManager>().DescisionResult.text = "You struggle with the door," +
            " giving it many pushes and pulls until it finally comes off its hinges," +
            " but something has linked you to it and you begin to tumble down into an abyss, " +
            "and after minutes of darkness you hit what feels like earth. To your dismay, this fall somehow leaves you uninjured." +
            " A being that has blended into the darkness glares at you intense glowing eyes lie before you";
        UIManager.instance.ResultsOpen();
    }

    public override void BodyTrigger()
    {
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/TokenNightmare"));
        FindObjectOfType<UIManager>().DescisionResult.text = "It’s deep voice says to you, “Oh, you poor being....What is it you need ?”" + " The eyes seem to disappear for a moment, and reappear somehow softer, waiting for a response from you.";
        base.BodyTrigger();
    }

    public override void MindTrigger()
    {
        DeckManager.instance.AdventureDeck.Add(Resources.Load<Card>("ScriptableObjects/Cards/AdventureCards/The Pit/TheBumpInTheDarkness"));
        FindObjectOfType<UIManager>().DescisionResult.text = "As you begin to ready yourself for danger, it covers you." + " You being to feel lighter, the ground begins to shake, until you can no longer feel as you come face to face with a massive blinking white light." + " A booming choir of great beings speaks, “Oh a violent one, a delectable one, a stupid one. Your rarity must be put to test. " + "Please Continue to struggle we could want nothing more";
        base.MindTrigger();
    }
}
