using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    Rigidbody _Rigidbody;
    
    public float moveSpeed = 5f;
    
    void Awake(){
        _Rigidbody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        //Get move input
        //Pref get input in Update()
        var moveInput = Input.GetAxis("Horizontal");
        
        //Set move velocity
        //Pref interact with physics in FixedUpdate()
        _Rigidbody.velocity = new Vector3(moveSpeed * moveInput, _Rigidbody.velocity.y, 0);
    }
}
