using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Restart : MonoBehaviour
{
    private const string StartSceneKey = "StartScene"; // Key untuk menyimpan nama scene awal
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void SaveStartScene(string sceneName)
    {
        PlayerPrefs.SetString(StartSceneKey, sceneName); // Simpan nama scene
        PlayerPrefs.Save();
    }
    public void RestartToIntialScene()
    {
        // Ambil nama scene awal dari PlayerPrefs
        string startScene = PlayerPrefs.GetString(StartSceneKey, SceneManager.GetActiveScene().name);

        // Pindah ke scene awal
        SceneManager.LoadScene(startScene);
    }
}
