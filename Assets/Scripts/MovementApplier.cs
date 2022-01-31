using System;
using UnityEngine;

public class MovementApplier : MonoBehaviour{
    [SerializeField] Rigidbody rigidbody;

    public Vector3 StoredVelocity => storedVelocity;

    Vector3 storedVelocity;
    Vector3 storedForce;

    void Update(){
        ApplyVelocity();
        ApplyForce();
    }
    

    void ApplyVelocity(){
        rigidbody.velocity = storedVelocity;
    }
    void ApplyForce(){
        rigidbody.AddForce(storedForce);
        storedForce = Vector3.zero;
    }

    public void SetHorizontalVelocity(float horizontalVelocity){
        SetVelocity(new Vector3(horizontalVelocity, storedVelocity.y, storedVelocity.z));
    }

    public void SetVelocity(Vector3 velocity){
        storedVelocity = velocity;
    }

    public void AddForce(Vector3 force){
        storedForce += force;
    }
}
