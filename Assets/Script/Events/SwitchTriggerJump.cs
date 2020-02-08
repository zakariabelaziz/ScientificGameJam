using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTriggerJump : MonoBehaviour
{
    public GameObject pad_Inactive;


    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player2"))
        {
            Debug.Log("oko collisio,");
            pad_Inactive.gameObject.SetActive(true);
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 255);
        }
    }
}
