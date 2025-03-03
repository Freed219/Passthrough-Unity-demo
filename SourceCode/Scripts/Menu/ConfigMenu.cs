using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ConfigMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetSoundVolume(float volume)
    {
        audioMixer.SetFloat("soundvolume", volume);
    }
    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("musicvolume", volume);
    }
    public void SetQuality(int qualityindex)
    {
        QualitySettings.SetQualityLevel(qualityindex);
    }
}
