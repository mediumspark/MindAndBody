using UnityEngine;
using System.Collections.Generic;

public enum CardType { EventCard, ItemCard}

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public CardType CardType; 
    public int MindMod, BodyMod;
    public string EffectDesc, EffectName;
    public GameObject CardEffectPrefab;
    public Sprite ForgroundSprite; 
}
