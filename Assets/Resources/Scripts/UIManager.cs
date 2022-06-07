using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro; 

public class UIManager : MonoBehaviour
{
    public static UIManager instance => FindObjectOfType<UIManager>();

    [SerializeField]
    TextMeshProUGUI DeckUI, MindUI, BodyUI; //These are temporary and just for mobile testing;

    public TextMeshProUGUI DescisionResult;
    public GameObject GameOverScreen;


    private void Update()
    {
        DeckUI.text = "Cards in Deck: " + PlayerStats.instance.HoldDeck.Count;
        MindUI.text = "Mind \n" + PlayerStats.instance.Mind;
        BodyUI.text = "Body \n" + PlayerStats.instance.Body;
    }

    public void ResultsOpen()
    {
        DescisionResult.transform.parent.gameObject.SetActive(true); 
        DescisionResult.GetComponentInParent<Animator>().Play("Entrance");
    }

    public void ResultsClose()
    {
        DescisionResult.GetComponentInParent<Animator>().Play("Exit");
    }

}
