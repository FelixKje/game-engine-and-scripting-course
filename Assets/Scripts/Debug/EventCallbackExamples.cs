using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventCallbackExamples : MonoBehaviour
{
    void Awake() => Debug.Log("Awake");
    void Start() => Debug.Log("Start");
    void OnEnable() => Debug.Log("OnEnable");
    void OnDisable() => Debug.Log("OnDisable");
    void OnDestroy() => Debug.Log("OnDestroy");
    void OnApplicationQuit() => Debug.Log("OnApplicationQuit");
    // void Update() => Debug.Log("Update");
    // void LateUpdate() => Debug.Log("LateUpdate");
    // void FixedUpdate() => Debug.Log("FixedUpdate");
}
