using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;


public enum MovementDirection { Up, Right, Left, Down, nil }

public class CardEffectObject : MonoBehaviour
{
    [SerializeField]
    protected Card CardBase;
    public Card SetCardBase { set => CardBase = value; }
    public Card Card => CardBase; 
    public int MindMod, BodyMod; 

    MovementDirection MD = MovementDirection.nil; 

    [SerializeField]
    protected TextMeshProUGUI Description;

    [SerializeField]
    protected Image Secondary; 

    /// <summary>
    /// Used as a modifier in the Items and used to create paths in the Event Cards
    /// </summary>
    public virtual void BodyTrigger()
    {
    }

    /// <summary>
    /// Used as a modifier in the Items and used to create paths in the Events
    /// </summary>
    public virtual void MindTrigger()
    {
    }

    private void Update()
    {
        switch (MD)
        {
            case MovementDirection.Down:
                transform.Translate(Vector3.down * 200);
                break;
            case MovementDirection.Up:
                transform.Translate(Vector3.up * 200);
                break;
            case MovementDirection.Left:
                transform.Translate(Vector3.left * 200);
                break;
            case MovementDirection.Right:
                transform.Translate(Vector3.right * 200);
                break;
            default: break; 
        }
    }

    public virtual void SetCard()
    {
        Secondary = transform.GetChild(0).GetChild(0).GetComponent<Image>();

        Secondary.sprite = CardBase.ForgroundSprite;
        MindMod = CardBase.MindMod; 
        BodyMod = CardBase.BodyMod;
    }

    public void MoveCard(MovementDirection MD, IEnumerator<WaitForSeconds> nextCard)
    {
        StartCoroutine(nextCard);
        this.MD = MD; 
    }
}

public class ItemCardEffect : CardEffectObject
{
    public override void SetCard()
    {
        Secondary = transform.GetChild(0).GetChild(0).GetComponent<Image>();
        Description = Secondary.GetComponentInChildren<TextMeshProUGUI>();

        Description.text = $"{CardBase.MindMod}M/{CardBase.BodyMod}B";
        Secondary.sprite = CardBase.ForgroundSprite;
        MindMod = CardBase.MindMod;
        BodyMod = CardBase.BodyMod;

        UIManager.instance.DescisionResult.text = CardBase.EffectName; 
    }

    public virtual void OnUseFromDeck()
    {
        if (GameManager.instance.CurrentPhase == Phases.Bag)
        {
            PlayerStats.instance.HoldDeck.Add(CardBase);
            return; 
        }
        else
        {
            Debug.Log("Playing card");
        }
    }
}
