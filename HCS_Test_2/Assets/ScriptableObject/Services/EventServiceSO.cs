using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities;

[CreateAssetMenu (fileName = "NewEventService",menuName = "Services/NewEventService")]
public class EventServiceSO : ScriptableObject
{
    [Header("SettingsPanelEvents")]
    public GenericEventController<PanelType> OnClickBackFromSettings;


}


