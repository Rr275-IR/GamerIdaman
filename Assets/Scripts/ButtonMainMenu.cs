using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMainMenu : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void GoToPilihMainMenu()
    {
        BackButtonManager.LoadScene("New Scene"); 
    }
}
