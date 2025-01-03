using UnityEngine;
using UnityEngine.SceneManagement;  // Needed to load scenes

public class OpenCredit : MonoBehaviour
{
    public void OnButtonClick()
    {
        // Load the "MAIN" scene when the button is clicked
        BackButtonManager.LoadScene("CREDIT");
    }
}
