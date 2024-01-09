using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelSelectionPanel : Panel
{
    [SerializeField] LevelSlotButtonVIew levelSlotButtonPrefab;
    [SerializeField] Button backButton;
    [SerializeField] LevelDataSO levelDataSO;
    [SerializeField] EventServiceSO eventServiceSO;
    [SerializeField] RectTransform levelListContainer;

    public override void Awake()
    {
        base.Awake();
        CreateLevelList();
    }

    private void OnEnable()
    {
        backButton.onClick.AddListener(OnClickBackButton);
    }

    private void OnDisable()
    {
        backButton.onClick.RemoveListener(OnClickBackButton);
    }

    private void OnClickBackButton()
    {
        SoundService.Instance.PlaySFX(SoundType.BUTTONCLICK);
        eventServiceSO.OnClickBackFromLevelSelection.RaiseEvent(PanelType.MainMenu);
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
