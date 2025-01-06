using UnityEngine;
using UnityEngine.SceneManagement;  // Needed to load scenes

public class LoadMainScene : MonoBehaviour
{
    public void OnButtonClick()
    {
        BackButtonManager.LoadScene("LEVEL");
    }
}
