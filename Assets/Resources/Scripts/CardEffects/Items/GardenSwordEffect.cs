public class GardenSwordEffect : ItemCardEffect
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

        PlayerStats.instance.Body += CardBase.BodyMod;
        FindObjectOfType<EventCardEffect>().BodyMod -= 10; 
    }
}
