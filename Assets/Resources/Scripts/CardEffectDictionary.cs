using System.Collections.Generic;
using UnityEngine;

public struct CardEffectDictionary
{
    private static Dictionary<string, CardEffectObject> Effect;
    private static GameObject Object;
    private static List<GameObject> SummonedObjects; 


    private static void Innitialize()
    {
        if (SummonedObjects != null)
        {         
            foreach(GameObject go in SummonedObjects)
            {
                UnityEngine.Object.Destroy(go);
            }
        }

        Effect = new Dictionary<string, CardEffectObject>();
        Effect.Add("Sword", new GameObject().AddComponent<SwordEffect>()); 
        Effect.Add("Shield", new GameObject().AddComponent<ShieldEffect>()); 
        Effect.Add("Bow", new GameObject().AddComponent<BowEffect>()); 
        Effect.Add("Lantern", new GameObject().AddComponent<LanternEffect>()); 
        Effect.Add("Book", new GameObject().AddComponent<BookEffect>()); 
        Effect.Add("Lance", new GameObject().AddComponent<LanceEffect>()); 
        Effect.Add("GardenSword", new GameObject().AddComponent<GardenSwordEffect>()); 
        Effect.Add("DawkinsRazor", new GameObject().AddComponent<DawkinsRazorEffect>()); 
        Effect.Add("MawBlade", new GameObject().AddComponent<MawBladeEffect>()); 
        Effect.Add("RatsBane", new GameObject().AddComponent<RatsBaneEffect>()); 
        Effect.Add("CibophileJaws", new GameObject().AddComponent<CibophileJawsEffect>());

        SummonedObjects = new List<GameObject>(); 

        foreach (KeyValuePair<string, CardEffectObject> CO in Effect)
        {
            SummonedObjects.Add(CO.Value.gameObject); 
        }

    }

    public static CardEffectObject getEffectName(string Index)
    {
        try
        {
            Innitialize();
            return Effect[Index]; 
        }
        catch
        {
            Debug.LogError($"No Effect at {Index}");
            return null;
        }
    }

    public static void UseCard(string name, Card Card)
    {
        CardEffectObject ActiveCard = getEffectName(name);

        try 
        {
            if (ActiveCard is ItemCardEffect)
            {
            var C = ActiveCard as ItemCardEffect;
            C.SetCardBase = Card;

            C.BodyMod = Card.BodyMod;
            C.MindMod = Card.MindMod; 

            C.OnUseFromDeck();
            PlayerStats.instance.PlayCard();
            UIManager.instance.DescisionResult.text = $"You played {name}";
            }
        }
        catch
        {
            string EmptyNotify = "Deck Empty";
            Debug.LogWarning(EmptyNotify);
            UIManager.instance.DescisionResult.text = EmptyNotify;
        }
    }
}
