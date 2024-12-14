using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonManager : MonoBehaviour
{
    private static string previousScene; // Menyimpan nama scene sebelumnya

    public static void LoadScene(string sceneName)
    {
        // Simpan nama scene saat ini sebagai previousScene
        previousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }

    public static void GoBack()
    {
        if (!string.IsNullOrEmpty(previousScene))
        {
            // Pindah ke scene sebelumnya
            SceneManager.LoadScene(previousScene);
        }
        else
        {
            Debug.Log("No previous scene set.");
        }
    }
}
