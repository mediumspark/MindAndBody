using UnityEngine;

public class BeingFromTheMawEffect : EventCardEffect
{
    private void Awake()
    {
        FindObjectOfType<UIManager>().DescisionResult.text =
           "A voice booms, “Your hope has been most delicious. Looking, fighting, escaping, thank you.” " +
           "You look at the being only to fall unconscious. As you being to stir you feel grass at your feet.";
        UIManager.instance.ResultsOpen();
    }

    public override void BodyTrigger()
    {
        base.BodyTrigger();
        DeckManager.instance.ADeckSO = Resources.Load<AdventureDeckScriptableObject>("ScriptableObjects/Decks/Garden of Madness");
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        DeckManager.instance.ADeckSO.AdventureCards.RemoveAt(0);
        //Fail State

    }

    public override void MindTrigger()
    {
        base.MindTrigger();
        DeckManager.instance.ADeckSO = Resources.Load<AdventureDeckScriptableObject>("ScriptableObjects/Decks/Garden of Madness");
        FindObjectOfType<UIManager>().DescisionResult.text = "";
        DeckManager.instance.ADeckSO.AdventureCards.RemoveAt(0);
        //Does Nothing
    }
}