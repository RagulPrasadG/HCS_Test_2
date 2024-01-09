using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuPanel : Panel
{
    [SerializeField] Button resumeButton;
    [SerializeField] Button settingsButton;
    [SerializeField] Button mainMenuButton;
    [SerializeField] EventServiceSO eventServiceSO;

    private void OnEnable()
    {
        resumeButton.onClick.AddListener(OnResumebuttonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        mainMenuButton.onClick.AddListener(OnMainMenuButtonClicked);
    }

    private void OnDisable()
    {
        resumeButton.onClick.RemoveListener(OnResumebuttonClicked);
        settingsButton.onClick.RemoveListener(OnSettingsButtonClicked);
        mainMenuButton.onClick.RemoveListener(OnMainMenuButtonClicked);
    }

    public void OnResumebuttonClicked()
    {
        SoundService.Instance.PlaySFX(SoundType.BUTTONCLICK);
        eventServiceSO.OnClickResumeButton.RaiseEvent();
        this.Hide();
    }

    public void OnSettingsButtonClicked()
    {
        SoundService.Instance.PlaySFX(SoundType.BUTTONCLICK);
        eventServiceSO.OnClickSettingsButton.RaiseEvent(PanelType.Settings);
    }

    public void OnMainMenuButtonClicked()
    {
        SoundService.Instance.PlaySFX(SoundType.BUTTONCLICK);
        eventServiceSO.OnClickMainMenuButton.RaiseEvent();
    }

    public void OnGamePaused()
    { 
        //SoundService.Instance.SetMasterVolume(-80f);
    }
}
