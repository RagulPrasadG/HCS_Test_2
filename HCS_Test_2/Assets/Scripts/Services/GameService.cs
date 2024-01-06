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
    public UIService UIservice { get; set; }
    #endregion

    #region Config

    #endregion

}
