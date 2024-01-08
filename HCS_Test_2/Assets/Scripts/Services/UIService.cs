using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UIService : MonoBehaviour
{
    public List<Panel> scenePanels;
    public Canvas canvas;
    public EventServiceSO eventServiceSO;

    protected Stack<Panel> activePanelsStack = new Stack<Panel>();
    

    public void ShowPanel(PanelType panelTypeToShow)
    {
        if (scenePanels.Count == 0)
        {
            Debug.LogError("No panel is added to the panels list!!");
            return;
        }

        HideActivePanel();

        Panel panelToShow = scenePanels.Find(panel => panel.panelType == panelTypeToShow);

        if (panelToShow != null)
            panelToShow.Show();

        activePanelsStack.Push(panelToShow);
    }

    public void HideActivePanel()
    {
        if (activePanelsStack.Count == 0)
            return;

        Panel activepanel = activePanelsStack.Pop();
        if (activepanel != null)
        {
            activepanel.Hide();
        }
    }
}
