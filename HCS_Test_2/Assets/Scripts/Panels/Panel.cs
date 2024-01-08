using System.Collections;
using UnityEngine;

public abstract class Panel : MonoBehaviour
{
    public PanelType panelType;
    protected Animator animator;


    public virtual void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public virtual void Show() => this.gameObject.SetActive(true);

    public virtual void Hide()
    {
        animator.SetTrigger("Close");
        this.gameObject.SetActive(false);
    }
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
