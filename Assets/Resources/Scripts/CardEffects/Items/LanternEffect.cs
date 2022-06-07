public class LanternEffect : ItemCardEffect
{
    public override void BodyTrigger()
    {
        PlayerStats.instance.Body += CardBase.BodyMod;
    }

    public override void MindTrigger()
    {
        PlayerStats.instance.Mind += CardBase.MindMod;
        PlayerStats.instance.Body += CardBase.MindMod; 
    }

    public override void OnUseFromDeck()
    {
        base.OnUseFromDeck();
        PlayerStats.instance.Mind *= 2; 
    }
}