public class ShieldEffect : ItemCardEffect
{
    public override void BodyTrigger()
    {
        PlayerStats.instance.Body += CardBase.BodyMod;
        PlayerStats.instance.Mind -= CardBase.MindMod / 2;

    }

    public override void MindTrigger()
    {
        PlayerStats.instance.Mind += CardBase.MindMod + (CardBase.MindMod * 2 + 2);
    }

    public override void OnUseFromDeck()
    {
        base.OnUseFromDeck();

        if (PlayerStats.instance.Mind > PlayerStats.instance.Body)
            PlayerStats.instance.Mind += CardBase.MindMod;

        else
            PlayerStats.instance.Body += CardBase.BodyMod;
    }
}