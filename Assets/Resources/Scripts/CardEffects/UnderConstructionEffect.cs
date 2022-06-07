public class UnderConstructionEffect : EventCardEffect 
{
    private void Awake()
    {
        FindObjectOfType<UIManager>().DescisionResult.text = " This Card is Underconstruction. It is time to start over";
    }
}
