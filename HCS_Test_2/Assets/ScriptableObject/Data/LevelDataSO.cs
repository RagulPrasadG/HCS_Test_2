using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "NewLevelData",menuName = "Data/NewLevelData")]
public class LevelDataSO : ScriptableObject
{
    [SerializeField] List<LevelData> levelDataList;
    public LevelData GetLevelData(string levelName)
    {
        return levelDataList.Find(levelData => levelData.levelName == levelName);
    }
    public List<LevelData> GetLevelList() => levelDataList;

}

[System.Serializable]
public struct LevelData
{
    public string levelName;
    public Sprite sceneThumbnail;
}

