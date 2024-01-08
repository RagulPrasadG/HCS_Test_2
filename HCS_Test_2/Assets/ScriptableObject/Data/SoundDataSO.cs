using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "NewSoundService",menuName = "Services/NewSoundService")]
public class SoundDataSO : ScriptableObject
{
    [SerializeField] List<SoundData> sounds;
    public SoundData GetSoundData(SoundType soundType)
    {
        return sounds.Find(sound => sound.soundType == soundType);
    }
    
}

[System.Serializable]
public struct SoundData
{
    public SoundType soundType;
    public AudioClip audioClip;
}
