using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene4Score : MonoBehaviour
{

    public int score;
    public int death;
    public Text text;
    public Text deathtext;

    void Awake()
    {
        score = 0;
        death = 0;
    }

    void Update()
    {
        score = PlayerPrefs.GetInt("score");
        text.text = "Score: " + (score - 1);
        death = PlayerPrefs.GetInt("death");
        deathtext.text = "Deaths: " + death;
    }


}
