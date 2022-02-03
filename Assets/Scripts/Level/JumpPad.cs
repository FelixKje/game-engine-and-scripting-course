using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour{
    [SerializeField] float jumpForce = 1500f;

    void OnTriggerEnter(Collider other){
        // var otherRigidbody = other.GetComponent<Rigidbody>();
        // if (otherRigidbody == null)
        //     return;
        // otherRigidbody.AddForce(transform.up * jumpForce);
        other.GetComponent<Rigidbody>()?.AddForce(transform.up * jumpForce);
    }
}
