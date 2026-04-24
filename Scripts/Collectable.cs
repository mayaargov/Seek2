using TMPro;
using UnityEngine;
using UnityEngine.UI; // Required if using standard UI Text

public class Collectible : MonoBehaviour
{
    public GameObject uiPrompt; // Assign your "Press E to Collect" UI element here
    private bool canCollect = false;
    public  TMP_Text scoreText;
    public static int score = 0;

    void Start()
    {
        uiPrompt.SetActive(false); // Hide prompt by default
    }

    void Update()
    {
        // Check if player is in range AND presses the 'E' key
        if (canCollect && Input.GetKeyDown(KeyCode.E))
        {
            Collect();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiPrompt.SetActive(true);
            canCollect = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiPrompt.SetActive(false);
            canCollect = false;
        }
    }

    void Collect()
    {
        Debug.Log("Item Collected!");
        
        // Add to inventory logic here
        Destroy(gameObject); // Remove the item from the scene
        //Score.AddScore();
        score = score + 1;
        scoreText.text = $"Fruit found: {score}/{Timer.fruitesneeded}";
       
    }
}