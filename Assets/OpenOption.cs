using UnityEngine;
using UnityEngine.SceneManagement;  // Needed to load scenes

public class OpenOption : MonoBehaviour
{
    public void OnButtonClick()
    {
        // Load the "MAIN" scene when the button is clicked
        BackButtonManager.LoadScene("OPTION");
    }
}
