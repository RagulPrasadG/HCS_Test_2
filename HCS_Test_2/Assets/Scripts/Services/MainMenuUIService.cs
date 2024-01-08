using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUIService : MonoBehaviour
{
    [Header("PANELS")]
    [SerializeField] List<Panel> mainMenuScenePanels;

    [Space(10)]
    [SerializeField] Canvas mainMenuCanvas;
    [SerializeField] EventServiceSO eventServiceSO;


    private void OnEnable()
    {
        eventServiceSO.OnClickBackFromSettings.AddListener(ShowPanel);
        eventServiceSO.OnClickSettingsButton.AddListener(ShowPanel);
    }

    private void OnDisable()
    {
        eventServiceSO.OnClickBackFromSettings.RemoveListener(ShowPanel);
        eventServiceSO.OnClickSettingsButton.RemoveListener(ShowPanel);
    }

    public void ShowPanel(PanelType panelTypeToShow)
    {
        if (mainMenuScenePanels.Count == 0)
        {
            Debug.LogError("No panel is added to the panels list!!");
            return;
        }
        
       
        Panel panelToShow = mainMenuScenePanels.Find(panel => panel.panelType == panelTypeToShow);

        if(panelToShow != null)
          panelToShow.Show();

    }

    public void HidePanel(PanelType panelTypeToShow)
    {
        if (mainMenuScenePanels.Count == 0)
        {
            Debug.LogError("No panel is added to the panels list!!");
            return;
        }

        Panel panelToShow = mainMenuScenePanels.Find(panel => panel.panelType == panelTypeToShow);

        if (panelToShow != null)
            panelToShow.Hide();

    }


}
