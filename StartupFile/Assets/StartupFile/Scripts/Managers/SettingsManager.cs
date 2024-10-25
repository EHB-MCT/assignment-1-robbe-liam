using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    private static SettingsManager _instance;

    public static SettingsManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject settingsManager = new GameObject("SettingsManager");
                _instance = settingsManager.AddComponent<SettingsManager>();
                DontDestroyOnLoad(settingsManager);
            }
            return _instance;
        }
    }

    [Range(0, 1)] public float masterVolume = 1.0f;
    [Range(0, 1)] public float musicVolume = 0.5f;
    [Range(0, 1)] public float sfxVolume = 0.5f;
    public int graphicsQuality = 2;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);

        LoadSettings();
    }

    public void SetMasterVolume(float volume)
    {

    }

    public void SetMusicVolume(float volume)
    {

    }

    public void SetSFXVolume(float volume)
    {

    }

    public void SetGraphicsQuality(int quality)
    {

    }

    private void SaveSettings()
    {

    }

    private void LoadSettings()
    {

    }

    public void ResetSettings()
    {

    }
}