using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    // set variables
    // references
    public AudioMixer audioMixer;

    Resolution[] resolutions;

    public TMP_Dropdown resolutionDropdown;

    void Start()
    {
        // get the resolutions
        resolutions = Screen.resolutions;
        // clear the default options
        resolutionDropdown.ClearOptions();

        // create a list of strings which are our options
        List<string> options = new List<string>();

        // an int to store the current resoulution index
        int currentResoulutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            // create the string
            string option = resolutions[i].width + " x " + resolutions[i].height;
            // add it to the list
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                // set the current resoulution
                currentResoulutionIndex = i;
            }
        }
        // add the options in the list options to the resolution dropdown
        resolutionDropdown.AddOptions(options);
        // set the value of the current resolution
        resolutionDropdown.value = currentResoulutionIndex;
        // to display the new current value
        resolutionDropdown.RefreshShownValue();
    }

    // adjust resoultion based on the dropdown chosen
    public void SetResolution(int resoulutionIndex)
    {
        // use the resolution index to find the correct element in our array
        Resolution resolution = resolutions[resoulutionIndex];
        // set the screen resolution
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    // adjust Master audiomixer group by main volume slider
    public void SetMainVolume(float volume)
    {
        audioMixer.SetFloat("MainVolume", volume);
        PlayerPrefs.SetFloat("mainVolume", volume);
    }

    // adjust BGM audiomixer group by bgm volume slider
    public void SetBGMVolume(float volume)
    {
        audioMixer.SetFloat("BGMVolume", volume);
        PlayerPrefs.SetFloat("bgmVolume", volume);
    }

    // adjust SFX audiomixer group by sfx volume slider
    public void SetSFXVolume(float volume)
    {
        audioMixer.SetFloat("SFXVolume", volume);
        PlayerPrefs.SetFloat("sfxVolume", volume);
    }

    // adjust Ambience audiomixer group by ambience slider
    public void SetAmbienceVolume(float volume)
    {
        audioMixer.SetFloat("AmbienceVolume", volume);
        PlayerPrefs.SetFloat("ambienceVolume", volume);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
