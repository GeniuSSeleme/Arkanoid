using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUi : MonoBehaviour
{
    int score = 0;
    public Text textUi;
    // Update is called once per frame
    void Update()
    {
        /*if ()
        {

        }*/
    }

    public void IncrementScore()
    {
        score++;
        textUi.text = "score: " + score;
    }
}

