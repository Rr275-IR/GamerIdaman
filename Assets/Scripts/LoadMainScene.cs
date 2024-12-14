using UnityEngine;
using UnityEngine.SceneManagement;  // Needed to load scenes

public class LoadMainScene : MonoBehaviour
{
    public void OnButtonClick()
    {
        // Load the "MAIN" scene when the button is clicked
        BackButtonManager.LoadScene("LEVEL");
    }
}
