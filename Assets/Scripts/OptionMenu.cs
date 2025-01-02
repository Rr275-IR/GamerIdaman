using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OptionMenu : MonoBehaviour
{
    public Toggle musicToggle;
    public Toggle soundEffectsToggle;

    void Start()
    {
        // Muat preferensi pemain (1 = true, 0 = false)
        bool isMusicEnabled = PlayerPrefs.GetInt("MusicEnabled", 1) == 1; // Default: true
        bool areSoundEffectsEnabled = PlayerPrefs.GetInt("SoundEffectsEnabled", 1) == 1; // Default: true

        // Set nilai awal Toggle
        musicToggle.isOn = isMusicEnabled;
        soundEffectsToggle.isOn = areSoundEffectsEnabled;

        // Terapkan pengaturan saat start
        ApplyMusicSetting(isMusicEnabled);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public class MenuController : MonoBehaviour
    {
        public GameObject mainMenuCanvas;
        public GameObject optionCanvas;

        public void ShowOptions()
        {
            mainMenuCanvas.SetActive(false);
            optionCanvas.SetActive(true);
        }

        public void BackToMainMenu()
        {
            optionCanvas.SetActive(false);
            mainMenuCanvas.SetActive(true);
        }
    }
    public void OnMusicToggleChanged()
    {
        bool isMusicEnabled = musicToggle.isOn;
        PlayerPrefs.SetInt("MusicEnabled", isMusicEnabled ? 1 : 0);
        PlayerPrefs.Save();
        ApplyMusicSetting(isMusicEnabled);
    }

    public void OnSoundEffectsToggleChanged()
    {
        bool areSoundEffectsEnabled = soundEffectsToggle.isOn;
        PlayerPrefs.SetInt("SoundEffectsEnabled", areSoundEffectsEnabled ? 1 : 0);
        PlayerPrefs.Save();
        // Terapkan logika efek suara di sini
    }

    private void ApplyMusicSetting(bool isEnabled)
    {
        if (AudioManager.instance != null)
        {
            AudioManager.instance.ToggleMusic(isEnabled);
        }
        else
        {
            Debug.LogError("AudioManager instance is missing!");
        }
    }

}
