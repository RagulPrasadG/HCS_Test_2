using System.Collections;
using System.Collections.Generic;
using Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameService : GenericSingleton<GameService>
{
    [SerializeField] GameDataSO gameDataSO;
    public UIService UIservice { get; set; }

    public override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this.gameObject);
        Init();
    }

    public void Init()
    {
        SceneManager.sceneLoaded += OnSceneChanged;
    }

    public void OnSceneChanged(Scene scene,LoadSceneMode loadSceneMode)
    {
        UIservice = FindAnyObjectByType<UIService>();
    }

    public void ChangeGraphicsQuality(int value)
    {
        gameDataSO.graphicsQuality = (GraphicsQuality)value;
        QualitySettings.SetQualityLevel(value);
    }

   

}
