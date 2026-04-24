using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public static TMP_Text scoreText;
    public static int score = 0;

    public static TMP_Text GetScoreText()
    {
        return scoreText;
    }

    public static void AddScore()
    {
        score = score + 1;
        scoreText.text = score.ToString();
    }
}
