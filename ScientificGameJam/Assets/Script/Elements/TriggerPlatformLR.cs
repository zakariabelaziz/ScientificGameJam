using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlatformLR : MonoBehaviour
{
    public GameObject plateformLR;
    private PlatformLR platformScript;

    void Start()
    {
        platformScript = FindObjectOfType<PlatformLR>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Player2"))
        {
            platformScript.canMove = true;
        }
    }
}
