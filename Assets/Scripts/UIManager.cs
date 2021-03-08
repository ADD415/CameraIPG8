using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text life;
    int lives = 3;
    private float time = 0;
    public GameObject timeUI;


    void Update()
    {
        time += Time.deltaTime;
        timeUI.gameObject.GetComponent<Text>().text = ("Time: " + (int)time);
    }

    public void lifeLost()
    {
        lives--;
        life.text = lives.ToString();
    }

}


