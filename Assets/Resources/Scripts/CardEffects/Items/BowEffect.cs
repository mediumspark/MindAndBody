public class BowEffect : ItemCardEffect
{
    public override void BodyTrigger()
    {
        PlayerStats.instance.Body += CardBase.BodyMod + CardBase.MindMod;
    }

    public override void MindTrigger()
    {
        PlayerStats.instance.Mind += CardBase.MindMod;
    }

    public override void OnUseFromDeck()
    {
        base.OnUseFromDeck();
        FindObjectOfType<EventCardEffect>().BodyMod /= 2; 
    }
}