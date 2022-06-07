using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneChanger : MonoBehaviour
{
    private static Animator _animator; 

    private void Awake()
    {
        if(FindObjectOfType<SceneChanger>() != this) 
            DontDestroyOnLoad(gameObject);
        else
        {
            Destroy(gameObject); 
        }
        
        _animator = GetComponentInChildren<Animator>();
    }


    public static void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public static void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
