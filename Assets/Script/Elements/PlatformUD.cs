using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUD : MonoBehaviour
{
    private float startPos;
    private float endPos;
    public float moveSpeed;
    public int unitToMove;
    public bool moveUp;


    void Start()
    {
        startPos = transform.position.y;
        endPos = startPos + unitToMove;
    }

    void Update()
    {
        if (moveUp)
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        if (transform.position.y >= endPos)
        {
            moveUp = false;
        }

        if (!moveUp)
        {
            transform.position -= Vector3.up * moveSpeed * Time.deltaTime;
        }
        if (transform.position.y <= startPos)
        {
            moveUp = true;
        }
    }
}


