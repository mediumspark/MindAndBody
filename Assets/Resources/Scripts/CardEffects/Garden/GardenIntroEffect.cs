public class GardenIntroEffect : EventCardEffect 
{
    private void OnEnable()
    {
        UIManager.instance.DescisionResult.text = "You wake in a garden it feels familiar and yet...you " +
            "don’t recall being here. On the left, there is a door that requires a puzzle. The right - a heavy door.";
        UIManager.instance.ResultsOpen(); 
    }

    public override void BodyTrigger()
    {
        base.BodyTrigger();
        UIManager.instance.DescisionResult.text = "As you approach the heavy door you are swarmed by a wave of rats.";
    }

    public override void MindTrigger()
    {
        base.MindTrigger();
        UIManager.instance.DescisionResult.text = "As you approach the puzzle door you are swarmed by a wave of rats.";
    }
}
