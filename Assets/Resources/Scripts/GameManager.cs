using UnityEngine;
using UnityEngine.SceneManagement; 
using TMPro; 

public enum Phases { Bag, Adventure }
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    GameObject GOScreen;

    public Phases CurrentPhase;
    private void Awake()
    {
        CurrentPhase = Phases.Bag;
        instance = this; 
        GOScreen = UIManager.instance.GameOverScreen;
        GOScreen.SetActive(false); 
    }

    private void Update()
    {
        if(CurrentPhase == Phases.Adventure && (PlayerStats.instance.Body <= 0 || PlayerStats.instance.Mind <= 0))
        {
            GameOver(); 
        }
    }

    public void ReStart()
    {
        SceneManager.LoadScene(0);
    }

    private void GameOver()
    {
        DeckManager.instance.CurrentCardEffect.gameObject.SetActive(false); 

        GOScreen.SetActive(true); 
        string GameoverText = ""; 
        
        
        if(PlayerStats.instance.Mind <= 0)
        {
            GameoverText += "You fell to the ground, screeming in pain, your mind broken and swirling in the midness of this endless space. ";
        }

        if (PlayerStats.instance.Body <= 0)
        {
            GameoverText += "And before you knew it, your body gave way. Blacking out and unable to move. It surrendered. This is not a place you would leave and it finally aggreed. ";
        }
        GOScreen.GetComponentInChildren<TextMeshProUGUI>().text = GameoverText;
    }
}
