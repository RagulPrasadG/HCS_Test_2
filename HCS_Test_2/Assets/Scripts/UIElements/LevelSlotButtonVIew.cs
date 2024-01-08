using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSlotButtonVIew : MonoBehaviour
{
    [SerializeField] string levelName;
    [SerializeField] Image levelSlotImage;
    [SerializeField] Button levelSlotButton;

    [SerializeField] EventServiceSO eventServiceSO;
    private void OnEnable()
    {
        levelSlotButton.onClick.AddListener(OnClickLevelSlotButton);
    }
    private void OnDisable()
    {
        levelSlotButton.onClick.RemoveListener(OnClickLevelSlotButton);
    }

    public void Init(LevelData levelData)
    {
        levelSlotImage.sprite = levelData.sceneThumbnail;
        levelName = levelData.levelName;
    }

    private void OnClickLevelSlotButton() => eventServiceSO.OnClickLevelSlotButton.RaiseEvent(levelName);

}
