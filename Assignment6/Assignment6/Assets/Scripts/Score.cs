using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score;
    public Text text;

    void Awake()
    {
        score = 0;
    }

    void Update()
    {
        score = PlayerPrefs.GetInt("score");
        text.text = "Score: " + score;
    }

   
}
