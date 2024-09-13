using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("masterVolume"))
        {
        PlayerPrefs.SetFloat("masterVolume", 1);
        LoadNewVolume();
        }
        else
        {
        LoadNewVolume();
        }
    }

    // Update is called once per frame
    public void AdjustVolume()
    {
        AudioListener.volume = volumeSlider.value;
        SaveNewVolume();
    }

    private void LoadNewVolume()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("masterVolume");
    }

    private void SaveNewVolume()
    {
        PlayerPrefs.GetFloat("masterVolume", volumeSlider.value);
    }
}
