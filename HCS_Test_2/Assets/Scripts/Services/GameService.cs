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

    public void SetEvents()
    {
        SceneManager.sceneLoaded += OnSceneChanged;
        eventServiceSO.OnClickPauseButton.AddListener(delegate { ToggleGamePause(true); });
        eventServiceSO.OnClickLevelSlotButton.AddListener(LoadLevel);
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

    public void LoadLevel(LevelType levelType) => SceneManager.LoadScene(nameof(levelType));

    public void ToggleGamePause(bool toggle) => Time.timeScale = toggle ? 0 : 1;

}
