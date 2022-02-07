using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Utility/GameEvent")]
public class GameEvent : ScriptableObject{
    public Action OnGameEvent;
}
