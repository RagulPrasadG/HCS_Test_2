using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "NewLevelData",menuName = "Data/NewLevelData")]
public class LevelDataSO : ScriptableObject
{
    [SerializeField] List<LevelData> levelDataList;
    public LevelData GetLevelData(LevelType levelType)
    {
        return levelDataList.Find(levelData => levelData.levelType == levelType);
    }
    public List<LevelData> GetLevelList() => levelDataList;

}

[System.Serializable]
public struct LevelData
{
    public LevelType levelType;
    public Sprite sceneThumbnail;
}

public enum LevelType
{
    Town,
    Office
}
