using UnityEngine;

public abstract class Panel : MonoBehaviour
{
    public PanelType panelType;
    public virtual void Show() => this.gameObject.SetActive(true);
    public virtual void Hide() => this.gameObject.SetActive(false);

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
