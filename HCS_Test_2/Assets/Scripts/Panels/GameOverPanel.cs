using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverPanel : Panel
{
    [SerializeField] Button retryButton;
    [SerializeField] Button mainMenuButton;
    [SerializeField] EventServiceSO eventServiceSO;

    private void OnEnable()
    {
        retryButton.onClick.AddListener(OnRetryClicked);
        mainMenuButton.onClick.AddListener(OnMainMenuButtonClicked);
    }

    private void OnDisable()
    {
        retryButton.onClick.RemoveListener(OnRetryClicked);
        mainMenuButton.onClick.RemoveListener(OnMainMenuButtonClicked);
    }

    public void OnRetryClicked()
    {
        SoundService.Instance.PlaySFX(SoundType.BUTTONCLICK);
        eventServiceSO.OnClickRetryButton.RaiseEvent();
    }
     
    public void OnMainMenuButtonClicked()
    {
        SoundService.Instance.PlaySFX(SoundType.BUTTONCLICK);
        eventServiceSO.OnClickMainMenuButton.RaiseEvent();
    }

}
