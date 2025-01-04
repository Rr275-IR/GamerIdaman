using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CheckForWin : MonoBehaviour
{
    public TMP_Text scoreText;
    void Update()
    {
        // Check if there are no objects with the "Target" tag
        if (GameObject.FindGameObjectsWithTag("Target").Length == 0 && scoreText.text == "Score: 100")
        {
            // Load the WIN scene
            BackButtonManager.LoadScene("WIN");
        }
    }
}
