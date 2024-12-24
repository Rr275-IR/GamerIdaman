using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ReloadTrebuchet : MonoBehaviour
{
    public GameObject trebuchetPrefab;
    public Transform spawnPoint;
    public int maxReplacements = 10;
    public TMP_Text replacementText;
    private int replacementCount = 0;

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
                GoToGameOver();
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
        if(replacementCount > maxReplacements)
        {
            GoToGameOver();
        }
    }

    private void GoToGameOver()
    {
        SceneManager.LoadScene("GAME OVER LEVEL 1");
    }

}
