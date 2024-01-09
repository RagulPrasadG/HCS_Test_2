using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayUIService : UIService
{
    [SerializeField] Button pauseButton;
    [SerializeField] Button gameOverButton;

    private void OnEnable()
    {
        pauseButton.onClick.AddListener(OnClickPauseButton);
        gameOverButton.onClick.AddListener(OnClickGameOverButton);
        eventServiceSO.OnClickSettingsButton.AddListener(ShowPanel);
        eventServiceSO.OnClickBackFromSettings.AddListener(delegate { ShowPanel(PanelType.PauseMenu);});
        eventServiceSO.OnClickResumeButton.AddListener(OnClickResumeButton);

    }

    private void OnDisable()
    {
        pauseButton.onClick.RemoveListener(OnClickPauseButton);
        gameOverButton.onClick.RemoveListener(OnClickGameOverButton);
        eventServiceSO.OnClickSettingsButton.RemoveListener(ShowPanel);
        eventServiceSO.OnClickBackFromSettings.RemoveListener(delegate { ShowPanel(PanelType.PauseMenu);});
        eventServiceSO.OnClickResumeButton.RemoveListener(OnClickResumeButton);
    }

    private void OnClickPauseButton()
    {
        pauseButton.interactable = false;
        gameOverButton.interactable = false;
        SoundService.Instance.PlaySFX(SoundType.BUTTONCLICK);
        ShowPanel(PanelType.PauseMenu);
        eventServiceSO.OnClickPauseButton.RaiseEvent();
    }

    private void OnClickResumeButton()
    {
        pauseButton.interactable = true;
        gameOverButton.interactable = true;
    }

    private void OnClickGameOverButton()
    {
        pauseButton.interactable = false;
        gameOverButton.interactable = false;
        ShowPanel(PanelType.GameOver);
        eventServiceSO.OnClickGameOverButton.RaiseEvent();
    }
}
