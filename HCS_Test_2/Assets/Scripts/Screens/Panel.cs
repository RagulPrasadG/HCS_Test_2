using UnityEngine;

public abstract class Panel : MonoBehaviour
{
    public PanelType panelType;
    public abstract void Show();
    public abstract void Hide();
}

public enum PanelType
{
    MainMenu,
    Settings,
    PauseMenu,
    LevelSelection,
    GameOver,
    GamePlay,
}
