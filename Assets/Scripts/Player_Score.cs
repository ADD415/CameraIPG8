using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{
    public int playerScore = 0;
    public GameObject playerScoreUI;

    void Update()
    {
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
    }

    void OnTriggerEnter2D (Collider2D trig)
    {

        if (trig.gameObject.name == "Object")
        {
            playerScore += 10;
            Destroy(trig.gameObject);
        }
    }
}  
