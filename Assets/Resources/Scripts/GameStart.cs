using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameStart : MonoBehaviour
{
    private SceneChanger _SceneChanger;
    [SerializeField]
    private Button _StartButton, _HowToPlayButton;
    [SerializeField]
    private GameObject MainMenu, HowToPlay; 

    private void Awake()
    {
        _SceneChanger = FindObjectOfType<SceneChanger>() ?? new GameObject().AddComponent<SceneChanger>();

        _StartButton.onClick.AddListener(() => SceneChanger.StartGame());
        _HowToPlayButton.onClick.AddListener(() => OpenHowToPlay()); 
    }

    private void OpenHowToPlay()
    {
        MainMenu.SetActive(false);
        HowToPlay.SetActive(true);
    }

    public void BackToMainMenu()
    {
        HowToPlay.SetActive(false);
        MainMenu.SetActive(true); 
    }
}
