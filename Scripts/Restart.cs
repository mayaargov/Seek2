using UnityEngine;
using UnityEngine.SceneManagement; // Essential for scene control

public class Restart : MonoBehaviour
{
    
    public void ResetScene()
    {
        // Reloads the scene currently active
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // Note: If you have paused time (e.g., a pause menu), reset it here
       // Time.timeScale = 1f;
    }
}