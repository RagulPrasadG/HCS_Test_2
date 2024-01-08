using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "NewGameData",menuName = "Data/NewGameData")]
public class GameDataSO : ScriptableObject
{
    [Header("[GAME CONFIG]")]
    public float sfxVolume;
    public float musicVolume;
    public GraphicsQuality graphicsQuality;
    public Shadows shadows;
}

