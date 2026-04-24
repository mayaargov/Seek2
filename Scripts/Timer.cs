using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeRemaining = 180; // Starting time in seconds
    public bool timerIsRunning = false;
    public TMP_Text timeText;
    public GameObject uiPrompt;
    public GameObject uiPrompt2;
    public static int fruitesneeded;
    public int Lcounter = 1;
    public GameObject uiPrompt3;
    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                uiPrompt.SetActive(true);
                uiPrompt2.SetActive(false);
                Cursor.lockState = CursorLockMode.None;
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
        if (Lcounter == 1)
        {
            fruitesneeded = 4;
        }
        if (Collectible.score == fruitesneeded)
        {
            uiPrompt3.SetActive(true);
            uiPrompt2.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
