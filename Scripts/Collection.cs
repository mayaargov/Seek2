using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collection : MonoBehaviour
{
    // Start is called before the first frame update
    public new Transform gameObject;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Find the ScoreManager and add points
            Score.AddScore();
            Destroy(gameObject); // Remove the item
        }
    }
}
