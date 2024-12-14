using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckForWin : MonoBehaviour
{
    void Update()
    {
        // Check if there are no objects with the "Target" tag
        if (GameObject.FindGameObjectsWithTag("Target").Length == 0)
        {
            // Load the WIN scene
            SceneManager.LoadScene("WIN");
        }
    }
}
