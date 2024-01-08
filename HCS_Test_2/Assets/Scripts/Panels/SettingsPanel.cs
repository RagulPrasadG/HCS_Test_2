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


    public void OnMusicVolumeChanged(float value) => SoundService.Instance.SetMusicVolume(value);

    public void OnSFXVolumeChanged(float value) => SoundService.Instance.SetSFXVolume(value);

    public void OnGraphicsQualityChanged(int value) => GameService.Instance.ChangeGraphicsQuality(value);

    public void OnToggleShadows(int value) => gameDataSO.shadows = (Shadows)value;

    public void OnBackButtonClicked()
    {
        SoundService.Instance.PlaySFX(SoundType.BUTTONCLICK);
        eventServiceSO.OnClickBackFromSettings.RaiseEvent(PanelType.MainMenu);
        this.Hide();
    }
}
