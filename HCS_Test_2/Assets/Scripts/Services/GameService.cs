using System.Collections;
using System.Collections.Generic;
using Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameService : GenericSingleton<GameService>
{
    [SerializeField] GameDataSO gameDataSO;
    [SerializeField] EventServiceSO eventServiceSO;

    public UIService UIservice { get; set; }

    public override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this.gameObject);
        SetEvents();
    }

    public void Start()
    {
        SetGameConfig();
    }

    public void SetEvents()
    {
        SceneManager.sceneLoaded += OnSceneChanged;
        eventServiceSO.OnClickLevelSlotButton.AddListener(LoadLevel);
        eventServiceSO.OnClickMainMenuButton.AddListener(delegate { LoadLevel("MainMenu"); });
        eventServiceSO.OnClickExitButton.AddListener(OnQuitGame);
        eventServiceSO.OnClickRetryButton.AddListener(OnRetryGame);
    }


    //gets reference for the active UI handler of the current scene
    public void OnSceneChanged(Scene scene,LoadSceneMode loadSceneMode)
    {
        UIservice = FindAnyObjectByType<UIService>();
    }

    public void ChangeGraphicsQuality(int value)
    {
        gameDataSO.graphicsQuality = (GraphicsQuality)value;
        QualitySettings.SetQualityLevel(value);
    }

    public void OnQuitGame() => Application.Quit();

    public void OnRetryGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    public void SetGameConfig()
    {
        Application.targetFrameRate = 60;
        SoundService.Instance.SetMusicVolume(gameDataSO.musicVolume);
        SoundService.Instance.SetSFXVolume(gameDataSO.sfxVolume);
        ChangeGraphicsQuality((int)gameDataSO.graphicsQuality);
    }

    public void LoadLevel(string levelName) => SceneManager.LoadScene(levelName);



}
