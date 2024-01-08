using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUIService : MonoBehaviour
{

    [Header("MainMenuPanels")]
    

    [SerializeField] Canvas mainMenuCanvas;
    [SerializeField] UIDataSO UIDataSO;


    private List<Panel> panelInstances;


    public void ShowPanel(PanelType panelType)
    {
        Panel panel = panelInstances.Find(panel => panel.panelType == panelType);
        if (panel == null)
            CreatePanel(panelType);
        else
            panel.Show();
           
    }

    public void CreatePanel(PanelType panelType)
    {
        Panel panel = UIDataSO.panelPrefabs.Find(panel => panel.panelType == panelType);
        var panelInstance = Object.Instantiate(panel, mainMenuCanvas.transform);
        panelInstances.Add(panelInstance);
        panelInstance.Show();
    }

}
