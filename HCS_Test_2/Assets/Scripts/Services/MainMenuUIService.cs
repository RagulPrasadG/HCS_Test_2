using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUIService : UIService
{
    private void Awake()
    {
        activePanelsStack.Push(scenePanels.Find(panel => panel.panelType == PanelType.MainMenu));
    }

    private void OnEnable()
    {
        eventServiceSO.OnClickBackFromSettings.AddListener(ShowPanel);
        eventServiceSO.OnClickSettingsButton.AddListener(ShowPanel);
        eventServiceSO.OnClickPlayButton.AddListener(ShowPanel);
        eventServiceSO.OnClickBackFromLevelSelection.AddListener(ShowPanel);
    }

    private void OnDisable()
    {
        eventServiceSO.OnClickBackFromSettings.RemoveListener(ShowPanel);
        eventServiceSO.OnClickSettingsButton.RemoveListener(ShowPanel);
        eventServiceSO.OnClickPlayButton.RemoveListener(ShowPanel);
        eventServiceSO.OnClickBackFromLevelSelection.RemoveListener(ShowPanel);
    }
    
}
