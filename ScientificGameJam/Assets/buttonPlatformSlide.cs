using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPlatformSlide : MonoBehaviour
{
    public Sprite pressedButton;
    public Sprite releaseButton;
    public MouvPlateform plat;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player2")
        {
            plat.activeplat = true;
            GetComponent<SpriteRenderer>().sprite = pressedButton;
        }

        if (collision.gameObject.tag == "Player")
        {
            plat.activeplat = true;
            GetComponent<SpriteRenderer>().sprite = pressedButton;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player2")
        {
            plat.activeplat = false;
            GetComponent<SpriteRenderer>().sprite = releaseButton;
        }

        if (collision.gameObject.tag == "Player")
        {
            plat.activeplat = false;
            GetComponent<SpriteRenderer>().sprite = releaseButton;
        }
    }

}
