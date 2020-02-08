using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeGO : MonoBehaviour
{
    public float endTime;

    private SpriteRenderer spriteRenderer;
    private Color start;
    private Color end;
    private float time = 0.0f;
    float delatTime;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        start = spriteRenderer.color;
        end = new Color(start.r, start.g, start.b, 0.0f);
        delatTime = Time.deltaTime;
    }


    void Update()
    {
        time += delatTime;
        GetComponent<Renderer>().material.color = Color.Lerp(start, end, time / endTime);
        if (GetComponent<Renderer>().material.color.a <= 0.0f)
        {
            Destroy(gameObject);
        }
    }
}