using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinConditionsLevel2 : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    public string nextSceneName;

    public bool the2Player;

    //public GameObject messagePanel;
    public float timeBeforeClosePanel;

    private PlayerController playerScript;


    void Start()
    {
        playerScript = FindObjectOfType<PlayerController>();
        player1 = GameObject.FindGameObjectWithTag("Player");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        the2Player = false;
        Invoke("CloseStartMessage", timeBeforeClosePanel);

    }

    void CloseStartMessage()
    {
       // messagePanel.gameObject.SetActive(false);
    }


    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            the2Player = true;
            Debug.Log("ok collision p2");
        }


        if (collision.gameObject.tag == "Player2" && the2Player)
        {
            Debug.Log("ok collision p2");
            TriggerPiston();
        }
    }
    void TriggerPiston()
    {
        if (!playerScript.eau && playerScript.metal && !playerScript.alcool)
        {
            Invoke("TriggerNextScene", 1f);
        }
    }

    void TriggerNextScene()
    {

        SceneManager.LoadScene(nextSceneName);
    }
}

