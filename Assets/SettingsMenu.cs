using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;


public class SettingsMenu : MonoBehaviour
{
    [SerializeField] AudioMixer musicMixer;
    [SerializeField] AudioMixer vfxMixer;
    [SerializeField] TMP_Dropdown resolutionDropdown;
    Resolution[] resolutions;
    private void Start()
    {
        SetupResolutionsDropdown();
    }
    public void SetResolution(int resolutionIndex)
    {
        Screen.SetResolution(resolutions[resolutionIndex].width, resolutions[resolutionIndex].height,Screen.fullScreen);
    }
    private void SetupResolutionsDropdown()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> resolutionsStrings = new List<string>();
        int selectedIndex = 0;
        foreach (Resolution resolution in resolutions)
        {
            var resStr = $"{resolution.width}:{resolution.height} @{resolution.refreshRate}Hz";
            resolutionsStrings.Add(resStr);
            if (resolution.width == Screen.currentResolution.width && resolution.height == Screen.currentResolution.height)
            {
                selectedIndex = resolutionsStrings.Count - 1;
            }
        }
        resolutionDropdown.AddOptions(resolutionsStrings);
        resolutionDropdown.value = selectedIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetVFXVolume(float volume)
    {
        vfxMixer.SetFloat("volume", volume);
    }
    public void SetMusicVolume(float volume) 
    {
        musicMixer.SetFloat("volume", volume);
    }
    public void SetQuality(int qualityLevel)
    {
        QualitySettings.SetQualityLevel(qualityLevel);
    }
    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
