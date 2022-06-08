using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwipeControls : MonoBehaviour
{
    private Vector2 startTouchPosition;
    private Vector2 currentPosition;
    private Vector2 endTouchPosition;
    private bool stopTouch = false;

    public float swipeRange;
    public float tapRange;

    void Update()
    {
        Swipe();
    }

    public void Swipe()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            currentPosition = Input.GetTouch(0).position;
            Vector2 Distance = currentPosition - startTouchPosition;

            if (!stopTouch)
            {

                if (Distance.x < -swipeRange)
                {
                    //outputText.text = "Left";
                    DeckManager.instance.CommitToMind();
                    stopTouch = true;
                }
                else if (Distance.x > swipeRange)
                {
                    //outputText.text = "Right";
                    DeckManager.instance.CommitToBody(); 
                    stopTouch = true;
                }
                else if (Distance.y > swipeRange)
                {
                    //outputText.text = "Up";
                    stopTouch = true;
                }
                else if (Distance.y < -swipeRange)
                {
                    //outputText.text = "Down";
                    DeckManager.instance.AddToDeck();
                    stopTouch = true;
                }


            }

        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            stopTouch = false;

            endTouchPosition = Input.GetTouch(0).position;

            Vector2 Distance = endTouchPosition - startTouchPosition;

            if (Mathf.Abs(Distance.x) < tapRange && Mathf.Abs(Distance.y) < tapRange)
            {
                //FindObjectOfType<UIManager>().Tap.text = "Tap";
            }
        }
    }
}
