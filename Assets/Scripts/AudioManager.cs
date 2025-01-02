using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
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
    }

    public void ToggleMusic(bool isEnabled)
    {
        if (audioSource != null)
        {
            audioSource.mute = !isEnabled;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
