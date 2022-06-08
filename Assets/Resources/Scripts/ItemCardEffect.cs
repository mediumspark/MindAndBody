using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemCardEffect : CardEffectObject
{
    //overriden so that a mind/body mod can be given to the player 
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
