using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "NewGameData",menuName = "Data/NewGameData")]
public class GameDataSO : ScriptableObject
{
    [Header("PANEL PREFABS")]
    public List<Panel> panelPrefabs;
}
