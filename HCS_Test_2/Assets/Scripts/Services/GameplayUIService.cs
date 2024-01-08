using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayUIService : UIService
{
    [SerializeField] Button pauseButton;
    private void OnEnable()
    {
        eventServiceSO.OnClickPauseButton.AddListener(OnClickPauseButton);
    }

    private void OnDisable()
    {
        eventServiceSO.OnClickPauseButton.RemoveListener(OnClickPauseButton);
    }

    private void OnClickPauseButton()
    {
        ShowPanel(PanelType.PauseMenu);
        eventServiceSO.OnClickPauseButton.RaiseEvent();
    }

}
