namespace Utilities
{
    using System;
    using UnityEngine;

    public class VoidEventController
    {
        public Action baseEvent;
        public void AddListener(Action listenerToAdd) => baseEvent += listenerToAdd;

        public void RemoveListener(Action listenerToRemove) => baseEvent -= listenerToRemove;
 
        public void RaiseEvent() => baseEvent?.Invoke();
   
    }

    public class GenericEventController<T>
    {
        public Action<T> baseEvent;
        public void AddListener(Action<T> listenerToAdd) => baseEvent += listenerToAdd;

        public void RemoveListener(Action<T> listenerToRemove) => baseEvent -= listenerToRemove;

        public void RaiseEvent(T param) => baseEvent?.Invoke(param);
    }

    public class GenericSingleton<T> : MonoBehaviour where T : GenericSingleton<T>
    {
        public static T Instance { get; private set; }

        public virtual void Awake()
        {
            if (Instance == null)
            {
                Instance = (T)this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }

}

public enum GraphicsQuality
{
    VERYLOW,
    LOW,
    MEDIUM,
    HIGH,
    VERYHIGH,
    ULTRA
}


