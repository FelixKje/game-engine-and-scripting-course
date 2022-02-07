using System;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour{
    [SerializeField] GameEvent gameEvent;
    [SerializeField] UnityEvent onGameEvent;

    void OnEnable(){
        gameEvent.OnGameEvent += InvokeUnityEvent; //Subscribe to the gameEvent action
    }

    void OnDisable(){
        gameEvent.OnGameEvent -= InvokeUnityEvent; //Unsubscribe to the gameEvent action
    }

    void InvokeUnityEvent(){
        onGameEvent.Invoke();
    }
}
