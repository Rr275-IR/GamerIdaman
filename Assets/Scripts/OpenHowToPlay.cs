using UnityEngine;
using UnityEngine.SceneManagement; 

public class OpenHowToPlay : MonoBehaviour
{
    public void OnButtonClick()
    {
        BackButtonManager.LoadScene("HOW TO PLAY");
    }
}
