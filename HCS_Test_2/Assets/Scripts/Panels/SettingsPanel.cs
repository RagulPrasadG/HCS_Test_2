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
    [SerializeField] Button backButton;

    [SerializeField] GameDataSO gameDataSO;
    [SerializeField] EventServiceSO eventServiceSO;

    private void OnEnable()
    {
        musicSlider.onValueChanged.AddListener(OnMusicVolumeChanged);
        sfxSlider.onValueChanged.AddListener(OnSFXVolumeChanged);
        graphicsQualityDropDown.onValueChanged.AddListener(OnGraphicsQualityChanged);
        shadowsDropDown.onValueChanged.AddListener(OnToggleShadows);
        backButton.onClick.AddListener(OnBackButtonClicked);
    }

    private void OnDisable()
    {
        musicSlider.onValueChanged.RemoveListener(OnMusicVolumeChanged);
        sfxSlider.onValueChanged.RemoveListener(OnSFXVolumeChanged);
        graphicsQualityDropDown.onValueChanged.RemoveListener(OnGraphicsQualityChanged);
        shadowsDropDown.onValueChanged.RemoveListener(OnToggleShadows);
        backButton.onClick.RemoveListener(OnBackButtonClicked);
    }


    public void OnMusicVolumeChanged(float value) => gameDataSO.musicVolume = value;

    public void OnSFXVolumeChanged(float value) => gameDataSO.sfxVolume = value;

    public void OnGraphicsQualityChanged(int value) => gameDataSO.graphicsQuality = (GraphicsQuality)value;

    public void OnToggleShadows(int value) => gameDataSO.shadows = (Shadows)value;

    public void OnBackButtonClicked()
    {
        eventServiceSO.OnClickBackFromSettings.RaiseEvent(PanelType.MainMenu);
        this.Hide();
    }
}
