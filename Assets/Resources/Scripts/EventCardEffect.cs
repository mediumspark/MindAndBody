public class EventCardEffect : CardEffectObject
{
    public override void MindTrigger()
    {
        PlayerStats.instance.Mind -= CardBase.MindMod;
        base.MindTrigger();
        UIManager.instance.ResultsOpen();
    }

    public override void BodyTrigger()
    {
        PlayerStats.instance.Body -= CardBase.BodyMod;
        base.BodyTrigger();
        UIManager.instance.ResultsOpen();
    }
}