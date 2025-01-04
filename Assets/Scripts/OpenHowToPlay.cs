using UnityEngine;
using UnityEngine.SceneManagement;  // Needed to load scenes

public class OpenHowToPlay : MonoBehaviour
{
    public void OnButtonClick()
    {
        // Load the "MAIN" scene when the button is clicked
        BackButtonManager.LoadScene("HOW TO PLAY");
    }
}
