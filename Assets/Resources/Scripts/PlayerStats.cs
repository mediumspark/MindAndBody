using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance; 

    public List<Card> HoldDeck;
    public int Mind, Body;

    private void Awake()
    {
        instance = this; 
    }

    public void PlayCard()
    {
        HoldDeck.RemoveAt(0);

    }
}
