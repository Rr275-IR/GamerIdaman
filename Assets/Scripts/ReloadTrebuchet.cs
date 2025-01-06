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

    public GameObject inputCanvas;
    public GameObject gameCanvas; 
    public TMP_InputField forceInputField;
    void Start()
    {
        if (forceInputField == null)
        {
            GameObject inputFieldObject = GameObject.FindGameObjectWithTag("InputField");
            if (inputFieldObject != null)
            {
                forceInputField = inputFieldObject.GetComponent<TMP_InputField>();
            }
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
                ResetUI();
        }
    }

    public void ReplaceTrebuchet()
    {
        if (float.TryParse(forceInputField.text, out float newForce))
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
    }

    private void UpdateRemainingReplacementsText()
    {
        if (replacementText != null)
        {
            replacementText.text = $"Replacements Left: {maxReplacements - replacementCount}";
        }
        if (replacementCount > maxReplacements)
        {
            GoToGameOver();
        }
    }

    private void GoToGameOver()
    {
        BackButtonManager.LoadScene("GAME OVER");
    }
    public void ResetUI()
    {
        if (replacementCount != maxReplacements && replacementCount < maxReplacements)
        {
            if (inputCanvas != null)
            {
            inputCanvas.SetActive(true); // Tampilkan canvas input gaya
            }

            if (gameCanvas != null)
            {
            gameCanvas.SetActive(false); // Sembunyikan canvas utama game
            }

            if (forceInputField != null)
            {
            forceInputField.text = ""; // Kosongkan input field
            }
        }
        else
        {
            GoToGameOver();
        }
    }
}
