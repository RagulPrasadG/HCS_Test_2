using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "NewGameData",menuName = "Data/NewGameData")]
public class GameDataSO : ScriptableObject
{
    [Header("[GAME CONFIG]")]
    [Range(-20,20f)]
    public float sfxVolume;
    [Range(-20, 20f)]
    public float musicVolume;
    [Range(-20, 20f)]
    public float masterVolume;
    public GraphicsQuality graphicsQuality;
    public Shadows shadows;
}

