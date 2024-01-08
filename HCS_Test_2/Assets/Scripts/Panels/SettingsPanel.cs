using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsPanel : Panel
{
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;
    [SerializeField] TMP_Dropdown graphicsQualityDropDown;
    [SerializeField] TMP_Dropdown shadowsDropDown;

    [SerializeField] GameDataSO gameDataSO;
    private void OnEnable()
    {
        musicSlider.onValueChanged.AddListener(OnMusicVolumeChanged);
        sfxSlider.onValueChanged.AddListener(OnSFXVolumeChanged);
        graphicsQualityDropDown.onValueChanged.AddListener(OnGraphicsQualityChanged);
        shadowsDropDown.onValueChanged.AddListener(OnToggleShadows);
    }

    private void OnDisable()
    {
        musicSlider.onValueChanged.RemoveListener(OnMusicVolumeChanged);
        sfxSlider.onValueChanged.RemoveListener(OnSFXVolumeChanged);
        graphicsQualityDropDown.onValueChanged.RemoveListener(OnGraphicsQualityChanged);
        shadowsDropDown.onValueChanged.RemoveListener(OnToggleShadows);
    }


    public void OnMusicVolumeChanged(float value) => gameDataSO.musicVolume = value;

    public void OnSFXVolumeChanged(float value) => gameDataSO.sfxVolume = value;

    public void OnGraphicsQualityChanged(int value) => gameDataSO.graphicsQuality = (GraphicsQuality)value;

    public void OnToggleShadows(int value) => gameDataSO.shadows = (Shadows)value;
   
}
