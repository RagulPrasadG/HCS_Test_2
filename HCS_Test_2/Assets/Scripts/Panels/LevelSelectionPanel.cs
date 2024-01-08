using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectionPanel : Panel
{
    [SerializeField] LevelSlotButtonVIew levelSlotButtonPrefab;
    [SerializeField] LevelDataSO levelDataSO;
    [SerializeField] RectTransform levelListContainer;

    public override void Awake()
    {
        base.Awake();
        CreateLevelList();
    }

    private void CreateLevelList()
    {
        foreach(var levelData in levelDataSO.GetLevelList())
        {
            LevelSlotButtonVIew levelSlotButton =  Instantiate(levelSlotButtonPrefab);
            levelSlotButton.transform.SetParent(levelListContainer);
            levelSlotButton.Init(levelData);
        }
    }
}
