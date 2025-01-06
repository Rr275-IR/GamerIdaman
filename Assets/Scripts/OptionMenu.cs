using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{
    public Toggle musicToggle; 

    void Start()
    {

        if (musicToggle != null)
        {
            musicToggle.isOn = PlayerPrefs.GetInt("MusicEnabled", 1) == 1;
            musicToggle.onValueChanged.AddListener(OnMusicToggleChanged);
        }
    }

    private void OnMusicToggleChanged(bool isOn)
    {
        Debug.Log("Music Toggle: " + isOn);
        if (AudioManager.instance != null)
        {
            AudioManager.instance.ToggleMusic(isOn);
        }
        PlayerPrefs.SetInt("MusicEnabled", isOn ? 1 : 0);
        PlayerPrefs.Save();
    }


}
