using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverLevel1Script : MonoBehaviour
{
    public int maxReplacements = 10; // Batas maksimal penggantian trebuchet
    private int replacementCount = 0; // Jumlah penggantian yang sudah dilakukan

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            replacementCount++;
            Debug.Log($"Reset Count: {replacementCount}");

            if (replacementCount >= maxReplacements)
            {
                Debug.Log("Max reset count reached. Redirecting to Game Over scene...");
                GoToGameOver();
            }
        }
    }
    private void GoToGameOver()
    {
        SceneManager.LoadScene("GAME OVER LEVEL 1"); // Ganti "GameOver" dengan nama scene kamu
    }
}
