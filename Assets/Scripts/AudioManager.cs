using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private AudioSource audioSource;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start() 
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.mute = PlayerPrefs.GetInt("MusicEnabled", 1) == 0;
    }

    public void ToggleMusic(bool isEnabled)
    {
        Debug.Log("ToggleMusic called with: " + isEnabled);
        if (audioSource != null)
        {
            audioSource.mute = !isEnabled;
        }
    }
}
