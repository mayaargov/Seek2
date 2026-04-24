using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    public int fruitesneeded;
    public int Lcounter = 1;
    public GameObject uiPrompt;

    // Update is called once per frame
    void Update()
    {
        if (Lcounter == 1)
        {
            fruitesneeded = 4;
        }
        if(Collectible.score == fruitesneeded)
        {
            uiPrompt.SetActive(true);
        }
    }
}
