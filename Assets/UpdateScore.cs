using UnityEngine;
using UnityEngine.UI; // For displaying the score
using TMPro;

public class UpdateScore : MonoBehaviour
{
    public TMP_Text scoreText; // Assign a UI Text element in the Inspector
    private int score = 0;

    // Method to increase score
    public void AddPoints(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // Updates the score text
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
