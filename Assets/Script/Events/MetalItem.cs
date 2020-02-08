using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalItem : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    private PlayerController player1Script;



    void Start()
    {
        player1Script = FindObjectOfType<PlayerController>();
        player1 = GameObject.FindGameObjectWithTag("Player");
        player2 = GameObject.FindGameObjectWithTag("Player2");

    }


    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            player1Script.GetComponent<SpriteRenderer>().color = new Color(0 ,0, 0, 255);
            player1Script.eau = false;
            player1Script.alcool = false;
            player1Script.metal = true;
            player1Script.GetComponent<Rigidbody2D>().gravityScale = 7f;
            player1Script.speed = 2;
            

        }
    }


}
