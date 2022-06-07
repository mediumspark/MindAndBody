public class LanceEffect : ItemCardEffect
{

    public override void BodyTrigger()
    {
        PlayerStats.instance.Body += CardBase.BodyMod + CardBase.MindMod;

        base.BodyTrigger();
    }

    public override void MindTrigger()
    {
        PlayerStats.instance.Mind += CardBase.BodyMod + CardBase.MindMod;
        PlayerStats.instance.Mind += CardBase.BodyMod - CardBase.MindMod;

        base.MindTrigger();
    }

    public override void OnUseFromDeck()
    {
        base.OnUseFromDeck();
        UIManager.instance.DescisionResult.text = $"{FindObjectOfType<EventCardEffect>().BodyMod}";
    }
}