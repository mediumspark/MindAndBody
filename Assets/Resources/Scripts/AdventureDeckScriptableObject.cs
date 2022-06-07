using UnityEngine;
using System.Collections.Generic;


[CreateAssetMenu(fileName = "Deck", menuName = "AdventureDeck")]
public class AdventureDeckScriptableObject : ScriptableObject
{
    /// <summary>
    /// The Cards listed in the deck's scriptable object are events that are not relient on player agency. 
    /// </summary>
    public List<Card> AdventureCards;
}