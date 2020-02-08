using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool trigger;
    private bool onCligno;
    public float intervalle;
    private float t;
    public int nbCligno;
    private Sprite spr;

    private PolygonCollider2D pc2d;

    private void Start()
    {
        pc2d = GetComponent<PolygonCollider2D>();
        trigger = false;
        intervalle = transform.localScale.y / 2;
        onCligno = true;
        spr = GetComponent<SpriteRenderer>().sprite;

    }
    internal void Open()
    {
        trigger = true;
        t = Time.time;
        GetComponent<SpriteRenderer>().sprite = null;
        pc2d.enabled = false;
    }

    private void Update()
    {
        if (trigger)
        {
            //clignotement ???
            /*if(Time.time - t > intervalle)
            {
                if (onCligno) // cas ou il est allumer et doit s'éteindre
                {
                    GetComponent<SpriteRenderer>().sprite = null;
;                }
                else//l'autre
                {
                    GetComponent<SpriteRenderer>().sprite = spr;
                }
                t = Time.time;
                onCligno = !onCligno;
                intervalle -= intervalle / 5;
                nbCligno++;
            }*/
        }
    }

    internal void close()
    {
        GetComponent<SpriteRenderer>().sprite = spr;
        pc2d.enabled = true;
    }
}
