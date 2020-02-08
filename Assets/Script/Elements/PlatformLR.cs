using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLR : MonoBehaviour
{
    private float startPos;
    private float endPos;
    public float moveSpeed;
    public int unitToMove;
    public bool moveRight;

    public bool canMove;

    void Start()
    {
        canMove = false;
        startPos = transform.position.x;
        endPos = startPos + unitToMove;
    }

    void Update()
    {
        if (canMove)
        {
            if (moveRight)
            {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            }
            if (transform.position.x >= endPos)
            {
                moveRight = false;
            }

            if (!moveRight)
            {
                transform.position -= Vector3.right * moveSpeed * Time.deltaTime;
            }
            if (transform.position.x <= startPos)
            {
                moveRight = true;
            }
        }

     
    }
}