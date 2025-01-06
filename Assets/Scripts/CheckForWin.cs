using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CheckForWin : MonoBehaviour
{
    public TMP_Text scoreText;
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Target").Length == 0)
        {
            BackButtonManager.LoadScene("WIN");
        }
    }
}
