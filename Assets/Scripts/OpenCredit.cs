using UnityEngine;
using UnityEngine.SceneManagement;  

public class OpenCredit : MonoBehaviour
{
    public void OnButtonClick()
    {

        BackButtonManager.LoadScene("CREDIT");
    }
}
