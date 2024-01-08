using System.Collections;
using System.Collections.Generic;
using Utilities;
using UnityEngine;

public class GameService : GenericSingleton<GameService>
{
    #region Data
    [SerializeField] GameDataSO gameDataSO;
    #endregion

    #region Services
    public MainMenuUIService mainMenuUIService { get; set; }
    #endregion


    public override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this.gameObject);
        Init();
    }

    public void Init()
    {
       
    }
}
