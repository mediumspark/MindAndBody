using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeckManager : MonoBehaviour
{
    public static DeckManager instance;
    private DeckGenerator DeckGen;
    public AdventureDeckScriptableObject ADeckSO;

    [SerializeField]
    private GameObject CurrentCard;

    public CardEffectObject CurrentCardEffect => CurrentCard.GetComponent<CardEffectObject>();

    [SerializeField]
    private List<Card> ItemDeck;

    public List<Card> AdventureDeck;

    private void Awake()
    {
        instance = this; 
    }

    private void Start()
    {
        DeckGen = new DeckGenerator();
        DeckGen.Generate(); 
        FillDeck();
        CreateCard(ItemDeck[0]);
    }

    /// <summary>
    /// Creates a playable card and assigns the card's game component 
    /// </summary>
    /// <param name="C"></param>
    public void CreateCard(Card C)
    {
        GameObject go = Instantiate(C.CardEffectPrefab, gameObject.transform);

        switch (C.EffectName)
        {
            #region Items
            case "Sword":
                go.AddComponent<SwordEffect>();
                break;

            case "Shield":
                go.AddComponent<ShieldEffect>();
                break;

            case "Bow":
                go.AddComponent<BowEffect>();
                break;
            case "Sling":
                go.AddComponent<SlingEffect>();
                break;
            case "Lantern":
                go.AddComponent<LanternEffect>();
                break;
            case "Book":
                go.AddComponent<BookEffect>();
                break;
            case "Lance":
                go.AddComponent<LanceEffect>();
                break;
            case "GardenSword":
                go.AddComponent<GardenSwordEffect>();
                break;
            case "DawkinsRazor":
                go.AddComponent<DawkinsRazorEffect>();
                break;
            case "MawBlade":
                go.AddComponent<MawBladeEffect>();
                break;
            case "RatsBane":
                go.AddComponent<RatsBaneEffect>();
                break;
            case "CibophileJaws":
                go.AddComponent<CibophileJawsEffect>();
                break;
            #endregion
            #region Events
            #region Garden
            case "Garden":
                go.AddComponent<GardenEffect>();
                break;

            case "EndlessMischief":
                go.AddComponent<EndlessMischiefEffect>();
                break;

            case "GardenEnd":
                go.AddComponent<GardenEndEffect>();
                break;

            case "GardenIntro":
                go.AddComponent<GardenIntroEffect>();
                break;
            #endregion
            #region Pit
            case "TheGreatPit1":
                go.AddComponent<TheGreatPitEffect_1>();
                break;
            case "TheGreatPit2":
                go.AddComponent<TheGreatPitEffect_2>();
                break;
            case "TokenNightmare":
                go.AddComponent<TokenNightmareEffect>();
                break;
            case "TheBumpInTheDarkness":
                go.AddComponent<TheBumpInTheDarkness>();
                break;
            case "TorchGoblin":
                go.AddComponent<TorchGoblinEffect>();
                break;
            case "TrapDoor":
                go.AddComponent<TrapDoorEffect>();
                break;
            case "BedOfFlames":
                go.AddComponent<BedofFlamesEffect>();
                break;
            case "LadderFromPit":
                go.AddComponent<LadderFromThePitEffect>();
                break;
            case "DoorFromThePit":
                go.AddComponent<DoorFromThePitEffect>();
                break;
            case "TalkativeSpiderling":
                go.AddComponent<TalkativeSpiderlingEffect>();
                break;
            case "BumpInTheDarkness":
                go.AddComponent<TheBumpInTheDarkness>();
                break;
            case "DoorAtTheEndM":
                go.AddComponent<TheDoorAtTheEndOfThePit_1>();
                break;
            case "DoorAtTheEndP":
                go.AddComponent<TheDoorAtTheEndOfThePit_2>();
                break;
            case "TrapWall":
                go.AddComponent<TrapWallEffect>();
                break;
            #endregion
            #region Inn
            case "BackOfInn":
                go.AddComponent<BackOfInnEffect>();
                break;
            case "AroundTheFacility":
                go.AddComponent<AroundTheFacility>();
                break;
            case "BeingFromMaw":
                go.AddComponent<BeingFromTheMawEffect>();
                break;
            case "Floor2":
                go.AddComponent<Floor_2Effect>();
                break;
            case "MawServent1":
                go.AddComponent<MawServent_1Effect>();
                break;
            case "MawServent2":
                go.AddComponent<MawServent_2Effect>();
                break;
            case "MawServent3":
                go.AddComponent<MawServent_3Effect>();
                break;
            case "Room1":
                go.AddComponent<Room_1Effect>();
                break;
            case "Room5":
                go.AddComponent<Room_5Effect>();
                break;
            case "SideOfInn":
                go.AddComponent<SideOfInnEffect>();
                break;
            case "TheCorruption":
                go.AddComponent<TheCorruptionEffect>();
                break;
            case "TheMaw":
                go.AddComponent<TheMawEffect>();
                break; 
            #endregion
            #endregion
            default:
                go.AddComponent<UnderConstructionEffect>();
                break;
        }

        go.GetComponent<CardEffectObject>().SetCardBase = C;
        CurrentCard = go;

        CurrentCard.GetComponent<CardEffectObject>().SetCard();
    }

    /// <summary>
    /// Fills a deck depending on the phase.
    /// Item deck gets 5 cards 
    /// </summary>
    public void FillDeck()
    {
        if (GameManager.instance.CurrentPhase == Phases.Bag)
        {
            for (int i = 0; i < 5; i++)
            {
                ItemDeck.Add(DeckGen.ItemGeneration());
            }
        }
        else if (GameManager.instance.CurrentPhase == Phases.Adventure)
        {
            AdventureDeck.AddRange(ADeckSO.AdventureCards);
        }
    }

    public IEnumerator<WaitForSeconds> NextCard()
    {
        yield return new WaitForSeconds(0.5f);

        if (GameManager.instance.CurrentPhase == Phases.Bag)
        {
            UIManager.instance.DescisionResult.gameObject.SetActive(false);
            ItemDeck.RemoveAt(0);
            Destroy(CurrentCard);
            if (ItemDeck.Count > 0)
            {
                CreateCard(ItemDeck[0]);
            }
            else
            {
                GameManager.instance.CurrentPhase = Phases.Adventure;
                FillDeck();
                StartCoroutine(NextCard());
            }
        }// Make sure decision result is hidden
         // And *essentially* pop the ItemDeck 
        else
        {

            if (AdventureDeck.Count > 1)
            {
                AdventureDeck.RemoveAt(0);
                Destroy(CurrentCard);
                CreateCard(AdventureDeck[0]);
            }

            //Adventure Deck cards create the next adventure deck card before going to next
            //so if the count is 0 the Adventure has been cleared

            else
            {
                ItemDeck.Clear();

                GameManager.instance.CurrentPhase = Phases.Bag;
                FillDeck();
                StartCoroutine(NextCard());
            }
        }
    }

    /// <summary>
    /// Add the current item card to the deck
    /// if not in item phase this command allows the user to use the top card in their deck
    /// </summary>
    public void AddToDeck()
    {
        if (CurrentCard.TryGetComponent<ItemCardEffect>(out ItemCardEffect ItemCard))
        {
            if (PlayerStats.instance.Body <= 0 || PlayerStats.instance.Mind <= 0)
            {
                UIManager.instance.DescisionResult.text = "You are too weak to add this to your deck";
            }
            else
            {
                UIManager.instance.DescisionResult.text = "";
                CurrentCard.GetComponent<CardEffectObject>().MoveCard(MovementDirection.Down, NextCard());
                PlayerStats.instance.HoldDeck.Add(CurrentCard.GetComponent<CardEffectObject>().Card); 
            }
        }
        else
        {
            CardEffectDictionary.UseCard(PlayerStats.instance.HoldDeck[0].EffectName, PlayerStats.instance.HoldDeck[0]);
        }
    }

    /* Mind and Body Commits for Events will need to show results of your event choices and then lead*/

    public void CommitToMind()
    {
        CurrentCard.GetComponent<CardEffectObject>().MindTrigger();
        CurrentCard.GetComponent<CardEffectObject>().MoveCard(MovementDirection.Left, NextCard()); 
    }
    public void CommitToBody()
    {
        CurrentCard.GetComponent<CardEffectObject>().BodyTrigger();
        CurrentCard.GetComponent<CardEffectObject>().MoveCard(MovementDirection.Right, NextCard());
    }
}
