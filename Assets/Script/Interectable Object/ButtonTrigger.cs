using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public Sprite pressedButton;
    public Sprite releaseButton;
    private float t;
    private bool isTrigger;
    public float timerReleased = 3;
    public Door d;

    private void Start()
    {
        isTrigger = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="Player2")
        {
            isTrigger = false;
            GetComponent<SpriteRenderer>().sprite = pressedButton;
            d.Open();
        }

        if (collision.gameObject.tag == "Player")
        {
            isTrigger = false;
            GetComponent<SpriteRenderer>().sprite = pressedButton;
            d.Open();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player2")
        {
            t = Time.time;
            isTrigger = true;
        }
        if (collision.gameObject.tag == "Player")
        {
            t = Time.time;
            isTrigger = true;
        }

    }

    private void Update()
    {
            if (isTrigger && Time.time-t > timerReleased)
        {
            GetComponent<SpriteRenderer>().sprite = releaseButton;
            isTrigger = false;
            d.close();
        }
    }
}
