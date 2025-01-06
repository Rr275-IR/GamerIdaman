using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputForceCanvas : MonoBehaviour
{
    public GameObject inputCanvas; 
    public GameObject gameCanvas; 
    public TMP_Text saveForce;
    public TMP_InputField forceInputField;

    void Start()
    {
        inputCanvas = GameObject.FindGameObjectWithTag("InputForce");
        gameCanvas = GameObject.FindGameObjectWithTag("GameCanvas");
        ShowInputCanvas();
    }

    void Update()
    {
        
    }
    public void ShowInputCanvas()
    {
        inputCanvas.SetActive(true);
        gameCanvas.SetActive(false); // Sembunyikan canvas utama
    }

    public void SubmitForce()
    {
        if (float.TryParse(forceInputField.text, out float force))
        {
            GameObject temp = GameObject.FindGameObjectWithTag("ForceSave");
            saveForce = temp.GetComponent<TMP_Text>();
            saveForce.text = forceInputField.text;
            inputCanvas.SetActive(false);
            gameCanvas.SetActive(true); // Tampilkan canvas utama
        }
        else
        {
            Debug.LogError("Input tidak valid! Masukkan angka.");
        }
    }
    public void ResetGame()
    {
        if (inputCanvas != null)
        {
            inputCanvas.SetActive(true);
        }
    }

}
