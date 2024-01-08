using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuPanel : Panel
{
    [SerializeField] Button playButton;
    [SerializeField] Button settingsButton;
    [SerializeField] Button exitButton;

    [SerializeField] EventServiceSO eventServiceSO;

    private void OnEnable()
    {
        playButton.onClick.AddListener(OnClickPlayButton);
        settingsButton.onClick.AddListener(OnClickSettingsButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }

   
    private void OnDisable()
    {
        playButton.onClick.RemoveListener(OnClickPlayButton);
        settingsButton.onClick.RemoveListener(OnClickSettingsButton);
        exitButton.onClick.RemoveListener(OnClickExitButton);
    }


    private void OnClickPlayButton() => eventServiceSO.OnClickPlayButton.RaiseEvent(PanelType.LevelSelection);
    private void OnClickSettingsButton() => eventServiceSO.OnClickSettingsButton.RaiseEvent(PanelType.Settings);
    private void OnClickExitButton() => eventServiceSO.OnClickExitButton.RaiseEvent();

}
