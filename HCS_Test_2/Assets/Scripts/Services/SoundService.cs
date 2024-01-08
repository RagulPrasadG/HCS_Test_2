using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using Utilities;

public class SoundService : GenericSingleton<SoundService>
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] AudioSource sfxAudioSource;
    [SerializeField] AudioSource musicAudioSource;

    [SerializeField] SoundDataSO soundDataSO;
    [SerializeField] GameDataSO gameDataSO;

    public override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this.gameObject);
    }

    public void SetSFXVolume(float volume)
    {
        gameDataSO.sfxVolume = volume;
        audioMixer.SetFloat("SFXVolume", volume);
    }

    public void SetMusicVolume(float volume)
    {
        gameDataSO.musicVolume = volume;
        audioMixer.SetFloat("MusicVolume", volume);
    }

    public void SetMasterVolume(float volume)
    {
        gameDataSO.masterVolume = volume;
        audioMixer.SetFloat("MasterVolume", volume);
    }

    public void PlaySFX(SoundType soundType)
    {
        SoundData soundData = soundDataSO.GetSoundData(soundType);
        sfxAudioSource.clip = soundData.audioClip;
        sfxAudioSource.Play();
    }

    public void PlayBGM(SoundType soundType, bool canLoop)
    {
        SoundData soundData = soundDataSO.GetSoundData(soundType);
        musicAudioSource.clip = soundData.audioClip;
        musicAudioSource.loop = canLoop;
        musicAudioSource.Play();
    }

}
