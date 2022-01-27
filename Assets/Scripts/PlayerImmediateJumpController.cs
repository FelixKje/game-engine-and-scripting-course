using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    Rigidbody _Rigidbody;
    
    public float jumpForce = 500f;

    void Awake(){
        _Rigidbody = GetComponent<Rigidbody>();
    }

    void Update(){
        //Get move input
        //Pref get input in Update()
        var jumpInput = Input.GetKeyDown(KeyCode.Space);
        
        //Apply jump force
        //Pref interact with physics in FixedUpdate()
        if (jumpInput && _Rigidbody.velocity.y == 0)
            _Rigidbody.AddForce(Vector3.up * jumpForce);
    }
}
