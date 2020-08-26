using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text txt;

    public static int maxScore;

    public static int lastScore;

    public void SetText(int score)
    {
        txt.text = "Score: " + score;

        if (maxScore < score)
        {
            maxScore = score;
        }

        lastScore = score;

    }
    private void Start()
    {
        lastScore = 0;
    }
}
