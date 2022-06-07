public class DawkinsRazorEffect : ItemCardEffect
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
        FindObjectOfType<EventCardEffect>().BodyMod = 0;
        PlayerStats.instance.Body /= 2; 
    }
}
