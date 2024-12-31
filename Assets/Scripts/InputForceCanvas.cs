using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputForceCanvas : MonoBehaviour
{
    public GameObject inputCanvas; // Canvas untuk input gaya
    public GameObject gameCanvas; // Canvas utama game
    //public GameObject trebuchet;   // referensi ke trebuchet
    public TMP_InputField forceInputField;
    public BallDoubleJump ballDoubleJump;   // Referensi ke script TrebuchetController

    // Start is called before the first frame update
    void Start()
    {
        ShowInputCanvas(); // Tampilkan input canvas saat game mulai
    }

    // Update is called once per frame
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
            //trebuchet.SetForce(force); // Set gaya di trebuchet
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
        // Tampilkan kembali Canvas InputForce
        if (inputCanvas != null)
        {
            inputCanvas.SetActive(true);
        }

        // Reset variabel jumpCount di BallDoubleJump
        if (ballDoubleJump != null)
        {
            ballDoubleJump.ResetJumpCount();
        }

        // Reset posisi atau kondisi lain jika diperlukan
    }
    //public void ResetGame()
    //{
    //    ShowInputCanvas(); // Tampilkan input canvas saat reset
    //}
}
