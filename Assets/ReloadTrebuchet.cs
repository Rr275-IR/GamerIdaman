using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Tambahkan ini untuk Scene Management

public class ReloadTrebuchet : MonoBehaviour
{
    public GameObject trebuchetPrefab; // Assign the Trebuchet prefab here
    public Transform spawnPoint; // Assign a spawn point in the scene
    public int maxReplacements = 10; // Maximum number of replacements allowed
    public TMP_Text replacementText;
    private int replacementCount = 0; // Tracks how many times the trebuchet has been replaced

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (replacementCount < maxReplacements)
            {
                ReplaceTrebuchet();
            }
            else
            {
                Debug.Log("Trebuchet replacement limit reached!");
                GoToGameOver(); // Pindah ke Game Over Scene jika limit tercapai
            }
        }
    }

    public void ReplaceTrebuchet()
    {
        GameObject[] existingTrebuchets = GameObject.FindGameObjectsWithTag("Trebuchet");
        foreach (GameObject trebuchet in existingTrebuchets)
        {
            Destroy(trebuchet);
        }
        GameObject newTrebuchet = Instantiate(trebuchetPrefab, spawnPoint.position, spawnPoint.rotation);
        newTrebuchet.name = "TREBUCHET"; // Rename for consistency
        newTrebuchet.tag = "Trebuchet";  // Assign the tag for future recognition
        replacementCount++;
        UpdateRemainingReplacementsText();
    }

    private void UpdateRemainingReplacementsText()
    {
        if (replacementText != null)
        {
            replacementText.text = $"Replacements Left: {maxReplacements - replacementCount}";
        }
    }

    private void GoToGameOver()
    {
        SceneManager.LoadScene("GAME OVER"); // Ganti "GameOver" dengan nama scene game over kamu
    }
}
