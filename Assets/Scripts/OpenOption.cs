using UnityEngine;
using UnityEngine.SceneManagement;  

public class OpenOption : MonoBehaviour
{
    public void OnButtonClick()
    {
        BackButtonManager.LoadScene("OPTION");
    }
}
