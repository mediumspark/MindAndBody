public class BookEffect : ItemCardEffect
{
    public override void BodyTrigger()
    {
        PlayerStats.instance.Body += CardBase.BodyMod / 2;
    }

    public override void MindTrigger()
    {
        PlayerStats.instance.Mind += CardBase.MindMod * 2;
        PlayerStats.instance.Body += CardBase.MindMod; 
    }

    public override void OnUseFromDeck()
    {
        base.OnUseFromDeck();
        UIManager.instance.DescisionResult.text = $"{FindObjectOfType<EventCardEffect>().BodyMod}/ {FindObjectOfType<EventCardEffect>().MindMod}";
    }
}