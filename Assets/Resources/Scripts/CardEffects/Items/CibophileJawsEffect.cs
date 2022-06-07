public class CibophileJawsEffect : ItemCardEffect
{
    public override void BodyTrigger()
    {
        PlayerStats.instance.Body += CardBase.BodyMod;
    }

    public override void MindTrigger()
    {
        PlayerStats.instance.Mind += CardBase.MindMod;
    }

    public override void OnUseFromDeck()
    {
        base.OnUseFromDeck();
        UIManager.instance.DescisionResult.text = "You hunger";
        UIManager.instance.ResultsOpen(); 
        FindObjectOfType<EventCardEffect>().BodyMod = 0; 
        FindObjectOfType<EventCardEffect>().MindMod = 0;
        PlayerStats.instance.HoldDeck.Clear(); 
    }
}