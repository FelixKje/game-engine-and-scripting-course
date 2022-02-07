using System;
using UnityEngine;

public class GameEventCallerExample : MonoBehaviour{
    [SerializeField] KeyCode keyToCallGameEvent;
    [SerializeField] GameEvent gameEventToCall;

    void Update(){
        if(Input.GetKeyDown(keyToCallGameEvent))
            gameEventToCall.OnGameEvent.Invoke();
    }
}
