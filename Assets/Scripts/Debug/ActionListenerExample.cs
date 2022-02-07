using System;
using UnityEngine;

public class ActionListenerExample : MonoBehaviour{
    [SerializeField] ActionEmitterExample actionEmitter;

    void OnEnable() => Subscribe();

    void OnDisable() => UnSubscribe();

    void Subscribe(){
        actionEmitter.onEmptyAction += EmptyActionMethod;
        actionEmitter.onRandomFloatAction += RandomFloatActionMethod;
        actionEmitter.onTransformAction += TransformActionMethod;
    }

    void UnSubscribe(){
        actionEmitter.onEmptyAction -= EmptyActionMethod;
        actionEmitter.onRandomFloatAction += RandomFloatActionMethod;
        actionEmitter.onTransformAction += TransformActionMethod;
    }

    static void EmptyActionMethod() => Debug.Log("Empty action was emitted.");

    static void RandomFloatActionMethod(float randomFloat) => Debug.Log($"Our random float is: {randomFloat}");

    static void TransformActionMethod(Transform emittedTransform) => emittedTransform.position += Vector3.up;
}
