using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUIData",menuName = "Data/NewUIData")]
public class UIDataSO : ScriptableObject
{
    public List<Panel> panelPrefabs;
}
