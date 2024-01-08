using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities;

[CreateAssetMenu (fileName = "NewEventService",menuName = "Services/NewEventService")]
public class EventServiceSO : ScriptableObject
{
    #region UIEvents
    [Header("SettingsPanelEvents")]
    public GenericEventController<PanelType> OnClickBackFromSettings = new GenericEventController<PanelType>();

    [Header("MainMenuPanelEvents")]
    public GenericEventController<PanelType> OnClickPlayButton = new GenericEventController<PanelType>();
    public GenericEventController<PanelType> OnClickSettingsButton = new GenericEventController<PanelType>();
    public VoidEventController OnClickExitButton = new VoidEventController();
    #endregion
    

}


